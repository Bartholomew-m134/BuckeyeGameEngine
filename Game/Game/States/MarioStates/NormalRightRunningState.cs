using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightRunningSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void Right()
        {

        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new NormalRightCrouching(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new NormalRightJumping(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireRightRunning(mario, game);
        }

        public void Mushroom()
        {

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
