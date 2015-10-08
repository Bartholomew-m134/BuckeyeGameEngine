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

        private MarioInstance mario;
        private Game1 game;

        public SmallRightRunningState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new SmallRightIdleState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.X += 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new SmallRightJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireRightRunningState(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightRunningState(mario, game);
        }

        public void Damage()
        {
            //mario.state = new Dead(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return false;
        }
    }
}
