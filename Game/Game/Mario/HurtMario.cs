using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Mario
{
    public class HurtMario : IMario
    {
         private IMario mario;
        private int frame;

        public HurtMario(IMario mario)
        {
            this.mario = mario;
            WorldManager.SetMario(this);
            frame = 0;
        }

        public void Damage()
        {
        }

        public void Update()
        {
            if (frame == 35)
            {
                WorldManager.SetMario(this.mario);
            }
            mario.Update();

            frame++;
            
        }

        public void Draw(ICamera camera)
        {
            if (frame % 2 == 0 && frame % 4 == 0)
                mario.Draw(camera);
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

        public void Flower()
        {
            mario.Flower();
        }

        public void ThrowFireball()
        {
            mario.ThrowFireball();
        }

        public void Mushroom()
        {
            mario.Mushroom();
        }

        public void Star()
        {
            mario.Star();
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
            return mario.IsStarMario();
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
            mario.Run();
        }

        public void StopRunning()
        {
            mario.StopRunning();
        }


        public bool IsHurt()
        {
            return true;
        }


        public bool IsPressingDown()
        {
            return mario.IsPressingDown();
        }
    }
}
