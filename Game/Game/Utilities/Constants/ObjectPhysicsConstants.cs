using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class ObjectPhysicsConstants
    {
        public const int GRAVITY = 1;

        public const int INITIALXMAXVELOCITY = 6;
        public const int INTIALYMAXVELOCITY = 12;

        public const int INITIALXMINVELOCITY = -6;
        public const int INITIALYMINVELOCITY = -12;

        public const int RIGHTDAMPENTHRESHOLD = 2;
        public const int LEFTDAMPENTHRESHOLD = -2;

        public const int PACMARIOINITIALXMAXVELOCITY = 6;
        public const int PACMARIOINTIALYMAXVELOCITY = 6;

        public const int PACMARIOINITIALXMINVELOCITY = -6;
        public const int PACMARIOINITIALYMINVELOCITY = -6;

        public static readonly Vector2 PADDLEBALLINITIALMAXVELOCITY = new Vector2(8, 8);
        public static readonly Vector2 PADDLEBALLINITIALMINVELOCITY = new Vector2(-8, -8);
        public static readonly Vector2 PADDLEBALLFASTMAXVELOCITY = new Vector2(15, 15);
        public static readonly Vector2 PADDLEBALLFASTMINVELOCITY = new Vector2(-15, -15);
        

    }
}
