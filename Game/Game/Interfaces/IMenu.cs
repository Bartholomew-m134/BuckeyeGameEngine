using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IMenu
    {
        void SelectChoice();

        void NextChoice();

        void PreviousChoice();

        void Draw(SpriteBatch spriteBatch);
    }
}
