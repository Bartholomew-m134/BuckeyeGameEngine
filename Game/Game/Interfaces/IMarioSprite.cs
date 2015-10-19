using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Game.Interfaces;

namespace Game.Interfaces
{
    public interface IMarioSprite : ISprite
    {

        void StarDraw(SpriteBatch spriteBatch, Vector2 location);
        

    }
}
