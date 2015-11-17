using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Mario;

namespace Game.Commands.MarioCommands
{
    class MarioRunFireBallCommand : ICommand
    {
        public MarioRunFireBallCommand()
        {
        }

        public void Execute()
        {
            if(((IMario)WorldManager.GetPlayer()).IsFireMario())
                ((IMario)WorldManager.GetPlayer()).ThrowFireball();
        }

        public void Hold()
        {
            WorldManager.GetPlayer().Run();
        }

        public void Release()
        {
            WorldManager.GetPlayer().StopRunning();
        }
    }
}
