using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;


namespace Game.States
{
    class DeadMarioState : IMarioState
    {

        private IMario mario;
        private Game1 game;

        public DeadMarioState(IMario mario, Game1 game)
        {
            this.mario = mario;
            this.game = game;
            mario.GetSetSprite = SpriteFactories.MarioSpriteFactory.CreateDeadSprite();
        }

        public void Update() {
            mario.GetSetSprite.Update();
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
        }

        public void Mushroom()
        {
        }

        public void Star()
        {

        }

        public void Damage()
        {
        }

        public void Die()
        {
            
        }
        public bool IsBig()
        {
            return false;
        }
    }
}
