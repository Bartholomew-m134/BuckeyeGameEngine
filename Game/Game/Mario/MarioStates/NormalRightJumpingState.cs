using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Mario.MarioStates
{
    public class NormalRightJumpingState : IMarioState
    {

        private IMario mario;

        public NormalRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightJumpingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalLeftJumpingState(mario);
        }

        public void Right()
        {
            ObjectPhysics physics = mario.Physics;
            Vector2 acceleration = physics.GetSetAcceleration;
            acceleration.X = 2;
            physics.GetSetAcceleration = acceleration;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario);
        }

        public void Land()
        {
            
        }

        public void Jump()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.Y -= 4;
            mario.VectorCoordinates = loc;
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightJumpingState(mario);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            //mario = new StarMario(mario);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new SmallRightJumpingState(mario);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return true;
        }

        public void ToIdle()
        {

        }
    }
}
