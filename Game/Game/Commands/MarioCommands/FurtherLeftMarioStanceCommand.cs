using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherLeftMarioStanceCommand : ICommand
    {
        public FurtherLeftMarioStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            WorldManager.GetPlayer().Left();
        }

        public void Release()
        {
            if (WorldManager.GetPlayer().IsJumping() == false)
            {
                WorldManager.GetPlayer().ToIdle();
            }
            else {
                WorldManager.GetPlayer().Physics.ResetX();
            }
        }
    }
}
