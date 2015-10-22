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
        public ObjectPhysics()
        {
            velocity = new Vector2(0, 0);
            acceleration = new Vector2(0, 0);
        }

        public Vector2 Update(Vector2 coordinates)
        {
            Vector2 oldVelocity = velocity;

            velocity += acceleration;

            return (coordinates + (oldVelocity + velocity) / 2);
           
        }

        public Vector2 GetSetVelocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public Vector2 GetSetAcceleration
        {
            get { return acceleration; }
            set { acceleration = value; }
        }

    }
}
