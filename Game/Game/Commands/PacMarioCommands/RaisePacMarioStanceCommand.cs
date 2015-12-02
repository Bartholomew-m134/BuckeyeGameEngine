using Game.Interfaces;
using Game.Mario;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class RaisePacMarioStanceCommand : ICommand
    {
        public RaisePacMarioStanceCommand()
        {
        }

        public void Execute()
        {
   
        }

        public void Hold()
        {
            ((IMario)WorldManager.ReturnPlayer()).Up();
        }

        public void Release()
        {
            ((IMario)WorldManager.ReturnPlayer()).ToIdle();
        }
    }
}
