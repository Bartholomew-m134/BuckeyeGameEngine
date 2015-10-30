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
        public static Vector2 MARIOHUDLOCATION = new Vector2(30,0);
        public static Vector2 SCOREHUDLOCATION = new Vector2(30, 25);
        public static Vector2 COINHUDLOCATION = new Vector2(210, 25);
        public static Vector2 COINSPRITEHUDLOCATION = new Vector2(190, 39);
        public static Vector2 WORLDHUDLOCATION = new Vector2(410, 0);
        public static Vector2 TIMESTRINGHUDLOCATION = new Vector2(610, 0);
        public static Vector2 TIMECOUNTERHUDLOCATION = new Vector2(610, 25);
        public static Vector2 WORLDNUMBERHUDLOCATION = new Vector2(435, 25);
        public static int NUMBEROFUPDATESPERSECOND = 15;
        public static int RESETUPDATEDELAYCOUNTER = 0;
        public static int INCREMENTBYONE = 1;
        public static int STARTINGTIME = 400;

    }
}
