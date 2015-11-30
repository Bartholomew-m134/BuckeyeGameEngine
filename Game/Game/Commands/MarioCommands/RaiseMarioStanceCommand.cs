using Game.Interfaces;
using Game.Mario;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class RaiseMarioStanceCommand : ICommand
    {
        public RaiseMarioStanceCommand()
        {
        }

        public void Execute()
        {
   
        }

        public void Hold()
        {
            WorldManager.ReturnPlayer().Jump();
        }

        public void Release()
        {
            WorldManager.ReturnPlayer().StopJumping();
        }
    }
}
