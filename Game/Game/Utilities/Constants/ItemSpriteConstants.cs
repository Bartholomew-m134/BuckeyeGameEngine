using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class ItemSpriteConstants
    {
        public const int TOTALCOINFRAMES = 4;
        public const int TOTALFLOWERFRAMES = 4;
        public const int TOTALSTARFRAMES = 4;
        public const int RESETTOZERO = 0;
        public const int DISTANCEBETWEENCOINSPRITES = 30;
        public const int DISTANCEBETWEENFLOWERSPRITES = 30;
        public const int DISTANCEBETWEENSTARSPRITES = 30;
        public static readonly Vector2 COINSOURCE = new Vector2(127,94);
        public static readonly Vector2 COINDIMENSIONS = new Vector2(9,15);
        public static readonly Vector2 FLOWERSOURCE = new Vector2(3,63);
        public static readonly Vector2 FLOWERDIMENSIONS = new Vector2(17,17);
        public static readonly Vector2 GREENMUSHSOURCE = new Vector2(213,33);
        public static readonly Vector2 GREENMUSHDIMENSIONS = new Vector2(17, 17);
        public static readonly Vector2 REDMUSHSOURCE = new Vector2(183, 33);
        public static readonly Vector2 REDMUSHDIMENSIONS = new Vector2(17, 17);
        public static readonly Vector2 STARSOURCE = new Vector2(3,93);
        public static readonly Vector2 STARDIMENSIONS = new Vector2(17, 17);
    }
}
