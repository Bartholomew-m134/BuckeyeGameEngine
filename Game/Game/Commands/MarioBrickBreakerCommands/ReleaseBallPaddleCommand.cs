using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioBrickBreakerCommands
{
    public class ReleaseBallPaddleCommand : ICommand
    {
        public ReleaseBallPaddleCommand()
        {
        }

        public void Execute()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).ReleaseBall();
        }

        public void Hold()
        {
            
        }

        public void Release()
        {
           
        }
    }
}
