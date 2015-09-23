using Game.Blocks.BlockSprites;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.SpriteFactories
{
    public static class TileSpriteFactory
    {
        private static Texture2D tileSpriteSheet;

        public static void Load(ContentManager content, GraphicsDevice device)
        {
            tileSpriteSheet = content.Load<Texture2D>("MarioTilesSpriteSheet");
        }

        public static void Unload()
        {

        }

        public static ISprite CreateQuestionBlockSprite(Game1 game)
        {
            return new QuestionBlockSprite(tileSpriteSheet, game);
        }

        public static ISprite CreateBrickBlockSprite(Game1 game)
        {
            return new BrickBlockSprite(tileSpriteSheet, game);
        }

        public static ISprite CreateUsedBlockSprite(Game1 game)
        {
            return new UsedBlockSprite(tileSpriteSheet, game);
        }

        public static ISprite CreateHiddenBlockSprite(Game1 game)
        {
            return new HiddenBlockSprite(tileSpriteSheet, game);
        }


    }
}
