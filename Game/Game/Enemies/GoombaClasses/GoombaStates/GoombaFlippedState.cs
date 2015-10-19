using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaFlippedState : IGoombaState
    {
        private Goomba goomba;
        public GoombaFlippedState(Goomba goomba)
        {
            this.goomba = goomba;
            this.goomba.GetSetSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaFlippedSprite();
        }
        public void SmashGoomba()
        {
        }
        public void DirectionChangeGoomba()
        {
        }
        public void FlipGoomba()
        {
        }
    }
}
