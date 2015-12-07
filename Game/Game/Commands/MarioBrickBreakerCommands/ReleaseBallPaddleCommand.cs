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
            if(!WorldManager.ReturnPaddleBall().IsReleased)
                ((IPaddleBall)WorldManager.ReturnPaddleBall()).ReleasePaddleBall();
        }

        public void Hold()
        {
            
        }

        public void Release()
        {
           
        }
    }
}
