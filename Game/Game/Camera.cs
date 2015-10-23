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
        private Vector2 cameraLocation;
        private Vector2 dimension;
        private Vector2 prevPlayerLocation;
        private bool leftScrollingDisabled;
        private bool verticalScrollingDisabled;

        public Camera(Vector2 initialPlayerLocation)
        {
            dimension = new Vector2(800,480);
            leftScrollingDisabled = true;
            verticalScrollingDisabled = true;
            prevPlayerLocation = initialPlayerLocation;
        }

        public void Update(IGameObject player)
        {
            Vector2 playerLocation = player.VectorCoordinates;

            AdjustCameraPosition(playerLocation);

            if (IsLeftOfCamera(playerLocation))
                playerLocation.X += cameraLocation.X - playerLocation.X;
            
            player.VectorCoordinates = playerLocation;
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
            float rightBound = cameraLocation.X + dimension.X * 2;
            float leftBound = cameraLocation.X - dimension.X * 2;

            return leftBound < position.X && position.X < rightBound;
        }

        public bool IsLeftOfCamera(Vector2 position)
        {
            return position.X < cameraLocation.X;
        }

        public bool IsRightOfCamera(Vector2 position)
        {
            return position.X > cameraLocation.X + dimension.X;
        }

        public bool IsAboveCamera(Vector2 position)
        {
            return position.Y < cameraLocation.Y;
        }

        public bool IsBelowCamera(Vector2 position)
        {
            return position.Y > cameraLocation.Y + dimension.Y;
        }

        public bool LeftScrollingDisabled
        {
            get {return leftScrollingDisabled;}
            set {leftScrollingDisabled = value;}
        }

        public bool VerticalScrollingDisabled
        {
            get { return verticalScrollingDisabled; }
            set { verticalScrollingDisabled = value; }
        }

        private void AdjustCameraPosition(Vector2 playerLocation)
        {
            Vector2 difference = Vector2.Subtract(playerLocation, prevPlayerLocation);

            if (verticalScrollingDisabled)
                difference.Y = 0;

            if (leftScrollingDisabled)
            {
                if (difference.X < 0)
                    difference.X = 0;

                if (playerLocation.X > cameraLocation.X + dimension.X / 2)
                    cameraLocation = Vector2.Add(cameraLocation, difference);
            }
            else
            {
                cameraLocation = Vector2.Add(cameraLocation, difference);
            }

            prevPlayerLocation = playerLocation;
        }
    }
}
