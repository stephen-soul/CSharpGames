/*
 * Handle all enums for different states.
 * Stephen Fetinko
 * 2018
 */

using System;
namespace Engine
{
    public class States
    {
        public enum GAME_STATE
        {
            GAMESTATE_GETNAME,
            GAMESTATE_GETCLASS,
            GAMESTATE_MADECHAR,
            GAMESTATE_CONFIRMCHAR,
            GAMESTATE_INTRO,
            GAMESTATE_CHAPTER1
        }

        public enum ERROR_CODES
        {
            ERROR_INVALIDTEXT
        }
    }
}
