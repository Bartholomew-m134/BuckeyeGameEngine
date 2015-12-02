using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class HUDConstants
    {
        public const string MARIOHUDSTRING = "MARIO";
        public const string PACMARIOHUDSTRING = "PACMARIO";
        public const string WORLDHUDSTRING = "WORLD";
        public const string TIMEHUDSTRING = "TIME";
        public const string WORLDNUMBERHUDSTRING = "1-1";
        public const string XCOINCOUNTER = "x";
        public static readonly Vector2 LOGOLOCATION = new Vector2(-20,-20);
        public static readonly Vector2 MARIOHUDLOCATION = new Vector2(50, 20);
        public static readonly Vector2 SCOREHUDLOCATION = new Vector2(50, 45);
        public static readonly Vector2 COINHUDLOCATION = new Vector2(275, 45);
        public static readonly Vector2 COINSPRITEHUDLOCATION = new Vector2(255, 59);
        public static readonly Vector2 WORLDHUDLOCATION = new Vector2(440, 20);
        public static readonly Vector2 TIMESTRINGHUDLOCATION = new Vector2(675, 20);
        public static readonly Vector2 TIMECOUNTERHUDLOCATION = new Vector2(685, 45);
        public static readonly Vector2 WORLDNUMBERHUDLOCATION = new Vector2(473, 45);
        public const int NUMBEROFUPDATESPERSECOND = 7;
        public const int RESETUPDATEDELAYCOUNTER = 0;
        public const int INCREMENTBYONE = 1;
        public const int STARTINGTIME = 400;
        public const int COINSPERLIFE = 100;
        public const int ZEROREMAINDER = 0;
        public const int RESETTOZERO = 0;

    }
}
