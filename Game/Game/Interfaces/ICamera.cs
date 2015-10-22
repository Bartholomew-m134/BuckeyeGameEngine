using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface ICamera
    {
        Vector2 GetAdjustedPosition(Vector2 position);

        bool IsWithinBounds(IGameObject gameObject);

        void AdjustCameraPosition(Vector2 adjustment);
    }
}
