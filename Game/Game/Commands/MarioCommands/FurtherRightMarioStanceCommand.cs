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
            ((IMario)WorldManager.ReturnPlayer()).Right();
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
