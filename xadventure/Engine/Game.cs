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

        private string _name; // Name to be given to the player class
        private string _role; // Role (class) to be given to the player class 

        private int gameState;

        private enum GAME_STATE
        {
            GAMESTATE_GETNAME,
            GAMESTATE_GETCLASS,
            GAMESTATE_MADECHAR,
            GAMESTATE_CONFIRMCHAR,
            GAMESTATE_INTRO,
            GAMESTATE_CHAPTER1
        }

        /// <summary>
        /// Constructor for new game.
        /// </summary>
        public Game()
        {
            _function = new ConsoleFunctionality();
            gameState = (int)GAME_STATE.GAMESTATE_GETNAME;
            _name = "";
            _role = "";
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
            _name = "";
            _role = "";
            Advance();
        }

        /// <summary>
        /// Takes the user input.
        /// </summary>
        private void TakeUserInput()
        {
            _function.Read(); // Read the user input through the console

            switch (gameState)
            {
                case (int)GAME_STATE.GAMESTATE_GETNAME:
                    _name = _function.GetInput().ToLower();
                    break;
                case (int)GAME_STATE.GAMESTATE_GETCLASS:
                    _role = _function.GetInput().ToLower();
                    break;
                case (int)GAME_STATE.GAMESTATE_CONFIRMCHAR:
                    switch (_function.GetInput().ToLower())
                    {
                        case "yes":
                        case "y":
                            gameState = (int)GAME_STATE.GAMESTATE_INTRO;
                            break;
                        case "no":
                        case "n":
                            gameState = (int)GAME_STATE.GAMESTATE_GETNAME;
                            break;
                        default:
                            _function.Write("Please try again.");
                            gameState = (int)GAME_STATE.GAMESTATE_MADECHAR;
                            break;
                    }
                    break;
                default:
                    break;
            }

            Advance();
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
                    gameState = (int)GAME_STATE.GAMESTATE_GETCLASS;
                    break;
                case (int)GAME_STATE.GAMESTATE_GETCLASS:
                    _function.Write("What's your class?");
                    gameState = (int)GAME_STATE.GAMESTATE_MADECHAR;
                    break;
                case (int)GAME_STATE.GAMESTATE_MADECHAR:
                    _function.Write("Confirm: (Y)es, (N)o");
                    gameState = (int)GAME_STATE.GAMESTATE_CONFIRMCHAR;
                    break;
                default:
                    break;
            }
            TakeUserInput();
        }
    }
}
