using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class LowerMarioStanceCommand : ICommand
    {
        public LowerMarioStanceCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Down();
            WorldManager.GetMario().Land();
        }

        public void Release()
        {

        }
    }
}
