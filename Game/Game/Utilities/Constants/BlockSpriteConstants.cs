using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class BlockSpriteConstants
    {
        public const int BRICKDEBRISTIMER = 75;
        public const int BRICKDEBRISADJUST = 8;
        public const int BRICKDEBRISUPDATEDELAY = 5;
        public static readonly Vector2 GENERICBLOCKDIMENSIONS = new Vector2(16, 16);
        public static readonly Vector2 BRICKDEBRISBLOCKDIMENSIONS = new Vector2(7,8);
        public static readonly Vector2 BRICKDEBRISBLOCKSOURCE = new Vector2(305,112);
        public static readonly Vector2 BREAKINGBLOCKSOURCE = new Vector2(0,0);
        public static readonly Vector2 BRICKBLOCKSOURCE = new Vector2(16, 0);
        public static readonly Vector2 HIDDENBLOCKSOURCE = new Vector2(224,16);
        public static readonly Vector2 QUESTIONBLOCKSOURCE = new Vector2(368,0);
        public static readonly Vector2 SOLIDBLOCKSOURCE = new Vector2(0,16);
        public static readonly Vector2 USEDBLOCKSOURCE = new Vector2(48,0);
        public static readonly Vector2 UNDERGROUNDBREAKINGBLOCKSOURCE = new Vector2(0, 32);
        public static readonly Vector2 UNDERGROUNDBRICKBLOCKSOURCE = new Vector2(32, 32);
        public static readonly Vector2 BRICKBLOCKUPADJUSTMENT = new Vector2(1,6);
        public static readonly Vector2 BRICKBLOCKDOWNADJUSTMENT = new Vector2(1, -6);
    }
}
