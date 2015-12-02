using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BuckeyeCommands
{
    public class BuckeyeRunFootBallCommand : ICommand
    {
        public BuckeyeRunFootBallCommand()
        {
        }

        public void Execute()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Throw();
        }

        public void Hold()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Run();
        }

        public void Release()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).StopRunning();
        }
    }
}
