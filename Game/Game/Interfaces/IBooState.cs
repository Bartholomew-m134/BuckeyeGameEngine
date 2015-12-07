﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IBooState
    {
        void Die();

        void ChangeDirection();
    }
}