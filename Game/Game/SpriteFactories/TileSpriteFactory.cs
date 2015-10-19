using Game.Blocks.BlockSprites;
using Game.Interfaces;
using Game.Pipes.PipeSprites;
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

        public static ISprite CreateQuestionBlockSprite()
        {
            return new QuestionBlockSprite(tileSpriteSheet);
        }

        public static ISprite CreateBrickBlockSprite()
        {
            return new BrickBlockSprite(tileSpriteSheet);
        }

        public static ISprite CreateUsedBlockSprite()
        {
            return new UsedBlockSprite(tileSpriteSheet);
        }

        public static ISprite CreateHiddenBlockSprite()
        {
            return new HiddenBlockSprite(tileSpriteSheet);
        }

        public static ISprite CreateSolidBlockSprite()
        {
            return new SolidBlockSprite(tileSpriteSheet);
        }

        public static ISprite CreateBreakingBlockSprite()
        {
            return new BreakingBlockSprite(tileSpriteSheet);
        }

        public static ISprite CreatePipeSprite()
        {
            return new PipeSprite(tileSpriteSheet);
        }
    }
}
