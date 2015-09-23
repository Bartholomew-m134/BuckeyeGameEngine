using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks.BlockSprites
{
    public class QuestionBlockSprite : ISprite
    {
        private Game1 game;
        private Texture2D spriteSheet;

        public QuestionBlockSprite(Texture2D spriteSheet, Game1 game)
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
