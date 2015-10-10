using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallRightJumpingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallRightJumpingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new SmallLeftJumpingState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X += 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.MarioStateProperty = new SmallRightIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y -= 4;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireRightJumpingState(mario, game);
        }

        public void Mushroom()
        {
            mario.MarioStateProperty = new NormalRightJumpingState(mario, game);
        }

        public void Star()
        {
            mario = new StarMario(mario, game);
        }

        public void Damage()
        {
            mario.MarioStateProperty = new DeadMarioState(mario, game);
        }

        public void Die()
        {
            mario.MarioStateProperty = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return false;
        }
    }
}
