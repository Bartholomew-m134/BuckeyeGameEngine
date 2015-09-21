using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToRightRunMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToRightRunMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {

        }
    }
}
