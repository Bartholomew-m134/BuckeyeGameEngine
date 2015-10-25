using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    class MarioFireBallCommand : ICommand
    {
        public MarioFireBallCommand()
        {

        }

        public void Execute()
        {
            //WorldManager.GetMario().FireBall();
        }

        public void Release()
        {

        }
    }
}
