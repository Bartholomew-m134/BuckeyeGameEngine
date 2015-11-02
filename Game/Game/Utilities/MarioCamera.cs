using Game.Interfaces;
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
        private readonly Vector2 UPDATE_ZONE_FACTORS = new Vector2(0.2f, 0.1f);

        private Vector2 cameraLocation;
        private Vector2 prevObjLocation;

        public MarioCamera(Vector2 initialObjLocation)
        {
            prevObjLocation = initialObjLocation;
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
            float rightBound = cameraLocation.X + DIMENSIONS.X + (int)(DIMENSIONS.X * UPDATE_ZONE_FACTORS.X);
            float leftBound = cameraLocation.X - (int)(DIMENSIONS.X * UPDATE_ZONE_FACTORS.X);

            float lowerBound = cameraLocation.Y + DIMENSIONS.Y + (int)(DIMENSIONS.Y * UPDATE_ZONE_FACTORS.Y);
            float upperBound = cameraLocation.Y - (int)(DIMENSIONS.Y * UPDATE_ZONE_FACTORS.Y);

            return leftBound < position.X && position.X < rightBound && upperBound < position.Y && position.Y < lowerBound;
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

        private void AdjustCameraPosition(Vector2 objLocation)
        {
            Vector2 difference = Vector2.Subtract(objLocation, prevObjLocation);

            difference.Y = 0;

            if (difference.X < 0)
                difference.X = 0;

            if (objLocation.X > cameraLocation.X + DIMENSIONS.X / 2)
                cameraLocation = Vector2.Add(cameraLocation, difference);

            prevObjLocation = objLocation;
        }
    }
}
