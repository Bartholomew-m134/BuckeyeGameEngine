using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToSmallMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToSmallMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.mario.state.damage();
        }
    }
}
