using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GoombaClasses
{
    public interface IGoomba : IGameObject
    {
        void Draw();
        void Update();
    }
}
