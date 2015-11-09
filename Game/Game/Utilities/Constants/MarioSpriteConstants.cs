using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class MarioSpriteConstants
    {
        public const int RESETTOZERO = 0;
        public const int STARDRAWBROWNCOUNTER = 6;
        public const int STARDRAWYELLOWGREENCOUNTER = 10;
        public const int STARDRAWORANGECOUNTER = 15;
        public const int FLAGUPDATEDELAYCOUNTER = 2;
        public const int RUNNINGUPDATEDELAY = 3;
        public static readonly Vector2 DEADMARIOSOURCECOORDINATES = new Vector2(390, 16);
        public static readonly Vector2 DEADMARIOWIDTHHIEGHT = new Vector2(14, 13);
        public static readonly Vector2 FIREFLAGMARIOWIDTHHEIGHT = new Vector2(14, 30);
        public static readonly Vector2 FIRSTFIREFLAGSOURCECOORDINATES = new Vector2(363, 158);
        public static readonly Vector2 SECONDFIREFLAGSOURCECOORDINATES = new Vector2(390, 159);
        public static readonly Vector2 FIRELEFTCROUCHINGWIDTHHEIGHT = new Vector2(16, 21);
        public static readonly Vector2 FIRELEFTCROUCHINGSOURCE = new Vector2(0, 127);
    }
}
