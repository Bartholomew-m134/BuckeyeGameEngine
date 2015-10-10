using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class NormalRightRunningState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public NormalRightRunningState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightRunningSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new NormalRightIdleState(mario, game);
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
            mario.MarioStateProperty = new NormalRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.MarioStateProperty = new NormalRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireRightRunningState(mario, game);
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
            mario.MarioStateProperty = new SmallRightRunningState(mario, game);
        }

        public void Die()
        {
            mario.MarioStateProperty = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
