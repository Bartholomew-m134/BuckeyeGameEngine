using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class ProjectileSpriteConstants
    {
        public const int RESETTOZERO = 0;
        public const int UPDATEDELAY = 3;
        public static readonly Vector2 EXPLODINGFIRESOURCE = new Vector2(419,183);
        public static readonly Vector2 EXPLODINGFIREDIMENSIONS = new Vector2(16,16);
        public static readonly Vector2 FIRSTFIRESOURCE = new Vector2(41,150);
        public static readonly Vector2 SECONDFIRESOURCE = new Vector2(41,165);
        public static readonly Vector2 THIRDFIRESOURCE = new Vector2(26,150);
        public static readonly Vector2 FOURTHFIRESOURCE = new Vector2(26,165);
        public static readonly Vector2 FIREDIMENSIONS = new Vector2(8,8);
        public static readonly ArrayList FIRESOURCES = new ArrayList() { THIRDFIRESOURCE, SECONDFIRESOURCE, FIRSTFIRESOURCE, FOURTHFIRESOURCE };
    }
}
