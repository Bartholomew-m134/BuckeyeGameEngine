using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public static class ScreenDimensions
    {
        private static Matrix spriteScale;

        public static void Update(GraphicsDeviceManager graphics)
        {
            // Default resolution is 800x600; scale sprites up or down based on
            // current viewport
            float horizontalScale = (float)graphics.GraphicsDevice.Viewport.Width / 800f;
            float verticalScale = (float)graphics.GraphicsDevice.Viewport.Height / 480f;
            // Create the scale transform for Draw. 
            // Do not scale the sprite depth (Z=1).
            spriteScale = Matrix.CreateScale(horizontalScale, verticalScale, 1);
        }

        public static Matrix ScalingMatrix { get { return spriteScale; } }
    }
}
