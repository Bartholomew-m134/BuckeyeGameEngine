using System;
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

        void Draw(ICamera camera);

        Vector2 VectorCoordinates
        {
            get;
            set;
        }

        ISprite Sprite
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
