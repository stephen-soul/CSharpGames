/*
 * Initialize the game.
 * Stephen Fetinko
 * 2018
 */

using System;
using Engine;

namespace xadventure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// If args exist, check for a save. Else, new game
			if (args.Length > 0)
			{
                Initialize _initialize = new Initialize(args[0]);
            }
			else 
			{
                Initialize _initialize = new Initialize();
            }
            Console.ReadLine();
        }
    }
}