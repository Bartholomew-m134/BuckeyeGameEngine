using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherRightMarioStanceCommand : ICommand
    {
        public FurtherRightMarioStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            WorldManager.GetMario().Right();
        }

        public void Release()
        {
            if (WorldManager.GetMario().IsJumping() == false)
            {
                WorldManager.GetMario().ToIdle();
            }
            else {
                WorldManager.GetMario().Physics.ResetX();
            }
        }
    }
}
