using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public class GreenKoopaHidingInShellState : IKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaHidingInShellState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            float prevHeight = greenKoopa.Sprite.SpriteDimensions.Y;
            this.greenKoopa.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaHidingInShellSprite();
            greenKoopa.VectorCoordinates += new Microsoft.Xna.Framework.Vector2(0, prevHeight - greenKoopa.Sprite.SpriteDimensions.Y);

            Vector2 velocity = this.greenKoopa.Physics.Velocity;
            velocity.X = 0;
            this.greenKoopa.Physics.Velocity = velocity;
        }

        public void KoopaEmergingFromShell()
        {
            greenKoopa.state = new GreenKoopaEmergingFromShellState(greenKoopa);
        }

        public void KoopaShellFlipped()
        {
            greenKoopa.state = new GreenKoopaFlippedInShellState(greenKoopa);
        }

        public void KoopaHidingInShell()
        {
        }

        public void KoopaChangeDirection()
        {
            //greenKoopa.state = new GreenKoopaWalkingLeftState(greenKoopa);
        }
    }
}
