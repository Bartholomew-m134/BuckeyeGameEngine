using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToLeftIdleMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToLeftIdleMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {

        }
    }
}
