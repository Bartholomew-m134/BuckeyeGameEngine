﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaStates
{
    public class GreenKoopaWalkingRightState : IGreenKoopaState
    {
        private GreenKoopa greenKoopa;
        private Game1 myGame;

        public GreenKoopaWalkingRightState(GreenKoopa greenKoopa, Game1 game)
        {
            this.greenKoopa = greenKoopa;
            this.myGame = game;
            this.greenKoopa.greenKoopaSprite = Game.SpriteFactories.EnemySpriteFactory.CreateGreenKoopaWalkingRightSprite(myGame);
        }

        public void GreenKoopaEmergingFromShell()
        {
            greenKoopa.state = new GreenKoopaEmergingFromShellState(greenKoopa, myGame);
        }

        public void GreenKoopaShellFlipped()
        {
            greenKoopa.state = new GreenKoopaFlippedInShellState(greenKoopa, myGame);
        }

        public void GreenKoopaHidingInShell()
        {
            greenKoopa.state = new GreenKoopaHidingInShellState(greenKoopa, myGame);
        }

        public void GreenKoopaChangeDirection()
        {
            greenKoopa.state = new GreenKoopaWalkingLeftState(greenKoopa, myGame);
        }
    }
}
