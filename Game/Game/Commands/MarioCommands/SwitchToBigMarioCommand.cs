using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToBigMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToBigMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            Mario.MarioInstance.state.mushroom();
        }
    }
}
