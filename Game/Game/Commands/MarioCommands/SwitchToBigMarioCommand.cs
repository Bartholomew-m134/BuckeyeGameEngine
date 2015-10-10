using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToBigMarioCommand : ICommand
    {
        public SwitchToBigMarioCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Mushroom();
        }

        public void Release()
        {

        }
    }
}
