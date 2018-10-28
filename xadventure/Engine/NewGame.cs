/*
 * Handle starting a new game.
 * Stephen Fetinko
 * 2018
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class NewGame
    {
        private Game _game;
        private string _playerName;
        /// <summary>
        /// Constructor if we don't have a player name.
        /// </summary>
        public NewGame()
        {
            _game = new Game();
        }

        /// <summary>
        /// Constructor if we do have a player name.
        /// </summary>
        /// <param name="playerName">Player name entered.</param>
        public NewGame(string playerName)
        {
            _playerName = playerName;
        }
    }
}
