using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class PacMarioSpriteConstants
    {
        public static readonly Vector2 MOUTH_OPEN_UP_SOURCE = new Vector2(35,3);
        public static readonly Vector2 MOUTH_CLOSED_UP_SOURCE = new Vector2(35,18);

        public static readonly Vector2 MOUTH_OPEN_DOWN_SOURCE = new Vector2(51,19);
        public static readonly Vector2 MOUTH_CLOSED_DOWN_SOURCE = new Vector2(51,3);

        public static readonly Vector2 MOUTH_OPEN_RIGHT_SOURCE = new Vector2(18,3);
        public static readonly Vector2 MOUTH_CLOSED_RIGHT_SOURCE = new Vector2(2,3);

        public static readonly Vector2 MOUTH_OPEN_LEFT_SOURCE = new Vector2(2,19);
        public static readonly Vector2 MOUTH_CLOSED_LEFT_SOURCE = new Vector2(17,19);

        public static readonly Vector2 VERTICAL_DIMENSIONS = new Vector2(14,14);
        public static readonly Vector2 HORIZONTAL_DIMENSIONS = new Vector2(14, 14);
    }
}
