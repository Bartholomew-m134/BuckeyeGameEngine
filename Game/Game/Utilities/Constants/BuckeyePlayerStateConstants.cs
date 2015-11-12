using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Constants
{
    public static class BuckeyePlayerStateConstants
    {
        public const int WALKING_VELOCITY_MAX = 6;
        public const int WALKING_VELOCITY_MIN = -6;
        public const int RUNNING_VELOCITY_MAX = 10;
        public const int RUNNING_VELOCITY_MIN = -10;

        public const int INITIAL_JUMP_VELOCITY = -12;

        public const int NEGATIVE_JUMPING_X_ACCELERATION = -1;
        public const int POSITIVE_JUMPING_X_ACCELERATION = 1;

        public const int NEGATIVE_RUNNING_X_ACCELERATION = -2;
        public const int POSITIVE_RUNNING_X_ACCELERATION = 2;
    }
}
