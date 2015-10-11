using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class FireRightJumpingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public FireRightJumpingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateFireRightJumpingSprite();
        }
        public void Update()
        {
            mario.GetSetSprite.Update();
        }

        public void Left()
        {
            mario.GetSetMarioState = new FireLeftJumpingState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.X += 2;
            mario.VectorCoordinates = (loc);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.GetSetMarioState = new FireRightIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = mario.VectorCoordinates;
            loc.Y -= 2;
            mario.VectorCoordinates = (loc);
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
            mario.GetSetMarioState = new NormalRightJumpingState(mario, game);
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
