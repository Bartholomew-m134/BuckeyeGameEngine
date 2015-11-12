﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public class GreenKoopaWalkingRightState : IKoopaState
    {
        private GreenKoopa greenKoopa;

        public GreenKoopaWalkingRightState(GreenKoopa greenKoopa)
        {
            this.greenKoopa = greenKoopa;
            this.greenKoopa.Sprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaWalkingRightSprite();

            greenKoopa.Physics.Velocity = new Vector2(EnemyStatesConstants.WALKINGRIGHTVELOCITY, 0);
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
