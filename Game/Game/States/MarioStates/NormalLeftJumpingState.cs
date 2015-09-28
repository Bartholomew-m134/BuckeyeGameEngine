using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.States
{
    class NormalLeftJumping : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public NormalLeftJumping(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateNormalLeftJumpingSprite();
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

        }

        public void Up()
        {

        }

        public void Down()
        {

        }

        public void Land()
        {
            mario.state = new NormalLeftIdle(mario, game);
        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireLeftJumping(mario, game);
        }

        public void Mushroom()
        {

        }

        public void Damage()
        {
            mario.state = new SmallLeftJumping(mario, game);
        }

        public void Die()
        {
            mario.state = new Dead(mario, game);
        }

    }
}
