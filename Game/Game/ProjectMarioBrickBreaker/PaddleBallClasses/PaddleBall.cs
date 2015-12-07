using Game.Interfaces;
using Game.ProjectMarioBrickBreaker.PaddleBallClasses.PaddleBallStates;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.BallClasses
{
    public class PaddleBall : IPaddleBall
    {

        private Game1 myGame;
        private ISprite paddleBallSprite;
        private Vector2 location;
        private IPaddleBallState paddleBallState;
        private IPhysics physics;
        private bool isReleased;
        

        public PaddleBall(Game1 game)
        {
            
            myGame = game;
            isReleased = false;
            paddleBallState = new NormalPaddleBallState(this);
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
            physics.VelocityMaximum = ObjectPhysicsConstants.PADDLEBALLINITIALMAXVELOCITY;
            physics.VelocityMinimum = ObjectPhysicsConstants.PADDLEBALLINITIALMINVELOCITY;
           
        }

        public void Update()
        {
            paddleBallState.Update();
            location = physics.Update(location);
        }

        public void Draw(ICamera camera)
        {
            paddleBallSprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return paddleBallSprite; }
            set { paddleBallSprite = value; }
        }

        public IPhysics Physics
        {
            get { return physics; }
        }

        public IPaddleBallState PaddleBallState
        {
            get { return paddleBallState; }
            set { paddleBallState = value; }
        }

        public void ReleasePaddleBall() 
        {
            physics.Velocity = new Vector2(0, ObjectPhysicsConstants.PADDLEBALLINITIALMINVELOCITY.Y);
            isReleased = true;
        }


        public void ToSuperPaddleBall()
        {
            paddleBallState.ToSuperPaddleBall();
        }

        public void ToFastPaddleBall() 
        {
            physics.VelocityMaximum = ObjectPhysicsConstants.PADDLEBALLFASTMAXVELOCITY;
            physics.VelocityMinimum = ObjectPhysicsConstants.PADDLEBALLFASTMINVELOCITY;

            if (physics.Velocity.X > 0 && physics.Velocity.Y > 0)
                physics.Velocity = ObjectPhysicsConstants.PADDLEBALLFASTMAXVELOCITY;
            else if (physics.Velocity.X < 0 && physics.Velocity.Y < 0)
                physics.Velocity = ObjectPhysicsConstants.PADDLEBALLFASTMINVELOCITY;
            else if (physics.Velocity.X > 0 && physics.Velocity.Y < 0)
                physics.Velocity = new Vector2(ObjectPhysicsConstants.PADDLEBALLFASTMAXVELOCITY.X, ObjectPhysicsConstants.PADDLEBALLFASTMINVELOCITY.Y);
            else if (physics.Velocity.X < 0 && physics.Velocity.Y > 0)
                physics.Velocity = new Vector2(ObjectPhysicsConstants.PADDLEBALLFASTMINVELOCITY.X, ObjectPhysicsConstants.PADDLEBALLFASTMAXVELOCITY.Y);
            else if (physics.Velocity.X == 0 && physics.Velocity.Y < 0)
                physics.Velocity = new Vector2(0, ObjectPhysicsConstants.PADDLEBALLFASTMINVELOCITY.Y);
            else
                physics.Velocity = new Vector2(0, ObjectPhysicsConstants.PADDLEBALLFASTMAXVELOCITY.Y);
        


        }

        public bool IsSuperPaddleBall()
        {
            return paddleBallState.IsSuperPaddleBall();
        }







        public bool IsReleased
        {
            get
            {
                return isReleased;
            }
            
        }
    }
}
