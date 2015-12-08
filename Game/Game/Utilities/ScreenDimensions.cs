using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class ScreenScaler
    {
        private static Matrix spriteScale;

        public static void Update(GraphicsDeviceManager graphics)
        {
            float horizontalScale = (float)graphics.GraphicsDevice.Viewport.Width / ScreenConstants.DEFAULT_SCREEN_DIMENSIONS.X;
            float verticalScale = (float)graphics.GraphicsDevice.Viewport.Height / ScreenConstants.DEFAULT_SCREEN_DIMENSIONS.Y;
            spriteScale = Matrix.CreateScale(horizontalScale, verticalScale, 1);
        }

        public static Matrix ScalingMatrix { get { return spriteScale; } }
    }
}
