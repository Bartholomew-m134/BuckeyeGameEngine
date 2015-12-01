﻿using Game.Interfaces;
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
            WorldManager.ReturnPlayer().Up();
        }

        public void Release()
        {
            WorldManager.ReturnPlayer().ToIdle();
        }
    }
}
