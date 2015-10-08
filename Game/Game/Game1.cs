using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Game.Items;
using Game.SpriteFactories;
using Game.Mario;
using Game.Blocks;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Pipes;

namespace Game
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        //public ISprite solidBlock;
        //public ISprite breakingBlock;

        private List<IController> controllerList;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(this));
            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ItemsSpriteFactory.Load(Content, GraphicsDevice);
            EnemySpriteFactory.Load(Content, GraphicsDevice);
            MarioSpriteFactory.Load(Content, GraphicsDevice);
            TileSpriteFactory.Load(Content, GraphicsDevice);

            WorldManager.LoadListFromFile("", this);

            //solidBlock = TileSpriteFactory.CreateSolidBlockSprite();
            //breakingBlock = TileSpriteFactory.CreateBreakingBlockSprite();

        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllerList)
            {
                controller.Update();
            }

            WorldManager.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);

            WorldManager.Draw();

            //solidBlock.Draw(spriteBatch, new Vector2(100,200));
            //breakingBlock.Draw(spriteBatch, new Vector2(500,200));
        }
    }
}
