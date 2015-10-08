using System;
using System.Linq;
using System.Text;

namespace Game.Commands
{
    public class ResetToDefaultCommand : ICommand
    {
        private Game1 game;

        public ResetToDefaultCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            WorldManager.ResetToDefault(game);
        }
    }
}
