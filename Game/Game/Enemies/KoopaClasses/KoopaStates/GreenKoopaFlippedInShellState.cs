using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public class GreenKoopaFlippedInShellState : IKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaFlippedInShellState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            this.greenKoopa.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaFlippedInShellSprite();
        }

        public void KoopaEmergingFromShell()
        {
        }

        public void KoopaShellFlipped()
        {
        }

        public void KoopaHidingInShell()
        {
        }

        public void KoopaChangeDirection()
        {
        }
    }
}
