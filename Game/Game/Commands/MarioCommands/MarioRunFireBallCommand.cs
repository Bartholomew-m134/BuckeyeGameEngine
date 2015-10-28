using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    class MarioRunFireBallCommand : ICommand
    {
        public MarioRunFireBallCommand()
        {

        }

        public void Execute()
        {
            WorldManager.GetMario().Fire();
        }

        public void Hold()
        {
            WorldManager.GetMario().Run();
        }

        public void Release()
        {
            WorldManager.GetMario().StopRunning();
        }
    }
}
