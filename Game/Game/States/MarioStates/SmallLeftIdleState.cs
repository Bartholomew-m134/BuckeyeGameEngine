using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallLeftIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallLeftIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftIdleSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new SmallLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new SmallRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.Y +=2;
            WorldManager.GetMario().VectorCoordinates = (loc);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new SmallLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireLeftIdleState(mario, game);
        }

        public void Mushroom()
        {
            mario.MarioStateProperty = new NormalLeftIdleState(mario, game);
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
