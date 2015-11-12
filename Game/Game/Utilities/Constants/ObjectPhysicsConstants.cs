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
    }
}
