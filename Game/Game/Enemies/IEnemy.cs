using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies
{
    public interface IEnemy : IGameObject
    {
        void Draw();
        void Update();
    }
}
