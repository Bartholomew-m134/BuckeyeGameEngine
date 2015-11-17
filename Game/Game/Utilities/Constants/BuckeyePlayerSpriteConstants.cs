using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Utilities.Constants
{
    public static class BuckeyePlayerSpriteConstants
    {
        public const int MOVEMENT_FRAME_DELAY = 2;
        public const int MOVEMENT_FRAME_MAX = 4;
        public const float SPRITE_SCALE_FACTOR = 0.5f;

        public static readonly Vector2 RIGHT_FRAME_1_SOURCE = new Vector2(5, 75);
        public static readonly Vector2 RIGHT_FRAME_1_DIMENSIONS = new Vector2(38, 64);

        public static readonly Vector2 RIGHT_FRAME_2_SOURCE = new Vector2(71, 81);
        public static readonly Vector2 RIGHT_FRAME_2_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 RIGHT_FRAME_3_SOURCE = new Vector2(136, 75);
        public static readonly Vector2 RIGHT_FRAME_3_DIMENSIONS = new Vector2(40, 64);

        public static readonly Vector2 RIGHT_FRAME_4_SOURCE = new Vector2(200, 81);
        public static readonly Vector2 RIGHT_FRAME_4_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 LEFT_FRAME_1_SOURCE = new Vector2(8, 11);
        public static readonly Vector2 LEFT_FRAME_1_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 LEFT_FRAME_2_SOURCE = new Vector2(70, 5);
        public static readonly Vector2 LEFT_FRAME_2_DIMENSIONS = new Vector2(40, 64);

        public static readonly Vector2 LEFT_FRAME_3_SOURCE = new Vector2(137, 11);
        public static readonly Vector2 LEFT_FRAME_3_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 LEFT_FRAME_4_SOURCE = new Vector2(203, 5);
        public static readonly Vector2 LEFT_FRAME_4_DIMENSIONS = new Vector2(38, 64);

        public static readonly Vector2 FALL_LOOKING_RIGHT_SOURCE = new Vector2(27, 179);
        public static readonly Vector2 FALL_LOOKING_RIGHT_DIMENSIONS = new Vector2(58, 38);

        public static readonly Vector2 FALL_LOOKING_LEFT_SOURCE = new Vector2(160, 179);
        public static readonly Vector2 FALL_LOOKING_LEFT_DIMENSIONS = new Vector2(58, 38);
    }
}
