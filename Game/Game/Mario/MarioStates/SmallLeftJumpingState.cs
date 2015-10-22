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
    public class SmallLeftJumpingState : IMarioState
    {

        private IMario mario;

        public SmallLeftJumpingState(IMario mario)
        {
            this.mario = mario;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftJumpingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            ObjectPhysics physics = mario.Physics;
            Vector2 acceleration = physics.GetSetAcceleration;
            acceleration.X = -2;
            physics.GetSetAcceleration = acceleration;
        }

        public void Right()
        {
            mario.GetSetMarioState = new SmallRightJumpingState(mario);
        }

        public void Up()
        {
            
        }

        public void Down()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario);
        }

        public void Land()
        {
            
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y -= 4;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireLeftJumpingState(mario);
        }

        public void Mushroom()
        {
            mario.GetSetMarioState = new NormalLeftJumpingState(mario);
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
