/*
 * Initialize the game.
 * Stephen Fetinko
 * 2018
 */

using System;

namespace xadventure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Logic gameLogic = new Logic();
			// If args exist, check for a save. Else, new game
			if (args.Length > 0)
			{
				gameLogic.TryToLoadGame(args[0]);
			}
			else 
			{
				gameLogic.StartNewGame();
			}
        }
    }
}