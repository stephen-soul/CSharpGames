/*
 * Handle file IO.
 * Stephen Fetinko
 * 2018
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace Engine
{
    public class Text
    {
        // List of errors
        private List<string> errorList = new List<string>();

        // Define the files
        private readonly string errors = "errors"; // File containing error messages

        /// <summary>
        /// Constructor for text
        /// </summary>
        public Text()
        {
            Initialize();
        }

        private void Initialize()
        {
            ReadText(errors);
        }

        /// <summary>
        /// Reads the required text from the file io.
        /// </summary>
        /// <param name="fileName">Requested file to read from.</param>
        private void ReadText(string fileName)
        {
            try
            {
                TextReader tr;
                string fileToOpen = fileName + ".txt";
                var path = Path.Combine(Directory.GetCurrentDirectory(), fileToOpen);
                tr = File.OpenText(path);

                string line = tr.ReadLine();
                string lineToCopy = "";

                do
                {
                    string[] textSplit = line.Split('\n');
                    foreach (string part in textSplit)
                    {
                        if (!part.Contains("#"))
                        {
                            lineToCopy += part;
                        }
                        if (part.Equals(""))
                        {
                            lineToCopy += "\n";
                        }
                        if (part.Contains("@"))
                        {
                            lineToCopy = lineToCopy.Substring(0, lineToCopy.Length - 1);
                            errorList.Add(lineToCopy);
                            lineToCopy = "";
                        }
                    }
                }
                while ((line = tr.ReadLine()) != null);
                tr.Close();
            }
            catch (IOException e)
            {
                e.ToString();
            }
        }

        /// <summary>
        /// Gets the error requested at a specific spot.
        /// </summary>
        /// <returns>The error.</returns>
        /// <param name="specifiedError">Specific error to get from dictionary.</param>
        public string GetError(int specifiedError)
        {
            return errorList[specifiedError];
        }
    }
}
