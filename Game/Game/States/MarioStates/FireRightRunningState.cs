using System;
using System.Collections.Generic;
using System.Linq;
using Game.Mario;
using System.Text;

namespace Game.States
{
    class FireRightRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireRightRunning(MarioInstance mario, Game1 game)
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
            mario.state = new FireRightIdle(mario, game);
        }

        public void Right()
        {

        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireRightCrouching(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireRightJumping(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalRightRunning(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightRunning(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
