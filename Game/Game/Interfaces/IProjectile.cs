using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IProjectile : IGameObject
    {

        void Explode();

        void Release(Vector2 location);

        void ReverseDirection();

        void Bounce();

    }
}
