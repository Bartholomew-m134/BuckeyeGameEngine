using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IBlockSprite : ISprite
    {
        void BumpDraw(SpriteBatch spriteBatch, Vector2 location);
    }
}
