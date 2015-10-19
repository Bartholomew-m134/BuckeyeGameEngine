using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class SwitchToFireMarioCommand : ICommand
    {
        public SwitchToFireMarioCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Flower();
        }

        public void Release()
        {

        }
    }
}
