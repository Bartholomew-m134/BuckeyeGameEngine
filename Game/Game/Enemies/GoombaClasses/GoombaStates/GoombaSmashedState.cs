using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaSmashedState : IGoombaState
    {
        private Goomba goomba;
        public GoombaSmashedState(Goomba goomba)
        {
            this.goomba = goomba;
            this.goomba.sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaSmashedSprite();
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
