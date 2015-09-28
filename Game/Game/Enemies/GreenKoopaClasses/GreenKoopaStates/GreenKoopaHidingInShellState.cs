using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaStates
{
    public class GreenKoopaHidingInShellState : IGreenKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaHidingInShellState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            this.greenKoopa.greenKoopaSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaHidingInShellSprite();
        }

        public void GreenKoopaEmergingFromShell()
        {
            greenKoopa.state = new GreenKoopaEmergingFromShellState(greenKoopa);
        }

        public void GreenKoopaShellFlipped()
        {
            greenKoopa.state = new GreenKoopaFlippedInShellState(greenKoopa);
        }

        public void GreenKoopaHidingInShell()
        {
        }

        public void GreenKoopaChangeDirection()
        {
            greenKoopa.state = new GreenKoopaWalkingLeftState(greenKoopa);
        }
    }
}
