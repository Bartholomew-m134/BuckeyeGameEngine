using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class IGameStateConstants
    {
        public const int UPDATEDELAY = 3;
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
        public const String MINIGAMEVICTORYSCREENGAMESTATECONGRATSMESSAGE = "Congratulations, you won the mini game!";
        public const String MINIGAMEVICTORYSCREENGAMESTATESTARTMESSAGE = "Press Start to return to ProjectBuckeye.";
        public static readonly Vector2 VICTORYSCREENGAMESTATECONGRATSMESSAGELOCATION = new Vector2(200, 200);
        public static readonly Vector2 MINIGAMEVICTORYSCREENGAMESTATECONGRATSMESSAGELOCATION = new Vector2(125, 200);
        public static readonly Vector2 VICTORYSCREENGAMESTATESTARTMESSAGELOCATION = new Vector2(175, 250);
        public static readonly Vector2 MINIGAMEVICTORYSCREENGAMESTATESTARTMESSAGELOCATION = new Vector2(125, 250);

        public const String LEMMINGWORLD = "LemmingWorld";
        public const String PROJECT_BUCKEYE_TEST_WORLD = "ProjectBuckeyeTest";
        public const String PACMARIO_WORLD = "PacMarioWorld";
        public const String BRICKBREAKER_WORLD = "BrickBreakerWorld";
        public const int TOTALPACLEVELCOINS = 179;
        public const int PACMARIODEATHTIMER = 300;
        public const int TOTALBRICKBREAKERBLOCKS = 123;
        public const int INITIALBALLCOUNT = 3;
        
    }
}
