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
        public const string WORLDHUDSTRING = "WORLD";
        public const string TIMEHUDSTRING = "TIME";
        public const string WORLDNUMBERHUDSTRING = "1-1";
        public const string XCOINCOUNTER = "x";
        public static readonly Vector2 LOGOLOCATION = new Vector2(-20,-20);
        public static readonly Vector2 MARIOHUDLOCATION = new Vector2(300, 20);
        public static readonly Vector2 SCOREHUDLOCATION = new Vector2(300, 45);
        public static readonly Vector2 COINHUDLOCATION = new Vector2(450, 45);
        public static readonly Vector2 COINSPRITEHUDLOCATION = new Vector2(430, 59);
        public static readonly Vector2 WORLDHUDLOCATION = new Vector2(540, 20);
        public static readonly Vector2 TIMESTRINGHUDLOCATION = new Vector2(700, 20);
        public static readonly Vector2 TIMECOUNTERHUDLOCATION = new Vector2(710, 45);
        public static readonly Vector2 WORLDNUMBERHUDLOCATION = new Vector2(573, 45);
        public const int NUMBEROFUPDATESPERSECOND = 3;
        public const int RESETUPDATEDELAYCOUNTER = 0;
        public const int INCREMENTBYONE = 1;
        public const int STARTINGTIME = 400;
        public const int COINSPERLIFE = 100;
        public const int ZEROREMAINDER = 0;

    }
}
