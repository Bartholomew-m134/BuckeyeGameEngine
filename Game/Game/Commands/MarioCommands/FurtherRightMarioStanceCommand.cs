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
            WorldManager.ReturnPlayer().Right();
        }

        public void Release()
        {
            if (WorldManager.ReturnPlayer().IsJumping() == false)
            {
                WorldManager.ReturnPlayer().ToIdle();
            }
            else {
                WorldManager.ReturnPlayer().Physics.ResetX();
            }
        }
    }
}
