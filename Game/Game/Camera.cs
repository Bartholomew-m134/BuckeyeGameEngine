using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class Camera : ICamera
    {
        private Vector2 location;
        private Vector2 dimension = new Vector2(800,600);

        public Vector2 GetAdjustedPosition(Vector2 position)
        {
            return new Vector2(position.X - location.X, position.Y - location.Y);
        }

        public bool IsWithinBounds(Vector2 position)
        {
            return !(IsLeftOfCamera(position) || IsRightOfCamera(position) || IsAboveCamera(position) || IsBelowCamera(position));
        }

        public bool IsLeftOfCamera(Vector2 position)
        {
            return position.X < location.X;
        }

        public bool IsRightOfCamera(Vector2 position)
        {
            return position.X > location.X + dimension.X;
        }

        public bool IsAboveCamera(Vector2 position)
        {
            return position.Y < location.Y;
        }

        public bool IsBelowCamera(Vector2 position)
        {
            return position.Y > location.Y + dimension.Y;
        }

        public void AdjustCameraPosition(Vector2 adjustment)
        {
            location = Vector2.Add(location, adjustment);
        }
    }
}
