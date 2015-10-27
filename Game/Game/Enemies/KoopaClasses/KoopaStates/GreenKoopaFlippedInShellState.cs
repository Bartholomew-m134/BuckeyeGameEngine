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
            this.greenKoopa.IsFlipped = true;
            float prevHeight = greenKoopa.Sprite.SpriteDimensions.Y;
            this.greenKoopa.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaFlippedInShellSprite();
            greenKoopa.VectorCoordinates += new Microsoft.Xna.Framework.Vector2(0, prevHeight - greenKoopa.Sprite.SpriteDimensions.Y);
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
