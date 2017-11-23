using System;
using System.Collections.Generic;
using System.IO;

namespace ListRandomizer
{
    class ListSource
    {
        private List<string> content;
        private Random r;

        public ListSource(string fileName)
        {
            r = new Random();
            content = new List<string>(File.ReadAllLines(fileName));
            Shuffle();
        }


        // Called from the main program. Returns a random sample of the file's contents.
        public string[] GetRandomizedResults(int numberOfResults, bool allowRepeats)
        {
            Shuffle();
            return allowRepeats ? GetResults_WithRepeat(numberOfResults) : GetResults_WithoutRepeat(numberOfResults);
        }


        // Randomizes the order of the contents in the list
        private void Shuffle()
        {
            List<string> newContent = new List<string>();
            int randomIndex;
            while(content.Count > 0)
            {
                randomIndex = r.Next(content.Count);
                newContent.Add(content[randomIndex]);
                content.RemoveAt(randomIndex);
            }
            content = newContent;
        }


        // Gets a random sample from the list, allowing repeats of entries
        private string[] GetResults_WithRepeat(int numberOfResults)
        {
            string[] result = new string[numberOfResults];
            for(int i = 0; i < numberOfResults; i++)
                result[i] = content[r.Next(content.Count)];
            return result;
        }


        // Gets a random sample from the list, without repeating the same entry
        private string[] GetResults_WithoutRepeat(int numberOfResults)
        {
            string[] result;
            if (numberOfResults > content.Count)
                result = new string[content.Count];
            else
                result = new string[numberOfResults];
            int randomIndex, index = 0;

            if(numberOfResults <= content.Count)
            {
                // Populate the result array and remove from the content 
                while(index < result.Length && content.Count > 0)
                {
                    randomIndex = r.Next(content.Count);
                    result[index] = content[randomIndex];
                    content.RemoveAt(randomIndex);
                    index++;
                }

                // "Repair" the content list for the next call
                for(int i = 0; i < result.Length; i++)
                    content.Add(result[i]);

            }
            return result;
        }
    }
}
