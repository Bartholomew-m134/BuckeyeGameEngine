using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherLeftMarioStanceCommand : ICommand
    {
        public FurtherLeftMarioStanceCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Left();
        }

        public void Release()
        {
            WorldManager.GetMario().ToIdle();
        }
    }
}
