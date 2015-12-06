using Game.Interfaces;
using Game.Lemming.Elevators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.LemmingCommands
{
    class Shift : ICommand
    {
        public Shift()
        {
        }

        public void Execute()
        {
            ((Elevator)WorldManager.ReturnElevators()).Shift();
        }

        public void Hold()
        {
            
        }

        public void Release()
        {

        }
    }
}
