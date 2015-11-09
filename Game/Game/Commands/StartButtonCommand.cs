using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands
{
    public class StartButtonCommand : ICommand
    {
        private Game1 game;

        public StartButtonCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.gameState.StartButton();
        }

        public void Hold()
        {

        }

        public void Release()
        {

        }
    }
}
