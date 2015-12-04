using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioBrickBreakerCommands
{
    public class FurtherLeftPaddleCommand : ICommand
    {

        public FurtherLeftPaddleCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).Left();
        }

        public void Release()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).Physics.ResetX();
        }
    }
}
