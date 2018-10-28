/*
 * Handle initialization (starting new game/loading game based on parameters).
 * Stephen Fetinko
 * 2018
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Initialize
    {
        private NewGame _newGame;
        private LoadGame _loadGame;

        /// <summary>
        /// Function to load the game through the constructor.
        /// </summary>
        /// <param name="playerName">Player name to load (passed through args)</param>
        public Initialize(string playerName)
        {
            _loadGame = new LoadGame();
            if(_loadGame.CheckForSaveGame(playerName))
            {
                // Load the game
                _loadGame.Load();
            }
            else
            {
                // Start a new game with the entered name
                _newGame = new NewGame(playerName);
            }
        }

        /// <summary>
        /// Function to start a new game through the constructor.
        /// </summary>
        public Initialize()
        {
            _newGame = new NewGame();
        }
    }
}
