﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class ScoreManagerConstants
    {
        public static readonly int[] STOMPSEQUENCE = new int[11] { 100, 200, 400, 500, 800, 1000, 2000, 4000, 5000, 8000, AWARDONELIFE };
        public static readonly int[] SHELLSEQUENCE = new int[8] { 500, 800, 1000, 2000, 4000, 5000, 8000, AWARDONELIFE };
        public const int RESETTOZERO = 0;
        public const int UPDATEDELAY = 10;
        public const int INCREMENTBYONE = 1;
        public const int ZONEONEYCOORDINATE = 272;
        public const int ZONEONESCORE = 5000;
        public const int ZONETWOYCOORDINATE = 315;
        public const int ZONETWOSCORE = 2000;
        public const int ZONETHREEYCOORDINATE = 336;
        public const int ZONETHREESCORE = 800;
        public const int ZONEFOURYCOORDINATE = 368;
        public const int ZONEFOURSCORE = 400;
        public const int ZONEFIVEYCOORDINATE = 416;
        public const int ZONEFIVESCORE = 100;
        public const int ADDONECOIN = 1;
        public const int TWOHUNDREDPOINTS = 200;
        public const int ONEHUNDREDPOINTS = 100;
        public const int FIFTYPOINTS = 50;
        public const int ONETHOUSANDPOINTS = 1000;
        public const int AWARDONELIFE = -1;
        public const int STOMPSEQUENCEMAXINDEX = 10;
        public const int SHELLSEQUENCEMAXINDEX = 7;
        public const int MINIMUMSTREAKINDEX = 0;
        public const int POINTSPERREMAININGSECOND = 50;
    }
}
