﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public interface ICommand
    {
        void Execute();

        void Release();
    }
}
