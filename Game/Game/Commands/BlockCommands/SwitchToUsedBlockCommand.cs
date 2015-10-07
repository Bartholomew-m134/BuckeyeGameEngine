using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BlockCommands
{
    public class SwitchToUsedBlockCommand : ICommand
    {
        private Game1 game;

        public SwitchToUsedBlockCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            //game.hiddenBlock.GetUsed();
        }
    }
}
