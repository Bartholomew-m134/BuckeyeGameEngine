using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;


namespace Game.States
{
    class Dead : IMarioState
    {

        private MarioInstance mario;
        private Game1 game;

        public Dead(MarioInstance mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.sprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
        }

        public void Update() {
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

        }

        public void Jump()
        {

        }

        public void Flower()
        {
            mario.state = new FireRightIdle(mario, game);
        }

        public void Mushroom()
        {
            mario.state = new NormalRightIdle(mario, game);
        }

        public void Damage()
        {
            mario.state = new SmallRightIdle(mario, game);
        }

        public void Die()
        {
            
        }

    }
}
