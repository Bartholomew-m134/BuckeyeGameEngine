using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities
{
    public class MarioCamera : ICamera
    {
        private readonly Vector2 DIMENSIONS = new Vector2(800, 480);
        private const float LEFT_UPDATE_ZONE_DIMENSIONS = 160;
        private const float RIGHT_UPDATE_ZONE_DIMENSIONS = 100;
        private const float UP_UPDATE_ZONE_DIMENSIONS = 100;
        private const float BOTTOM_UPDATE_ZONE_DIMENSIONS = 1600;

        private Vector2 cameraLocation;
        private Vector2 prevMarioLocation;

        public MarioCamera(Vector2 initialMarioLocation)
        {
            prevMarioLocation = initialMarioLocation;
        }

        public void Update(IGameObject obj) 
        {
            Vector2 objLocation = obj.VectorCoordinates;

            AdjustCameraPosition(objLocation);

            if (IsLeftOfCamera(objLocation))
                objLocation.X += cameraLocation.X - objLocation.X;

            obj.VectorCoordinates = objLocation;
        }

        public Vector2 GetAdjustedPosition(Vector2 position)
        {
            return new Vector2(position.X - cameraLocation.X, position.Y - cameraLocation.Y);
        }

        public bool IsWithinBounds(Vector2 position)
        {
            return !(IsLeftOfCamera(position) || IsRightOfCamera(position) || IsAboveCamera(position) || IsBelowCamera(position));
        }

        public bool IsWithinUpdateZone(Vector2 position)
        {
            float rightBound = cameraLocation.X + DIMENSIONS.X + RIGHT_UPDATE_ZONE_DIMENSIONS;
            float leftBound = cameraLocation.X - LEFT_UPDATE_ZONE_DIMENSIONS;

            float lowerBound = cameraLocation.Y + DIMENSIONS.Y + BOTTOM_UPDATE_ZONE_DIMENSIONS;

            return leftBound < position.X && position.X < rightBound && position.Y < lowerBound;
        }

        public bool IsWithinReleaseZone(Vector2 position)
        {
            return !IsWithinUpdateZone(position) && (IsLeftOfCamera(position) || IsBelowCamera(position));
        }

        public void MoveToPosition(Vector2 position)
        {
            cameraLocation = position;
        }

        public bool IsLeftOfCamera(Vector2 position)
        {
            return position.X < cameraLocation.X;
        }

        public bool IsRightOfCamera(Vector2 position)
        {
            return position.X > cameraLocation.X + DIMENSIONS.X;
        }

        public bool IsAboveCamera(Vector2 position)
        {
            return position.Y < cameraLocation.Y;
        }

        public bool IsBelowCamera(Vector2 position)
        {
            return position.Y > cameraLocation.Y + DIMENSIONS.Y;
        }

        private void AdjustCameraPosition(Vector2 marioLocation)
        {
            Vector2 difference = Vector2.Subtract(marioLocation, prevMarioLocation);

            if(Math.Abs(difference.Y) < DIMENSIONS.Y)
                difference.Y = 0;

            if (difference.X < 0)
                difference.X = 0;

            if (marioLocation.X > cameraLocation.X + DIMENSIONS.X / 2 || difference.Y != 0)
                cameraLocation = Vector2.Add(cameraLocation, difference);

            if (difference.Y < 0)
                cameraLocation.Y = 0;

            prevMarioLocation = marioLocation;
        }
    }
}
