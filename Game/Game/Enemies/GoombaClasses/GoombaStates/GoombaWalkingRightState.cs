using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaWalkingRightState : IGoombaState
    {
        private Goomba goomba;
        private Game1 myGame;
        public GoombaWalkingRightState(Goomba goomba, Game1 game)
        {
            this.goomba = goomba;
            this.myGame = game;
            this.goomba.goombaSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaWalkingRightSprite(myGame);
        }
        public void SmashGoomba()
        {
            goomba.state = new GoombaSmashedState(goomba, myGame);
        }
        public void DirectionChangeGoomba()
        {
            goomba.state = new GoombaWalkingLeftState(goomba, myGame);
        }
        public void FlipGoomba()
        {
            goomba.state = new GoombaFlippedState(goomba, myGame);
        }
    }
}
