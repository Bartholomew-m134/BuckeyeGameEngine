﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface ICamera
    {
        void Update(IGameObject player);

        Vector2 GetAdjustedPosition(Vector2 position);

        bool IsWithinBounds(Vector2 position);

        bool IsWithinUpdateZone(Vector2 position);

        bool IsLeftOfCamera(Vector2 position);
      
        bool IsRightOfCamera(Vector2 position);
      
        bool IsAboveCamera(Vector2 position);
        
        bool IsBelowCamera(Vector2 position);        

        bool LeftScrollingDisabled
        {
            get;
            set;
        }

        bool VerticalScrollingDisabled
        {
            get;
            set;
        }
    }
}