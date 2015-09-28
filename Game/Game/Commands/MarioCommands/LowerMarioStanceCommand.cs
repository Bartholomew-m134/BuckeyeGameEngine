using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class LowerMarioStanceCommand : ICommand
    {
        private Game1 game;

        public LowerMarioStanceCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.mario.down();
            game.mario.land();
        }
    }
}
