using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.KoopaClasses
{
    public interface IKoopa : IGameObject
    {
        void Draw();
        void Update();
    }
}
