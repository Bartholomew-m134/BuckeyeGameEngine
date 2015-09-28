using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftIdle : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftIdle(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftIdleSprite();
        }
        public void Update()
        {
            mario.sprite.Update();
        }

        public void Left()
        {
            mario.state = new NormalLeftRunning(mario, game);
        }

        public void Right()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new NormalLeftCrouching(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new NormalLeftJumping(mario, game);
        }

        public void Flower()
        {
            mario.state = new FireLeftIdle(mario, game);

        }

        public void Mushroom()
        {

        }

        public void Damage()
        {
            mario.state = new SmallLeftIdle(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
