using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public class GoombaSmashedState : IGoombaState
    {
        private Goomba goomba;
        private Game1 myGame;
        public GoombaSmashedState(Goomba goomba, Game1 game)
        {
            this.goomba = goomba;
            this.myGame = game;
            this.goomba.goombaSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGoombaSmashedSprite(myGame);
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
