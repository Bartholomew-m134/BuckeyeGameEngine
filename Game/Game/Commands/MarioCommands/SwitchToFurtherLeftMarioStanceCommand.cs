﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToFurtherLeftMarioStanceCommand : ICommand
    {
        private Game1 game;

        public SwitchToFurtherLeftMarioStanceCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execture()
        {

        }
    }
}
