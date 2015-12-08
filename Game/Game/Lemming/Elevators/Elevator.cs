using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SpriteFactories;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;

namespace Game.Lemming.Elevators
{
    public class Elevator : IGameObject
    {
        private Game1 myGame;
        private ISprite elevatorSprite;
        private Vector2 location;
        private IPhysics physics;
        private bool up;
        private float top;
        private float bottom;
        private float columnHeight;


        public Elevator(bool up, Game1 game)
        {
            this.up = up;
            myGame = game;
            elevatorSprite = LemmingSpriteFactory.CreateElevatorSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
            physics.Velocity = Vector2.Zero;
            columnHeight = (LemmingSpriteConstants.ELEVATORDIMENSIONS.Y - 1);

            
        }

        public void Update()
        {
            if (top == 0 && bottom == 0)
            {
                if (up)
                {
                    top = location.Y;
                    bottom = top + columnHeight;
                }
                else
                {
                    bottom = location.Y;
                    top = bottom - columnHeight;
                }
            }
            if (!up && location.Y < bottom)
            {
                physics.Velocity = new Vector2(0, LemmingObjectConstants.DOWNELEVATORVELOCITY);
            }
            
            else if (up && location.Y > top)
            {
                physics.Velocity = new Vector2(0, LemmingObjectConstants.UPELEVATORVELOCITY);
            }
            else
            {
                physics.Velocity = Vector2.Zero;

            }
            elevatorSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            elevatorSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Shift()
        {

            up = !up;
             

        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return elevatorSprite; }
            set { elevatorSprite = value; }
        }

        public IPhysics Physics
        {
            get { return physics; }
        }


    }
}
