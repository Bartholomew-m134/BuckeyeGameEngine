using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public class GreenKoopaEmergingFromShellState : IKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaEmergingFromShellState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            this.greenKoopa.GetSetSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaEmergingFromShellSprite();
        }

        public void KoopaEmergingFromShell()
        {
        }

        public void KoopaShellFlipped()
        {
            greenKoopa.state = new GreenKoopaFlippedInShellState(greenKoopa);
        }

        public void KoopaHidingInShell()
        {
            greenKoopa.state = new GreenKoopaHidingInShellState(greenKoopa);
        }

        public void KoopaChangeDirection()
        {
            greenKoopa.state = new GreenKoopaWalkingLeftState(greenKoopa);
        }
    }
}
