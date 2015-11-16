using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class IGameStateConstants
    {
        public const int UPDATEDELAY = 5;
        public const int POLESLIDEVELOCITY = 5;
        public const int ENDPOLESLIDECOORDINATE = 400;
        public const int FLAGPOLESTATETIMERJUMPMIN = 350;
        public const int FLAGPOLESTATETIMERJUMPMAX = 600;
        public const int FLAGPOLESTATEMARIOJUMPXVELOCITY = 4;
        public const int FLAGPOLESTATEMARIOJUMPYVELOCITY = 5;
        public const int FLAGPOLESTATEMARIOHASJUMPEDYCOORDINATE = 440;
        public const int FLAGPOLESTATEMARIOWALKINGTOWARDSCASTLEXVELOCITY = 5;
        public const int FLAGPOLESTATECASTLEDOORXCOORDINATE = 3248;
        public const int FLAGPOLESTATEVICTORYWAITTIMER = 5;
        public const String GAMEOVERSTATEMESSAGE = "Game Over";
        public static readonly Vector2 GAMEOVERSTATEMESSAGELOCATION = new Vector2(320, 200);
        public const String LOADINGGAMESTATEX = "x ";
        public static readonly Vector2 LOADINGGAMESTATEMESSAGELOCATION = new Vector2(400, 200);
        public static readonly Vector2 LOADINGGAMESTATEMARIOLOCATION = new Vector2(370, 215);
        public const int MARIODEATHSTATETIMER = 1500;
        public const int MARIOPOWERUPSTATETIMER = 10;
        public const int MENUGAMESTATELOGOCOUNTER = 300;
        public const int MENUGAMESTATELIVES = 2;
        public const String NORMALMARIOWORLD = "World1-1";
        public const int PIPETRANSITIONINGGAMESTATETIMER = 40;
        public const int PIPETRANSITIONINGGGAMESTATEMARIOXVELOCITY = 1;
        public const int PIPETRANSITIONINGGGAMESTATEMARIOYVELOCITY = 1;
        public const String VICTORYSCREENGAMESTATECONGRATSMESSAGE = "Congratulations, you won!";
        public const String VICTORYSCREENGAMESTATESTARTMESSAGE = "Press Start to restart the game.";
        public static readonly Vector2 VICTORYSCREENGAMESTATECONGRATSMESSAGELOCATION = new Vector2(200, 200);
        public static readonly Vector2 VICTORYSCREENGAMESTATESTARTMESSAGELOCATION = new Vector2(175, 250);
        
    }
}
