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
    class Elevator : IGameObject
    {
        private Game1 myGame;
        private ISprite elevatorSprite;
        private Vector2 location;
        private IPhysics physics;
        private bool up;
        private int elevatorHeight;
        private int shiftPosition;


        public Elevator(bool up, Game1 game)
        {
            this.up = up;
            myGame = game;
            elevatorSprite = LemmingSpriteFactory.CreateElevatorSprite();
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
            physics.Velocity = Vector2.Zero;
            elevatorHeight = (int)LemmingSpriteConstants.ELEVATORDIMENSIONS.Y;
            if (up)
                shiftPosition = elevatorHeight;
            else
                shiftPosition = 0;
        }

        public void Update()
        {
            elevatorSprite.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            elevatorSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public void Shift()
        {
            if (up)
            {
                up = false;  
                while (!up & shiftPosition > 0)
                {
                    physics.Velocity = new Vector2(0, LemmingObjectConstants.DOWNELEVATORVELOCITY);
                    shiftPosition--;
                }
                physics.Velocity = Vector2.Zero;
            }
            else
            {
                up = true;  
                while (up & shiftPosition < elevatorHeight)
                {
                    physics.Velocity = new Vector2(0, LemmingObjectConstants.UPELEVATORVELOCITY);
                    shiftPosition++;
                }
                physics.Velocity = Vector2.Zero;
            }

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
