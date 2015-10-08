using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class NormalRightCrouchingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightCrouchingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightCrouchingSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.state = new NormalRightRunningState(mario, game);
        }

        public void Up()
        {
            mario.state = new NormalRightIdleState(mario, game);
        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y += 4;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Land()
        {

        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireRightCrouchingState(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Damage()
        {
            mario.state = new SmallLeftIdleState(mario, game);
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
