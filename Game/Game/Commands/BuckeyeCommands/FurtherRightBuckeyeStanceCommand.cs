using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BuckeyeCommands
{
    public class FurtherRightBuckeyeStanceCommand : ICommand
    {
        public FurtherRightBuckeyeStanceCommand()
        {
        }

        public void Execute()
        {

        }

        public void Hold()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Right();
        }

        public void Release()
        {
            if (((IBuckeyePlayer)WorldManager.ReturnPlayer()).IsJumping() == false)
            {
                ((IBuckeyePlayer)WorldManager.ReturnPlayer()).ToIdle();
            }
            else
            {
                ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Physics.ResetX();
            }
        }
    }
}
