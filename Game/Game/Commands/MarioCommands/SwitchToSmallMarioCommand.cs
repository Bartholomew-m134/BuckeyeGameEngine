using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToSmallMarioCommand : ICommand
    {
        public SwitchToSmallMarioCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Damage();
        }

        public void Release()
        {

        }
    }
}
