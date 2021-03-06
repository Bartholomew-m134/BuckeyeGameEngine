﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Interfaces
{
    public interface IItem : IGameObject
    {
        bool IsInsideBlock { get; set; }

        void Disappear();

        void Release();

        void ReverseDirection();
    }
}
