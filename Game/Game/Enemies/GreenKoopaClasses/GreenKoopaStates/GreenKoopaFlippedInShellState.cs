using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaStates
{
    public class GreenKoopaFlippedInShellState : IGreenKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaFlippedInShellState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            this.greenKoopa.greenKoopaSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaFlippedInShellSprite();
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
