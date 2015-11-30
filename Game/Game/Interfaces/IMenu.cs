using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IMenu
    {
        IGameState Select();

        void Next();

        void Previous();

        void Draw(SpriteBatch spriteBatch);
    }
}
