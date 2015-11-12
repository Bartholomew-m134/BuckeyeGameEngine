using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.SoundEffects;
using Game.Utilities.Constants;
namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public class GreenKoopaFlippedInShellState : IKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaFlippedInShellState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            SoundEffectManager.EnemyFlippedEffect();
            greenKoopa.Physics.Velocity = new Vector2(0, EnemyStatesConstants.FLIPPEDYVELOCITY);
            greenKoopa.Physics.Acceleration = new Vector2(0, EnemyStatesConstants.GRAVITY);
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
