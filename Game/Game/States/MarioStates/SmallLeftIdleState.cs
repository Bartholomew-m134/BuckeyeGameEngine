using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class SmallLeftIdleState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public SmallLeftIdleState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateSmallLeftIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new SmallLeftRunningState(mario, game);
        }

        public void Right()
        {
            mario.state = new SmallRightIdleState(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.Y++;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new SmallLeftJumpingState(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireLeftIdleState(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalLeftIdleState(mario, game);
        }

        public void Damage()
        {
            //mario.state = new Dead(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }

    }
}
