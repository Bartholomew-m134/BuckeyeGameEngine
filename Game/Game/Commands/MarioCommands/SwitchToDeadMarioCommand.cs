using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToDeadMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToDeadMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            Mario.MarioInstance.state.die();
        }
    }
}
