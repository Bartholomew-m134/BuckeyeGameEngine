using Game.Blocks.BlockSprites;
using Game.FlagPoles.FlagPoleSprites;
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
        private static Texture2D brickDebrisSpriteSheet;
        private static Texture2D scenerySpriteSheet;

        public static void Load(ContentManager content)
        {
            tileSpriteSheet = content.Load<Texture2D>("MarioTilesSpriteSheet");
            brickDebrisSpriteSheet = content.Load<Texture2D>("brickdebrissprite");
            scenerySpriteSheet = content.Load<Texture2D>("ScenarySpriteSheet");
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
        public static ISprite CreateBrickDebrisSprite()
        {
            return new BrickDebrisSprite(brickDebrisSpriteSheet);
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
            return new PipeSprite(scenerySpriteSheet);
        }
        public static ISprite CreateDoublePipeSprite()
        {
            return new DoublePipeSprite(scenerySpriteSheet);
        }
        public static ISprite CreateTriplePipeSprite()
        {
            return new TriplePipeSprite(scenerySpriteSheet);
        }
        public static ISprite CreateActiveFlagPoleSprite()
        {
            return new ActiveFlagPoleSprite(scenerySpriteSheet);
        }
        public static ISprite CreateInactiveFlagPoleSprite()
        {
            return new InactiveFlagPoleSprite(scenerySpriteSheet);
        }
    }
}
