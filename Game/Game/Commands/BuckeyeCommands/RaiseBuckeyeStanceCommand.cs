using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BuckeyeCommands
{
    public class RaiseBuckeyeStanceCommand : ICommand
    {
        public RaiseBuckeyeStanceCommand()
        {
        }

        public void Execute()
        {

        }

        public void Hold()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Jump();
        }

        public void Release()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).StopJumping();
        }
    }
}
