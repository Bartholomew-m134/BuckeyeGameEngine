using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class HUDConstants
    {
        public static string MARIOHUDSTRING = "MARIO";
        public static string WORLDHUDSTRING = "WORLD";
        public static string TIMEHUDSTRING = "TIME";
        public static string WORLDNUMBERHUDSTRING = "1-1";
        public static string XCOINCOUNTER = "x";
        public static Vector2 LOGOLOCATION = new Vector2(-20,-20);
        public static Vector2 MARIOHUDLOCATION = new Vector2(300,20);
        public static Vector2 SCOREHUDLOCATION = new Vector2(300, 45);
        public static Vector2 COINHUDLOCATION = new Vector2(450, 45);
        public static Vector2 COINSPRITEHUDLOCATION = new Vector2(430, 59);
        public static Vector2 WORLDHUDLOCATION = new Vector2(540, 20);
        public static Vector2 TIMESTRINGHUDLOCATION = new Vector2(700, 20);
        public static Vector2 TIMECOUNTERHUDLOCATION = new Vector2(710, 45);
        public static Vector2 WORLDNUMBERHUDLOCATION = new Vector2(573, 45);
        public static int NUMBEROFUPDATESPERSECOND = 15;
        public static int RESETUPDATEDELAYCOUNTER = 0;
        public static int INCREMENTBYONE = 1;
        public static int STARTINGTIME = 400;

    }
}
