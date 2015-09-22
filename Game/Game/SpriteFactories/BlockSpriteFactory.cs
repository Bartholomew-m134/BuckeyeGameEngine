using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    public static class BlockSpriteFactory
    {
        private static Texture2D blockSpriteSheet;

        public static void Load(ContentManager content, GraphicsDevice device)
        {
            blockSpriteSheet = content.Load<Texture2D>("MarioTilesSpriteSheet");
        }

        public static void Unload()
        {

        }
    }
}
