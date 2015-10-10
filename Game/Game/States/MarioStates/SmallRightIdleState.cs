using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    public class SmallRightIdleState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public SmallRightIdleState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightIdleSprite();
        }
        public void Update()
        {
            mario.GetSprite.Update();
        }

        public void Left()
        {
            mario.MarioStateProperty = new SmallLeftIdleState(mario, game);
        }

        public void Right()
        {
            mario.MarioStateProperty = new SmallRightRunningState(mario, game);
        }

        public void Up()
        {

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
            mario.MarioStateProperty = new SmallRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.MarioStateProperty = new FireRightIdleState(mario, game);
        }

        public void Mushroom()
        {
            mario.MarioStateProperty = new NormalRightIdleState(mario, game);
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
