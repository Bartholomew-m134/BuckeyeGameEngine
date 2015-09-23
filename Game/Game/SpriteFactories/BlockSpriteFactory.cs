using Game.Blocks.BlockSprites;
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

        public static ISprite CreateQuestionBlockSprite(Game1 game)
        {
            return new QuestionBlockSprite(blockSpriteSheet, game);
        }

        public static ISprite CreateBrickBlockSprite(Game1 game)
        {
            return new BrickBlockSprite(blockSpriteSheet, game);
        }

        public static ISprite CreateUsedBlockSprite(Game1 game)
        {

        }


    }
}
