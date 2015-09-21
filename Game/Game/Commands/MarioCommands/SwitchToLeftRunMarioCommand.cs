using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToLeftRunMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToLeftRunMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {

        }
    }
}
