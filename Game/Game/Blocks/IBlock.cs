using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game;
using Microsoft.Xna.Framework;

namespace Game.Blocks
{
    public interface IBlock : IGameObject
    {
          void Update();

          void Draw();

          Vector2 VectorCoordinates
          {
              get;
              set;
          }

          ISprite GetSprite
          {
              get;
          }

          void Disappear();

          void GetUsed();
    }
}
