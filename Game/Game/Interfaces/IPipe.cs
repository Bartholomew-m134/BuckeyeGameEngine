﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Interfaces
{
    public interface IPipe : IGameObject
    {
        public Vector2 WarpVectorCoordinates
        {
            get;

        }
    }
}