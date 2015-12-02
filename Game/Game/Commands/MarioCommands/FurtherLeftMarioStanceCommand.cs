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
            ((IMario)WorldManager.ReturnPlayer()).Left();
        }

        public void Release()
        {
            if (((IMario)WorldManager.ReturnPlayer()).IsJumping() == false)
            {
                ((IMario)WorldManager.ReturnPlayer()).ToIdle();
            }
            else {
                ((IMario)WorldManager.ReturnPlayer()).Physics.ResetX();
            }
        }
    }
}
