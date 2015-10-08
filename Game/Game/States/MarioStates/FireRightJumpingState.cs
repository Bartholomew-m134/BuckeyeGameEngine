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

        private MarioInstance mario;
        private Game1 game;

        public FireRightJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightJumpingSprite();
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
            mario.state = new FireRightIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y--;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalRightJumpingState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightJumpingState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }
        public bool IsBig()
        {
            return true;
        }
    }
}
