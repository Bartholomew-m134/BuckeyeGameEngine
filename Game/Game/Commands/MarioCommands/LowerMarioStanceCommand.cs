﻿using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class LowerMarioStanceCommand : ICommand
    {
        public LowerMarioStanceCommand()
        {
        }

        public void Execute()
        {
            
        }

        public void Hold()
        {
            ((IMario)WorldManager.ReturnPlayer()).Down();
        }

        public void Release()
        {
            ((IMario)WorldManager.ReturnPlayer()).Up();
        }
    }
}
