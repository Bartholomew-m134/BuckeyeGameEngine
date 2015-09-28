using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalRightIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalRightIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalRightIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalLeftIdle(mario, game);
        }

        public void Right()
        {
            mario.state = new NormalRightRunning(mario, game);
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
            mario.state = new FireRightIdle(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Damage()
        {
            mario.state = new SmallRightIdle(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
