using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.States
{
    class FireRightRunningState : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightRunningState(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateFireRightRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new FireRightIdleState(mario, game);
        }

        public void Right()
        {
            Vector2 loc = WorldManager.GetMario().getLocation();
            loc.X++;
            WorldManager.GetMario().setLocation(loc);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireRightCrouchingState(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireRightJumpingState(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalRightRunningState(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightRunningState(mario, game);
        }

        public void Die()
        {
            mario.state = new DeadMarioState(mario, game);
        }

    }
}
