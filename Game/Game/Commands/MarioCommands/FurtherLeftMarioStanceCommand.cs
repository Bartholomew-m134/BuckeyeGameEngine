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
            WorldManager.GetMario().Left();
        }

        public void Release()
        {
            if (WorldManager.GetMario().IsJumping() == false)
            {
                WorldManager.GetMario().ToIdle();
            }
        }
    }
}
