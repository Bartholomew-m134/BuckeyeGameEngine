using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class FireLeftRunningState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftRunningState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.X--;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Right()
        {
            mario.state = new FireLeftIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireLeftCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireLeftJumpingState(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalLeftRunningState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallLeftRunningState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }

    }
}
