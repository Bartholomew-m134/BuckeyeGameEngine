using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario
{
    public class FireMario : IMario
    {
        private IMario mario;
        private Game1 myGame;
        private int frame;

        public FireMario(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.myGame = game;
            WorldManager.SetMario(this);
            frame = 0;
        }

        public void Damage()
        {
        }

        public void Update()
        {
            if (frame == 18)
            {
                WorldManager.SetMario(this.mario);
            }
            else if (frame % 2 == 0 && frame % 4 == 0)
            {
                mario.MarioState.Flower();
            }
            else if (frame % 2 == 0 && frame % 4 != 0)
            {
                mario.MarioState.Damage();
            }
            mario.Update();

            frame++;
            
        }

        public void Draw(ICamera camera)
        {
            mario.Draw(camera);
        }

        public void Left()
        {
            
        }

        public void Right()
        {
            
        }

        public void Up()
        {
            
        }

        public void Down()
        {
            
        }

        public void Jump()
        {
            
        }

        public void StopJumping()
        {
            mario.StopJumping();
        }

        public void Flower()
        {
            
        }

        public void Fire()
        {
            
        }

        public void Mushroom()
        {
            
        }

        public void Star()
        {
            
        }

        public void Die()
        {
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

        public bool isTransitioning()
        {
            return true;
        }

        public bool IsBig()
        {
            return mario.MarioState.IsBig();
        }

        public bool isFire()
        {
            return mario.MarioState.IsFire();
        }

        public bool IsStar()
        {
            return mario.IsStar();
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



        public void Run()
        {
            
        }

        public void StopRunning()
        {
            
        }


        public bool isHurt()
        {
            return false;
        }
    }
}
