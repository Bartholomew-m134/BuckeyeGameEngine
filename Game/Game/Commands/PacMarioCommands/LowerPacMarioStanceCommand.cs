using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class LowerPacMarioStanceCommand : ICommand
    {
        public LowerPacMarioStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IMario)WorldManager.ReturnPlayer()).Down();
        }

        public void Release()
        {
            ((IMario)WorldManager.ReturnPlayer()).Physics.ResetPhysics();
        }
    }
}
