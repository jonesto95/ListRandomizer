namespace ListRandomizer
{
    partial class ListRandomizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Button_SelectAll = new System.Windows.Forms.Button();
            this.Button_DeselectAll = new System.Windows.Forms.Button();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Button_Go = new System.Windows.Forms.Button();
            this.CheckBox_AllowDuplicates = new System.Windows.Forms.CheckBox();
            this.UpDown_NumResults = new System.Windows.Forms.NumericUpDown();
            this.Label_NumberOfResults = new System.Windows.Forms.Label();
            this.Panel_CheckBoxPanel = new System.Windows.Forms.Panel();
            this.Panel_ResultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_NumResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.Location = new System.Drawing.Point(12, 12);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.Button_Refresh.TabIndex = 0;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            // 
            // Button_SelectAll
            // 
            this.Button_SelectAll.Location = new System.Drawing.Point(93, 12);
            this.Button_SelectAll.Name = "Button_SelectAll";
            this.Button_SelectAll.Size = new System.Drawing.Size(75, 23);
            this.Button_SelectAll.TabIndex = 1;
            this.Button_SelectAll.Text = "Select All";
            this.Button_SelectAll.UseVisualStyleBackColor = true;
            // 
            // Button_DeselectAll
            // 
            this.Button_DeselectAll.Location = new System.Drawing.Point(174, 12);
            this.Button_DeselectAll.Name = "Button_DeselectAll";
            this.Button_DeselectAll.Size = new System.Drawing.Size(75, 23);
            this.Button_DeselectAll.TabIndex = 2;
            this.Button_DeselectAll.Text = "Deselect All";
            this.Button_DeselectAll.UseVisualStyleBackColor = true;
            // 
            // Button_Export
            // 
            this.Button_Export.Location = new System.Drawing.Point(797, 12);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(75, 23);
            this.Button_Export.TabIndex = 3;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = true;
            // 
            // Button_Go
            // 
            this.Button_Go.Location = new System.Drawing.Point(716, 12);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(75, 23);
            this.Button_Go.TabIndex = 4;
            this.Button_Go.Text = "GO";
            this.Button_Go.UseVisualStyleBackColor = true;
            // 
            // CheckBox_AllowDuplicates
            // 
            this.CheckBox_AllowDuplicates.AutoSize = true;
            this.CheckBox_AllowDuplicates.Location = new System.Drawing.Point(579, 16);
            this.CheckBox_AllowDuplicates.Name = "CheckBox_AllowDuplicates";
            this.CheckBox_AllowDuplicates.Size = new System.Drawing.Size(110, 17);
            this.CheckBox_AllowDuplicates.TabIndex = 5;
            this.CheckBox_AllowDuplicates.Text = "Allow Duplicates?";
            this.CheckBox_AllowDuplicates.UseVisualStyleBackColor = true;
            // 
            // UpDown_NumResults
            // 
            this.UpDown_NumResults.Location = new System.Drawing.Point(493, 15);
            this.UpDown_NumResults.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_NumResults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_NumResults.Name = "UpDown_NumResults";
            this.UpDown_NumResults.Size = new System.Drawing.Size(56, 20);
            this.UpDown_NumResults.TabIndex = 6;
            this.UpDown_NumResults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_NumberOfResults
            // 
            this.Label_NumberOfResults.AutoSize = true;
            this.Label_NumberOfResults.Location = new System.Drawing.Point(419, 17);
            this.Label_NumberOfResults.Name = "Label_NumberOfResults";
            this.Label_NumberOfResults.Size = new System.Drawing.Size(68, 13);
            this.Label_NumberOfResults.TabIndex = 7;
            this.Label_NumberOfResults.Text = "Sample Size:";
            // 
            // Panel_CheckBoxPanel
            // 
            this.Panel_CheckBoxPanel.Location = new System.Drawing.Point(12, 41);
            this.Panel_CheckBoxPanel.Name = "Panel_CheckBoxPanel";
            this.Panel_CheckBoxPanel.Size = new System.Drawing.Size(860, 169);
            this.Panel_CheckBoxPanel.TabIndex = 8;
            // 
            // Panel_ResultsPanel
            // 
            this.Panel_ResultsPanel.Location = new System.Drawing.Point(12, 216);
            this.Panel_ResultsPanel.Name = "Panel_ResultsPanel";
            this.Panel_ResultsPanel.Size = new System.Drawing.Size(860, 433);
            this.Panel_ResultsPanel.TabIndex = 9;
            // 
            // ListRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.Panel_ResultsPanel);
            this.Controls.Add(this.Panel_CheckBoxPanel);
            this.Controls.Add(this.Label_NumberOfResults);
            this.Controls.Add(this.UpDown_NumResults);
            this.Controls.Add(this.CheckBox_AllowDuplicates);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.Button_DeselectAll);
            this.Controls.Add(this.Button_SelectAll);
            this.Controls.Add(this.Button_Refresh);
            this.MaximizeBox = false;
            this.Name = "ListRandomizer";
            this.Text = "List Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_NumResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button Button_SelectAll;
        private System.Windows.Forms.Button Button_DeselectAll;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.Button Button_Go;
        private System.Windows.Forms.CheckBox CheckBox_AllowDuplicates;
        private System.Windows.Forms.NumericUpDown UpDown_NumResults;
        private System.Windows.Forms.Label Label_NumberOfResults;
        private System.Windows.Forms.Panel Panel_CheckBoxPanel;
        private System.Windows.Forms.FlowLayoutPanel Panel_ResultsPanel;
    }
}

