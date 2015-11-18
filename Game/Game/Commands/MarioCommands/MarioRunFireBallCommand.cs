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
            if( WorldManager.ReturnPlayer() is IMario && ((IMario)WorldManager.ReturnPlayer()).IsFireMario())
                ((IMario)WorldManager.ReturnPlayer()).ThrowFireball();
        }

        public void Hold()
        {
            WorldManager.ReturnPlayer().Run();
        }

        public void Release()
        {
            WorldManager.ReturnPlayer().StopRunning();
        }
    }
}
