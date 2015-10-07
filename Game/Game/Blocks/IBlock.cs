using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game;

namespace Game.Blocks
{
    public interface IBlock : IGameObject
    {
          void Update();

          void Draw();

          void Disappear();

          void GetUsed();
    }
}
