using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherRightPacMarioStanceCommand : ICommand
    {
        public FurtherRightPacMarioStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IMario)WorldManager.ReturnPlayer()).Right();
        }

        public void Release()
        {
            ((IMario)WorldManager.ReturnPlayer()).Physics.ResetPhysics();
        }
    }
}
