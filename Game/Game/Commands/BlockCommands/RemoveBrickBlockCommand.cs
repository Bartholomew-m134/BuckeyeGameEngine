using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BlockCommands
{
    public class RemoveBrickBlockCommand : ICommand
    {
        private Game1 game;

        public RemoveBrickBlockCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            //game.brickBlock.Disappear();
        }

        public void Release()
        {

        }
    }
}
