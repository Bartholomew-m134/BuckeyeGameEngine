using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;

namespace Game.Commands.BuckeyePlayerCommands
{
    public class TransitionLeftBuckeyeCommand : ICommand
    {
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
