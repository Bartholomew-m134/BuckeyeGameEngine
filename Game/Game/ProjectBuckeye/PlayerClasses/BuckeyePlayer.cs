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
            state.Left();
        }

        public void Right()
        {
            state.Right();
        }

        public void Up()
        {
        }

        public void Down()
        {
            state.Down();
        }

        public void Jump()
        {
            state.Jump();
        }

        public void StopJumping()
        {
            state.StopJumping();
        }

        public void Run()
        {
            state.Run();
        }

        public void StopRunning()
        {
            state.StopRunning();
        }

        public void Update()
        {
            location = physics.Update(location);
            state.Update();  
        }

        public void Draw(ICamera camera)
        {
            sprite.Draw(myGame.spriteBatch, camera.GetAdjustedPosition(location));
        }

        public Vector2 VectorCoordinates
        {
            get { return location; }
            set { location = value; }
        }

        public ISprite Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public ObjectPhysics Physics
        {
            get { return physics; }
        }

        public IBuckeyePlayerState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
