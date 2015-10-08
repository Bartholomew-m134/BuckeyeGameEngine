using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game
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

    }
}
