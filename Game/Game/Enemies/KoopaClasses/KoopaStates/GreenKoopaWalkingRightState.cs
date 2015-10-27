using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public class GreenKoopaWalkingRightState : IKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaWalkingRightState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            this.greenKoopa.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaWalkingRightSprite();

            Vector2 velocity = this.greenKoopa.Physics.Velocity;
            velocity.X = 2;
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
            greenKoopa.state = new GreenKoopaHidingInShellState(greenKoopa);
        }

        public void KoopaChangeDirection()
        {
            greenKoopa.state = new GreenKoopaWalkingLeftState(greenKoopa);
        }
    }
}
