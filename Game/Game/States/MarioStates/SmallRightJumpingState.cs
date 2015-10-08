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

        private MarioInstance mario;
        private Game1 game;

        public SmallRightJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallRightJumpingSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {

        }

        public void Right()
        {

        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.state = new SmallRightIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y--;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Flower()
        {
            mario.state = new FireRightJumpingState(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightJumpingState(mario, game);
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
