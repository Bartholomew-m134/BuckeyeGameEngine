using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherRightMarioStanceCommand : ICommand
    {
        private Game1 game;

        public FurtherRightMarioStanceCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.mario.Right();
        }
    }
}
