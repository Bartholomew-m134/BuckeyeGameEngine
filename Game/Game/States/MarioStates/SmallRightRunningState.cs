using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallRightRunningState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallRightRunningState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightRunningSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new SmallRightIdleState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().VectorCoordinates;
            loc.X += 4;
            WorldManager.GetMario().VectorCoordinates = loc;
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.MarioStateProperty = new SmallRightIdleState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new SmallRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireRightRunningState(mario, game);
        }

        public void Mushroom()
        {
            mario.MarioStateProperty = new NormalRightRunningState(mario, game);
        }

        public void Star()
        {
            mario = new StarMario((MarioInstance)mario, game);
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
