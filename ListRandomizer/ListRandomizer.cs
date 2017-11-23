using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ListRandomizer
{
    public partial class ListRandomizer : Form
    {
        private string listsDirectory, resultsDirectory;
        private string[] resultsAsCSV;
        private CheckBox[] checkBox;
        private ListSource[] listSource;

        public ListRandomizer()
        {
            InitializeComponent();

            string currentDirectory = Directory.GetCurrentDirectory();
            listsDirectory = currentDirectory + "/Lists";
            resultsDirectory = currentDirectory + "/Results";

            Directory.CreateDirectory(listsDirectory);
            Directory.CreateDirectory(resultsDirectory);

            // TODO: Add event handlers to the buttons
            Button_Export.Click += new EventHandler(ExportResults);
            Button_DeselectAll.Click += new EventHandler(ToggleAll);
            Button_SelectAll.Click += new EventHandler(ToggleAll);
            Button_Go.Click += new EventHandler(GetRandomResults);
            Button_Refresh.Click += new EventHandler(RefreshFiles);

            Panel_ResultsPanel.SetAutoScrollMargin(Panel_ResultsPanel.Width, Panel_ResultsPanel.Height);

            // Populate list of files to choose from
            RefreshFiles(null, new EventArgs());

            Show();
        }


        #region Button Handlers

        // Get all .rnd files in /Lists and create an appropriate CheckBox and ListSource.
        private void RefreshFiles(object sender, EventArgs e)
        {
            Panel_CheckBoxPanel.Controls.Clear();
            List<CheckBox> temp_checkbox = new List<CheckBox>();
            List<ListSource> temp_listsource = new List<ListSource>();
            string[] files = Directory.GetFiles(listsDirectory, "*.rnd");

            // Populate temp_ lists
            for(int i = 0; i < files.Length; i++)
            {
                temp_checkbox.Add(CreateCheckbox(files[i], i));
                temp_listsource.Add(new ListSource(files[i]));
            }
            // Pass temp_ lists to array data members
            checkBox = temp_checkbox.ToArray();
            listSource = temp_listsource.ToArray();
        }


        // Get a random sample of the chosen size and lists
        private void GetRandomResults(object sender, EventArgs e)
        {
            Button_Export.Enabled = false;
            int numberOfResults = (int)UpDown_NumResults.Value;
            resultsAsCSV = new string[numberOfResults];
            Panel_ResultsPanel.Controls.Clear();

            for (int i = 0; i < checkBox.Length; i++)
            {
                if (checkBox[i].Checked)
                {
                    string[] randomResults = listSource[i].GetRandomizedResults(numberOfResults, CheckBox_AllowDuplicates.Checked);
                    PrintLabel(randomResults);
                    PrintLabel(numberOfResults);
                }
            }
            Button_Export.Enabled = true;
            ExportResults(null, new EventArgs());
        }


        // Exports the current results to a CSV file for Excel
        private void ExportResults(object sender, EventArgs e)
        {
            string fileName = ((sender == null) ? "autosave" : DateTime.Now.ToString()) + ".csv";
            File.WriteAllLines(resultsDirectory + '/' + fileName, resultsAsCSV);
            if (!fileName.StartsWith("a"))
                MessageBox.Show(fileName + " created", "Successful", MessageBoxButtons.OK);
        }


        // Toggles all the checkboxes according to which button was pressed
        private void ToggleAll(object sender, EventArgs e)
        {
            bool isChecked = !((Button)sender).Name[7].Equals('S');
            for(int i = 0; i < checkBox.Length; i++)
                checkBox[i].Checked = isChecked;
        }

        #endregion

        #region Helper Methods

        // Create a CheckBox object to be placed in the CheckBox Panel.
        private CheckBox CreateCheckbox(string fileName, int index)
        {
            CheckBox result = new CheckBox();
            result.Text = GetFileName(fileName, true);
            result.Parent = Panel_CheckBoxPanel;
            result.Location = new Point(3 + 151 * (index / 5), 3 + 23 * (index % 5));
            return result;
        }


        // Get the file name from the absolute path of the file
        private string GetFileName(string filePath, bool truncate)
        {
            string result = filePath.Replace('\\', '/');
            result = result.Substring(result.LastIndexOf('/') + 1);
            result = result.Remove(result.LastIndexOf('.'));
            if (truncate && result.Length > 15)
                result = result.Substring(0, 15) + "...";
            return result;
        }


        // Print the results in a label for the Flow Layout Panel
        private void PrintLabel(string[] results)
        {
            Label result = new Label();
            result.AutoSize = true;
            result.TextAlign = ContentAlignment.MiddleCenter;
            result.Parent = Panel_ResultsPanel;
            for (int i = 0; i < results.Length; i++)
            {
                result.Text += results[i] + '\n';
                resultsAsCSV[i] += results[i] + ',';
            }
            result.Text += '\n';
        }


        // Print a vertical column separator Label for the Flow Layout Panel;
        private void PrintLabel(int numberOfLines)
        {
            Label result = new Label();
            result.AutoSize = true;
            result.TextAlign = ContentAlignment.MiddleCenter;
            result.Parent = Panel_ResultsPanel;
            for(int i = 0; i < numberOfLines; i++)
                result.Text += "|\n";
            result.Text += '\n';
        }

        #endregion
    }
}
