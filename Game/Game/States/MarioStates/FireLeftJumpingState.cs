using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class FireLeftJumpingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftJumpingSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.X -= 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Right()
        {
            mario.state = new FireRightJumpingState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.state = new FireLeftIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y -= 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
        }

        public void Damage()
        {
            mario.state = new NormalLeftJumpingState(mario, game);
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
