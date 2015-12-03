using Game.Interfaces;
using Game.ProjectMarioBrickBreaker.PaddleBallClasses.PaddleBallStates;
using Game.Utilities;
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
        

        public PaddleBall(Game1 game)
        {
            
            myGame = game;
            paddleBallState = new NormalPaddleBallState(this);
            physics = new MarioGamePhysics();
            physics.Acceleration = Vector2.Zero;
           
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


        public void ToSuperPaddleBall()
        {
            paddleBallState.ToSuperPaddleBall();
        }

        public bool IsSuperPaddleBall()
        {
            return paddleBallState.IsSuperPaddleBall();
        }
    }
}
