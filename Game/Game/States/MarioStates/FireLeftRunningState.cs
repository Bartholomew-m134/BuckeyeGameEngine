using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class FireLeftRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public FireLeftRunning(MarioInstance mario, Game1 game)
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

        }

        public void Right()
        {
            mario.state = new FireLeftIdle(mario, game);
        }

        public void Up()
        {

        }

        public void Down()
        {
            mario.state = new FireLeftCrouching(mario, game);
        }

        public void Land()
        {

        }

        public void Jump()
        {
            mario.state = new FireLeftJumping(mario, game);
        }

        public void Flower()
        {

        }

        public void Mushroom()
        {
            mario.state = new NormalLeftRunning(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallLeftRunning(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
