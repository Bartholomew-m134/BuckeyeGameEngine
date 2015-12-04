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
using Game.ProjectBuckeye.FootballClasses;
using Game.GameStates;

namespace Game.ProjectBuckeye.PlayerClasses
{
    public class BuckeyePlayer : IBuckeyePlayer
    {
        private IBuckeyePlayerState state;
        private ISprite sprite;
        private Vector2 location;
        private Game1 myGame;
        private IPhysics physics;
        private bool isDead;
        private bool isPressingDown;
        private bool isFacingRight;
        private FootballSpawner spawner;

        public BuckeyePlayer(Game1 game)
        {
            state = new BuckeyeRightIdleState(this);
            myGame = game;
            physics = new MarioGamePhysics();
            isPressingDown = false;
            isDead = false;
            spawner = new FootballSpawner(game);
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
            state.Up();
            this.isPressingDown = false;
        }

        public void Down()
        {
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

        public IPhysics Physics
        {
            get { return physics; }
        }

        public IBuckeyePlayerState State
        {
            get { return state; }
            set { state = value; }
        }


        public bool IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }


        public bool IsPressingDown()
        {
            return isPressingDown;
        }

        public bool IsJumping()
        {
            return state.IsJumping();
        }

        public void ToIdle()
        {
            state.ToIdle();
        }


        public void Damage()
        {
            state.DownPlayer();
            myGame.gameState = new MenuGameState(myGame);
            myGame.gameState.LoadContent();
        }


        public bool IsFacingRight
        {
            get { return isFacingRight; }
            set { isFacingRight = value;}
        }


        public void Throw()
        {
            spawner.ReleaseFootball(location, isFacingRight, false);
        }
    }
}
