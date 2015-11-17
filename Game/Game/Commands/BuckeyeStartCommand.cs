using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;

namespace Game.Commands
{
    public class BuckeyeStartCommand : ICommand
    {
        private Game1 game;

        public BuckeyeStartCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.gameState.StartBuckeyeButton();
        }

        public void Hold()
        {

        }

        public void Release()
        {

        }
    }
}
