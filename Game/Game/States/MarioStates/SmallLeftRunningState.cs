using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallLeftRunningState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallLeftRunningState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftRunningSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X-=2;
            WorldManager.GetMario().VectorCoordinates = loc;
        }

        public void Right()
        {
            mario.MarioStateProperty = new SmallLeftIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioStateProperty = new SmallLeftIdleState(mario, game);
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
            mario.MarioStateProperty = new FireLeftRunningState(mario, game);
        }

        public void Mushroom()
        {
            mario.MarioStateProperty = new NormalLeftRunningState(mario, game);
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
