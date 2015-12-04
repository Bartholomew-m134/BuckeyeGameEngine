using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioBrickBreakerCommands
{
    public class FurtherRightPaddleCommand : ICommand
    {
        public FurtherRightPaddleCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).Right();
        }

        public void Release()
        {
            ((IPaddle)WorldManager.ReturnPlayer()).Physics.ResetX();
        }
    }
}
