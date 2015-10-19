﻿using Game.Interfaces;
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
            WorldManager.GetMario().Jump();
        }

        public void Release()
        {

        }
    }
}
