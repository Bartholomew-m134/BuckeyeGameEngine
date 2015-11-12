using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;
using Game.SoundEffects;
using Game.Utilities.Constants;
using Game.ProjectBuckeye.PlayerClasses.BuckeyePlayerStates;

namespace Game.ProjectBuckeye.PlayerClasses
{
    public class BuckeyePlayer : IBuckeyePlayer
    {
        private IBuckeyePlayerState state;
        private ISprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private ObjectPhysics physics;

        public BuckeyePlayer(Game1 game)
        {
            state = new BuckeyeRightIdleState(this);
            myGame = game;
            physics = new ObjectPhysics();
        }

        public void Left()
        {
            
        }

        public void Right()
        {
            throw new NotImplementedException();
        }

        public void Up()
        {
            throw new NotImplementedException();
        }

        public void Down()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void StopJumping()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void StopRunning()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw(ICamera camera)
        {
            throw new NotImplementedException();
        }

        public Vector2 VectorCoordinates
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ISprite Sprite
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ObjectPhysics Physics
        {
            get { throw new NotImplementedException(); }
        }

        public IBuckeyePlayerState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
