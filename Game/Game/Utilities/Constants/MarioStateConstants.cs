using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.Utilities.Constants
{
    public static class MarioStateConstants
    {
        public const int WALKINGVELOCITYMAX = 6;
        public const int WALKINGVELOCITYMIN = -6;
        public const int RUNNINGVELOCITYMAX = 10;
        public const int RUNNINGVELOCITYMIN = -10;

        public const int DEADMARIOYVELOCITY = -9;

        public const int SMALLORCROUCHINGOFFSET = 16;
        public const int POWERUPOFFSET = -16;
        public const int STANDUPOFFSET = -10;

        public const int INITIALJUMPVELOCITY = -12;

        public const int NEGATIVEJUMPINGXACCELERATION = -1;
        public const int POSITIVEJUMPINGXACCELERATION = 1;

        public const int NEGATIVERUNNINGXACCELERATION = -2;
        public const int POSITIVERUNNINGXACCELERATION = 2;
    }
}
