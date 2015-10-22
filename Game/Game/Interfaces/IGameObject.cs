﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Game.Interfaces;
using Game.Utilities;

namespace Game.Interfaces
{
    public interface IGameObject
    {
        void Update();

        void Draw();

        Vector2 VectorCoordinates
        {
            get;
            set;
        }

        ISprite GetSetSprite
        {
            get;
            set;
        }

        ObjectPhysics Physics
        {
            get;
        }

    }
}
