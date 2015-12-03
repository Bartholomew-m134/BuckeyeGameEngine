using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Utilities.Constants
{
    public static class WolverineEnemyConstant
    {
        public const int MOVEMENT_FRAME_DELAY = 2;
        public const int MOVEMENT_FRAME_MAX = 4;
        public const float SPRITE_SCALE_FACTOR = 0.5f;

        public static readonly Vector2 RIGHT_FRAME_1_SOURCE = new Vector2(2, 75);
        public static readonly Vector2 RIGHT_FRAME_1_DIMENSIONS = new Vector2(38, 64);

        public static readonly Vector2 RIGHT_FRAME_2_SOURCE = new Vector2(68, 81);
        public static readonly Vector2 RIGHT_FRAME_2_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 RIGHT_FRAME_3_SOURCE = new Vector2(133, 75);
        public static readonly Vector2 RIGHT_FRAME_3_DIMENSIONS = new Vector2(40, 64);

        public static readonly Vector2 RIGHT_FRAME_4_SOURCE = new Vector2(197, 81);
        public static readonly Vector2 RIGHT_FRAME_4_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 LEFT_FRAME_1_SOURCE = new Vector2(4, 12);
        public static readonly Vector2 LEFT_FRAME_1_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 LEFT_FRAME_2_SOURCE = new Vector2(66, 6);
        public static readonly Vector2 LEFT_FRAME_2_DIMENSIONS = new Vector2(40, 64);

        public static readonly Vector2 LEFT_FRAME_3_SOURCE = new Vector2(133, 12);
        public static readonly Vector2 LEFT_FRAME_3_DIMENSIONS = new Vector2(38, 58);

        public static readonly Vector2 LEFT_FRAME_4_SOURCE = new Vector2(199, 6);
        public static readonly Vector2 LEFT_FRAME_4_DIMENSIONS = new Vector2(38, 64);

        public static readonly Vector2 FALL_LOOKING_RIGHT_SOURCE = new Vector2(45, 178);
        public static readonly Vector2 FALL_LOOKING_RIGHT_DIMENSIONS = new Vector2(58, 38);

        public static readonly Vector2 FALL_LOOKING_LEFT_SOURCE = new Vector2(129, 178);
        public static readonly Vector2 FALL_LOOKING_LEFT_DIMENSIONS = new Vector2(58, 38);

        public const int CHUCK_MOVEMENT_FRAME_MAX = 2;
        public const float CHUCK_SPRITE_SCALE_FACTOR = 1.8f;

        public static readonly Vector2 CHUCK_LEFT_FRAME_1_SOURCE = new Vector2(5, 6);
        public static readonly Vector2 CHUCK_LEFT_FRAME_1_DIMENSIONS = new Vector2(26, 27);

        public static readonly Vector2 CHUCK_LEFT_FRAME_2_SOURCE = new Vector2(45, 7);
        public static readonly Vector2 CHUCK_LEFT_FRAME_2_DIMENSIONS = new Vector2(26, 26);

        public static readonly Vector2 CHUCK_RIGHT_FRAME_1_SOURCE = new Vector2(44, 50);
        public static readonly Vector2 CHUCK_RIGHT_FRAME_1_DIMENSIONS = new Vector2(26, 26);

        public static readonly Vector2 CHUCK_RIGHT_FRAME_2_SOURCE = new Vector2(84, 49);
        public static readonly Vector2 CHUCK_RIGHT_FRAME_2_DIMENSIONS = new Vector2(26, 27);
    }
}
