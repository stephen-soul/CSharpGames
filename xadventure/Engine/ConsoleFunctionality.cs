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
        private string input;

        public ConsoleFunctionality()
        {
            input = "";
        }

        public string GetInput()
        {
            return input;
        }

        public void Write(string input)
        {
            Console.WriteLine(input);
        }

        public void Read() 
        {
            input = Console.ReadLine();
        }
    }
}