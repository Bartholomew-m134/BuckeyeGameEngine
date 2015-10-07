﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Pipes
{
    public interface IPipe : IGameObject
    {
        void Update();

        void Draw();
    }
}