using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game
{
    public interface IMarioSprite : ISprite
    {

        void StarDraw(SpriteBatch spriteBatch, Vector2 location);
        

    }
}
