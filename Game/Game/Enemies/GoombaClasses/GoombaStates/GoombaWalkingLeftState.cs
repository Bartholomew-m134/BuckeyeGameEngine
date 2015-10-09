using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaWalkingLeftState : IGoombaState
    {
        private Goomba goomba;
        public GoombaWalkingLeftState(Goomba goomba)
        {
            this.goomba = goomba;
            this.goomba.sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaWalkingLeftSprite();
        }
        public void SmashGoomba()
        {
            goomba.state = new GoombaSmashedState(goomba);
        }
        public void DirectionChangeGoomba()
        {
            goomba.state = new GoombaWalkingRightState(goomba);
        }
        public void FlipGoomba()
        {
            goomba.state = new GoombaFlippedState(goomba);
        }
    }
}
