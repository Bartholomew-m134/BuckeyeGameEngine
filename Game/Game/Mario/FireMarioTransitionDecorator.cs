using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SoundEffects;
using Game.Utilities.Constants;

namespace Game.Mario
{
    public class FireMarioTransitionDecorator : IMario
    {
        private IMario mario;
        private int frame;

        public FireMarioTransitionDecorator(IMario mario)
        {
            this.mario = mario;
            SoundEffectManager.PowerPlayerUpEffect();
            WorldManager.SetPlayer(this);
            frame = 0;
        }

        public void Damage()
        {
        }

        public void Update()
        {
            if (frame == IMarioObjectConstants.POWERUPMARIOTIMERMAX)
            {
                WorldManager.SetPlayer(this.mario);
            }
            else if (frame % IMarioObjectConstants.TWO == 0 && frame % IMarioObjectConstants.FOUR == 0)
            {
                mario.MarioState.Flower();
            }
            else if (frame % IMarioObjectConstants.TWO == 0 && frame % IMarioObjectConstants.FOUR != 0)
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

        public void ThrowFireball()
        {
            
        }

        public void Mushroom()
        {
            
        }
        public void Star()
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

        public static bool IsTransitioning()
        {
            return true;
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

        public IPhysics Physics
        {
            get { return ((IMario)mario).Physics; }
        }



        public void Run()
        {
            
        }

        public void StopRunning()
        {
            
        }


        public bool IsHurt()
        {
            return false;
        }


        public bool IsPressingDown()
        {
            return mario.IsPressingDown();
        }

        public bool Dead
        {
            get { return mario.Dead; }
            set { mario.Dead = value; }
        }
    }
}
