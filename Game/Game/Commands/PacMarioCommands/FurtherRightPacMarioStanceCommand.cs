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
            WorldManager.ReturnPlayer().Right();
        }

        public void Release()
        {
            WorldManager.ReturnPlayer().Physics.ResetX();
        }
    }
}
