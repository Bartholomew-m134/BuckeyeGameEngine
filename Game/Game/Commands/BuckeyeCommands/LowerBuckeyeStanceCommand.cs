using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BuckeyeCommands
{
    public class LowerBuckeyeStanceCommand : ICommand
    {
        public LowerBuckeyeStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Down();
        }

        public void Release()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Up();
        }
    }
}
