using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BlockCommands
{
    public class SwitchToUsedQuestionBlockCommand : ICommand
    {
        private Game1 game;

        public SwitchToUsedQuestionBlockCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            //game.questionBlock.GetUsed();
        }

        public void Release()
        {

        }
    }
}
