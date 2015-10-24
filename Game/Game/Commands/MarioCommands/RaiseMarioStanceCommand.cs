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
            if (WorldManager.GetMario().Physics.Velocity.Y < 2)
            {
                WorldManager.GetMario().Jump();
            }
        }

        public void Release()
        {
            if (WorldManager.GetMario().Physics.Velocity.Y < 0)
            {
                WorldManager.GetMario().Physics.ResetY();
            }
        }
    }
}
