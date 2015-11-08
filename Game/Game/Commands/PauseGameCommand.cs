using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands
{
    public class PauseGameCommand : ICommand
    {
        private Game1 game;

        public PauseGameCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.gameState.Pause();
        }

        public void Hold()
        {

        }

        public void Release()
        {

        }
    }
}
