using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaStates
{
    public class GreenKoopaFlippedInShellState : IGreenKoopaState
    {
        private GreenKoopa greenKoopa;
        private Game1 myGame;

        public GreenKoopaFlippedInShellState(GreenKoopa greenKoopa, Game1 game)
        {
            this.greenKoopa = greenKoopa;
            this.myGame = game;
            this.greenKoopa.greenKoopaSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaFlippedInShellSprite(myGame);
        }

        public void GreenKoopaEmergingFromShell()
        {
        }

        public void GreenKoopaShellFlipped()
        {
        }

        public void GreenKoopaHidingInShell()
        {
        }

        public void GreenKoopaChangeDirection()
        {
        }
    }
}
