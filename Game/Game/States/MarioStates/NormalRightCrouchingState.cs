using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class NormalRightCrouchingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalRightCrouchingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightCrouchingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new NormalLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.GetSetMarioState = new NormalRightRunningState(mario, game);
        }

        public void Up()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario, game);
        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y += 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Land()
        {

        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.GetSetMarioState = new FireRightCrouchingState(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Star()
        {
            mario = new StarMario((MarioInstance)mario, game);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new SmallLeftIdleState(mario, game);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
