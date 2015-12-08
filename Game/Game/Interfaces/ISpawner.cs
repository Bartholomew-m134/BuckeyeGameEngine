using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface ISpawner
    {
        void ReleaseProjectile();

        void ReturnProjectile();
    }
}
