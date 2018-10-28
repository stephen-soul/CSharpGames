/*
 * Handle game logic.
 * Stephen Fetinko
 * 2018
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Game
    {
        private ConsoleFunctionality _function;
        private enum GAME_STATE
        {
            GAMESTATE_GETNAME,
            GAMESTATE_INTRO,
            GAMESTATE_CHAPTER1
        }

        private int gameState;

        /// <summary>
        /// Constructor for new game.
        /// </summary>
        public Game()
        {
            _function = new ConsoleFunctionality();
            gameState = (int)GAME_STATE.GAMESTATE_GETNAME;
            Advance();
        }

        /// <summary>
        /// Constructor for loaded game.
        /// </summary>
        /// <param name="gamestate">Current game state as an int</param>
        public Game(int gamestate)
        {
            _function = new ConsoleFunctionality();
            gameState = gamestate;
            Advance();
        }

        /// <summary>
        /// Takes the user input.
        /// </summary>
        private void TakeUserInput()
        {
            _function.Write(_function.GetInput());
        }

        /// <summary>
        /// Function to advance the game based on the game state.
        /// </summary>
        private void Advance()
        {
            switch (gameState)
            {
                case (int)GAME_STATE.GAMESTATE_GETNAME:
                    _function.Write("What's your name?");
                    _function.Read();
                    break;
                default:
                    break;
            }
            TakeUserInput();
        }
    }
}
