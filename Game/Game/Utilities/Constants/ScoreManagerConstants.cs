using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class ScoreManagerConstants
    {
        public static int[] STOMPSEQUENCE = new int[11]{100, 200, 400, 500, 800, 1000, 2000, 4000, 5000, 8000, 0};
        public static int[] SHELLSEQUENCE = new int[8]{500, 800, 1000, 2000, 4000, 5000, 8000, 0};
        public static int RESETTOZERO =  0;
        public static int UPDATEDELAY = 10;
        public static int INCREMENTBYONE = 1;
        public static int ZONEONEYCOORDINATE = 272;
        public static int ZONEONESCORE = 5000;
        public static int ZONETWOYCOORDINATE = 315;
        public static int ZONETWOSCORE = 2000;
        public static int ZONETHREEYCOORDINATE = 336;
        public static int ZONETHREESCORE = 800;
        public static int ZONEFOURYCOORDINATE = 368;
        public static int ZONEFOURSCORE = 400;
        public static int ZONEFIVEYCOORDINATE = 416;
        public static int ZONEFIVESCORE = 100;
    }
}
