using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game
{
    public interface ISprite
    {
         void Update();

         void Draw(SpriteBatch spriteBatch, Vector2 location);

         Vector2 SpriteDimensions
         {
             get;
         }

    }
}
