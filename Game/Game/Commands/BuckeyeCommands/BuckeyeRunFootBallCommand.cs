﻿using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.BuckeyeCommands
{
    public class BuckeyeRunFootBallCommand : ICommand
    {
        public BuckeyeRunFootBallCommand()
        {
        }

        public void Execute()
        {
            if(((IBuckeyePlayer)WorldManager.ReturnPlayer()).IsDead == false)
                ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Toss();
        }

        public void Hold()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).Run();
        }

        public void Release()
        {
            ((IBuckeyePlayer)WorldManager.ReturnPlayer()).StopRunning();
        }
    }
}
