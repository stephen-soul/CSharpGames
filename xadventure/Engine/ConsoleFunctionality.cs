/*
 * Handle console functionality.
 * Stephen Fetinko
 * 2018
 */

using System;

namespace Engine
{
    public class ConsoleFunctionality
    {
        private string input; // User input

        /// <summary>
        /// Initializes a new instance of console functionality.
        /// </summary>
        public ConsoleFunctionality()
        {
            input = ""; // On initialize, empty the input
        }

        /// <summary>
        /// Gets the input.
        /// </summary>
        /// <returns>The input.</returns>
        public string GetInput()
        {
            return input;
        }

        /// <summary>
        /// Write the specified input.
        /// </summary>
        /// <param name="input">Input from user</param>
        public void Write(string input)
        {
            Console.WriteLine(input);
        }

        /// <summary>
        /// Read the input to the console.
        /// </summary>
        public void Read() 
        {
            input = Console.ReadLine();
        }
    }
}