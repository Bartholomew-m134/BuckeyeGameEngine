using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockSprites
{
    public class BrickBlockSprite : ISprite
    {
        private Game1 game;
        private Texture2D spriteSheet;

        public BrickBlockSprite(Texture2D spriteSheet, Game1 game)
        {
            this.game = game;
            this.spriteSheet = spriteSheet;
        }

        public void Update()
        {
            
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Microsoft.Xna.Framework.Vector2 location)
        {
            
        }
    }
}
