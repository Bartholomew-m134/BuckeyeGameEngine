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
    public class SmallRightJumpingState : IMarioState
    {

        private IMario mario;

        public SmallRightJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new SmallLeftJumpingState(mario);
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
            mario.GetSetMarioState = new SmallRightIdleState(mario);
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
            mario.GetSetMarioState = new NormalRightJumpingState(mario);
        }

        public void Star()
        {
            //mario = new StarMario(mario);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario);
        }
        public bool IsBig()
        {
            return false;
        }

        public void ToIdle()
        {

        }
    }
}
