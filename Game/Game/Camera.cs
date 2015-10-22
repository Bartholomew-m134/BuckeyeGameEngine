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
        private Vector2 dimension;
        private Vector2 prevPlayerLocation;
        private bool leftScrollingDisabled;

        public Camera()
        {
            dimension = new Vector2(800,480);
            leftScrollingDisabled = true;
        }

        public Camera(Vector2 dimension)
        {
            this.dimension = dimension;
            leftScrollingDisabled = true;
        }

        public Vector2 GetAdjustedPosition(Vector2 position)
        {
            return new Vector2(position.X - location.X + dimension.X/2, position.Y);
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

        public void AdjustCameraPosition(Vector2 position)
        {
            Vector2 difference = Vector2.Subtract(position, prevPlayerLocation);

            /*if(leftScrollingDisabled)
            {
                if (difference.X < 0)
                    difference.X = 0;

                if (position.X > location.X + dimension.X / 2)
                    location = Vector2.Add(location, difference);
            }*/
            
                location = Vector2.Add(location, difference);
            
            

            prevPlayerLocation = position;
        }

        public bool LeftScrollingDisabled
        {
            get {return leftScrollingDisabled;}
            set {leftScrollingDisabled = value;}
        }
    }
}
