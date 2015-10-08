using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class NormalLeftJumpingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftJumpingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftJumpingSprite();
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
            mario.state = new NormalRightJumpingState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.state = new NormalLeftIdleState(mario, game);
        }

        public void Jump()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y -= 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Flower()
        {
            mario.state = new FireLeftJumpingState(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Damage()
        {
            mario.state = new SmallLeftJumpingState(mario, game);
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
