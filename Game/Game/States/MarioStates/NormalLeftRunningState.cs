using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftRunning : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftRunning(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftRunningSprite();
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
            mario.state = new NormalLeftIdle(mario, game);
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
            mario.state = new FireRightRunning(mario, game);
        }

        public void Mushroom()
        {

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
