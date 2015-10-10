using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallLeftJumpingState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallLeftJumpingState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftJumpingSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X -= 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Right()
        {
            mario.MarioStateProperty = new SmallRightJumpingState(mario, game);
        }

        public void Up()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y -= 2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.MarioStateProperty = new SmallLeftIdleState(mario, game);
        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireLeftJumpingState(mario, game);
        }

        public void Mushroom()
        {
            mario.MarioStateProperty = new NormalLeftJumpingState(mario, game);
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
