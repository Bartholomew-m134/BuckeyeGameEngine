using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToLowerMarioStanceCommand : ICommand
    {
        private Game1 game;

        public SwitchToLowerMarioStanceCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {

        }
    }
}
