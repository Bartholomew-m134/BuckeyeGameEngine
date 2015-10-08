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

        private MarioInstance mario;
        private Game1 game;

        public SmallLeftJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftJumpingSprite();
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
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y--;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.state = new SmallLeftIdleState(mario, game);
        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireLeftJumpingState(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalLeftJumpingState(mario, game);
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
