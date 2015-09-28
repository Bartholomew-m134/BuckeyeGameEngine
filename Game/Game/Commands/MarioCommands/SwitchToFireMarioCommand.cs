using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToFireMarioCommand : ICommand
    {
        private Game1 game;

        public SwitchToFireMarioCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.mario.flower();
        }
    }
}
