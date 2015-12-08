using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherLeftPacMarioStanceCommand : ICommand
    {
        public FurtherLeftPacMarioStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IMario)WorldManager.ReturnPlayer()).Left();
        }

        public void Release()
        {
            ((IMario)WorldManager.ReturnPlayer()).Physics.ResetPhysics();
        }
    }
}
