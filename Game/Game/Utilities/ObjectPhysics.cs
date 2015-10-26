using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Utilities
{
    public class ObjectPhysics
    {
        private Vector2 velocity;
        private Vector2 acceleration;
        private Vector2 velocityMaximum = new Vector2(10, 12);
        private Vector2 velocityMinimum = new Vector2(-10, -12);
        private Vector2 oldCoordinates;
        private int gravity = 1;
        public ObjectPhysics()
        {
            oldCoordinates = new Vector2(0, 0);
            velocity = new Vector2(0, 0);
            acceleration = new Vector2(0, gravity);
        }
        
        public Vector2 Update(Vector2 coordinates)
        {
            Vector2 oldVelocity = velocity;
            
            velocity += acceleration;

            if (velocity.X > velocityMaximum.X) {
                velocity.X = velocityMaximum.X;
            }
            else if (velocity.X < velocityMinimum.X) {
                velocity.X = velocityMinimum.X;
            }

            if (velocity.Y > velocityMaximum.Y)
            {
                velocity.Y = velocityMaximum.Y;
            }
            else if (velocity.Y < velocityMinimum.Y)
            {
                velocity.Y = velocityMinimum.Y;
            }

            return (coordinates + (oldVelocity + velocity) / 2);
           
        }

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public Vector2 Acceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }

        public Vector2 OldCoordinates { get { return oldCoordinates; } }

        public void ResetY() {
            acceleration.Y = gravity;
            velocity.Y = 0;
        }

        public void ResetX()
        {
            acceleration.X = 0;
            velocity.X = 0;
        }

        public void ResetPhysics()
        {
            ResetX();
            ResetY();
        }

        public void DampenRight() {
            acceleration.X = 0;
            velocity.X -= 2;
        }

        public void DampenLeft()
        {
            acceleration.X = 0;
            velocity.X += 2;
        }
    }
}
