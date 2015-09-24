﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses.GoombaStates
{
    public interface IGoombaState
    {
        void SmashGoomba();
        void DirectionChangeGoomba();
        void FlipGoomba();
    }
}
