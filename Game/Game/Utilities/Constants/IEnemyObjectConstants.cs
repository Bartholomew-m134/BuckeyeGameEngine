using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class IEnemyObjectConstants
    {
        public const int HIDINGINSHELLMAXTIME = 100;
        public const int EMERGINGFROMSHELLMAXTIME = 45;
        public const int KOOPAMAXVELOCITY = 12;
        public const int KOOPAMINVELOCITY = -12;

        public const int STOMPEDGOOMBADELAYTIME = 3;
        public const int VANISH = 2000;
        public const int BOO_LOCATION_LENGTH = 3;
        public static readonly Vector2 TELEPORTLEFTLOCATION = new Vector2(272,240);
        public static readonly Vector2 TELEPORTRIGHTLOCATION = new Vector2(560,240);
        public static readonly List<Vector2> BOO_START_LOCATIONS = new List<Vector2> { new Vector2(416, 240),
            new Vector2(448, 208), new Vector2(432, 144), new Vector2(400, 144) };
    }
}
