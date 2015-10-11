using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class FireRightCrouchingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public FireRightCrouchingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireRightCrouchingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new FireLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.GetSetMarioState = new FireRightRunningState(mario, game);
        }

        public void Up()
        {
            mario.GetSetMarioState = new FireRightIdleState(mario, game);
        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y += 4;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.GetSetMarioState = new FireRightIdleState(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
        }

        public void Star()
        {
            mario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.GetSetMarioState = new NormalRightIdleState(mario, game);
        }

        public void Die()
        {
            mario.GetSetMarioState = new DeadMarioState(mario, game);
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
