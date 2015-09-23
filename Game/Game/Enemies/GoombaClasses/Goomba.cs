using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Enemies.GoombaClasses.GoombaStates;

namespace Game.Enemies.GoombaClasses
{
    public class Goomba
    {
        public IGoombaState state;
        public ISprite goombaSprite;
        private Game1 myGame;

        public Goomba(Game1 game)
        {
            myGame = game;
            state = new GoombaWalkingLeftState(this, myGame);

        }

        public void SmashedGoomba()
        {
            state.SmashGoomba();
        }

        public void DirectionChangeGoomba()
        {
            state.DirectionChangeGoomba();
        }

        public void FlipGoomba()
        {
            state.FlipGoomba();
        }
    }
}
