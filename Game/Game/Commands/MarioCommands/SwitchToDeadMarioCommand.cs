using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToDeadMarioCommand : ICommand
    {
        public SwitchToDeadMarioCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Die();
        }

        public void Release()
        {

        }
    }
}
