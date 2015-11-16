using Game.Interfaces;
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
            if(!WorldManager.GetMario().IsPressingDown())
                WorldManager.GetMario().Jump();
        }

        public void Release()
        {
            WorldManager.GetMario().StopJumping();
        }
    }
}
