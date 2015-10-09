using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class FireLeftCrouchingState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftCrouchingState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireLeftCrouchingSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new FireLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.state = new FireRightRunningState(mario, game);
        }

        public void Up()
        {
            mario.state = new FireLeftIdleState(mario, game);
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

        }

        public void Mushroom()
        {
        }
        
        //public void Star()
        //{

            //mario = new StarMario(mario, game);
        //}

        public void Damage()
        {
            mario.state = new NormalLeftIdleState(mario, game);
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
