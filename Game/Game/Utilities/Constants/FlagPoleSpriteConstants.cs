using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class FlagPoleSpriteConstants
    {
        public const int UPDATEDELAY = 4;
        public const int RESETTOZERO = 0;
        public const int FLAGPOLEWIDTH = 25;
        public const int FLAGPOLEHEIGHT = 176;
        public const int NUMBEROFFRAMES = 5;
        public const int FLAGPOLEBARRIERWIDTH = 16;
        public const int FLAGPOLEBARRIERHEIGHT = 176;
        public static  readonly Vector2 FIRSTFLAGFRAMECOORDINATES = new Vector2(248,586);
        public static readonly Vector2 SECONDFLAGFRAMECOORDINATES = new Vector2(215, 586);
        public static readonly Vector2 THIRDFLAGFRAMECOORDINATES = new Vector2(181, 586);
        public static readonly Vector2 FOURTHFLAGFRAMECOORDINATES = new Vector2(148, 586);
        public static readonly Vector2 FIFTHFLAGFRAMECOORDINATES = new Vector2(115, 586);
        public static readonly Vector2 FLAGPOLEBARRIERCOORDINATES = new Vector2(300, 594);
    }
}
