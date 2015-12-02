using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BuckeyeCommands
{
    public class FurtherLeftBuckeyeStanceCommand : ICommand
    {
        public FurtherLeftBuckeyeStanceCommand()
        {
        }

        public void Execute()
        {

        }

        public void Hold()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Left();
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
