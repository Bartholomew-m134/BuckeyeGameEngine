using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using Game.Interfaces;
using Game.Utilities;
using Game.Music;
using Game.Mario.MarioStates;
using Game.Utilities.Constants;

namespace Game.Mario
{
    public class StarMarioDecorator : IMario
    {
        private IMario mario;
        private Game1 myGame;
        private int timer = IMarioObjectConstants.STARMARIOINITIALTIMER;
        public static int stompKillStreak = 0;

        private FireBallSpawner factory;
        public StarMarioDecorator(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.myGame = game;
            WorldManager.SetMario(this);
            BackgroundThemeManager.PlayStarTheme();
            factory = new FireBallSpawner(game);
        }

        public void Damage()
        {
        }

        public void Update()
        {
            timer--;
            if (timer == 0 && IsOnFlagPole())
            {
                WorldManager.SetMario(this.mario);
            }
            else if (timer == 0)
            {
                WorldManager.SetMario(this.mario);
                BackgroundThemeManager.PlayOverWorldTheme();
            }
            mario.Update();
        }

        public void Draw(ICamera camera)
        {
            ((IMarioSprite)mario.Sprite).StarDraw(myGame.spriteBatch, camera.GetAdjustedPosition(mario.VectorCoordinates));
        }

        public void Left()
        {
            mario.Left();
        }

        public void Right()
        {
            mario.Right();
        }

        public void Up()
        {
            mario.Up();
        }

        public void Down()
        {
            mario.Down();
        }

        public void Jump()
        {
            mario.Jump();
        }

        public void StopJumping()
        {
            mario.StopJumping();
        }

        public void Run() 
        {
            mario.Run();
        }

        public void StopRunning() 
        {
            mario.StopJumping();
        }

        public void Flower()
        {
            if (!this.IsFireMario())
            {
                new FireMarioTransitionDecorator(this);
            }
        }

        public void ThrowFireball()
        {
            if (this.IsFireMario())
            {
                if (mario.MarioState.IsRight())
                {
                    factory.ReleaseRightFireBall(new Vector2(mario.VectorCoordinates.X + mario.Sprite.SpriteDimensions.X, mario.VectorCoordinates.Y));
                    new ThrowFireRightDecorator(this, myGame);
                }
                else
                {
                    factory.ReleaseLeftFireBall(mario.VectorCoordinates);
                    new ThrowFireLeftDecorator(this, myGame);
                }
            }
        }

        public void Mushroom()
        {
            if (!this.IsBigMario())
            {
                new GrowingMarioTransitionDecorator(this);
            }
        }

        public void Star()
        {
            timer = IMarioObjectConstants.STARMARIOINITIALTIMER;
        }

        public void PoleSlide()
        {
            mario.PoleSlide();
        }

        public Vector2 VectorCoordinates
        {
            get { return mario.VectorCoordinates; }
            set { mario.VectorCoordinates = value; }
        }

        public ISprite Sprite
        {
            get { return mario.Sprite; }
            set { mario.Sprite = (IMarioSprite)value; }
        }

        public IMarioState MarioState
        {
            get { return mario.MarioState; }
            set { mario.MarioState = value; }
        }
     
        public bool IsBigMario()
        {
            return mario.MarioState.IsBigMario();
        }

        public bool IsFireMario()
        {
            return mario.MarioState.IsFireMario();
        }

        public bool IsStarMario()
        {
            return true;
        }

        public bool IsJumping()
        {
            return mario.MarioState.IsJumping();
        }

        public void ToIdle()
        {
            mario.ToIdle();
        }

        public ObjectPhysics Physics
        {
            get { return ((MarioInstance)mario).Physics; }
        }


        public bool IsHurt()
        {
            return false;
        }

        private bool IsOnFlagPole(){
            return (mario.MarioState is FireFlagPoleSlidingState || mario.MarioState is NormalFlagPoleSlidingState || mario.MarioState is SmallFlagPoleSlidingState);
        }


        public bool IsPressingDown()
        {
            return mario.IsPressingDown();
        }
    }
}
