using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioBrickBreakerCommands
{
    public class MagnetizePaddleCommand : ICommand
    {
        public MagnetizePaddleCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).IsMagnetized = true;
        }

        public void Release()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).IsMagnetized = false;
        }
    }
}
