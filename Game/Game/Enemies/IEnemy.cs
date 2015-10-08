using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Enemies
{
    public interface IEnemy : IGameObject
    {
        void Draw();
        void Update();
        Vector2 VectorCoordinates
        {
            get;
            set;
        }
        ISprite GetSprite
        {
            get;
        }
    }
}
