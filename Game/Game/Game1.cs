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
using Game.SpriteFactories;
using Game.Interfaces;

namespace Game
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        private List<IController> controllerList;
        private int delay;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            delay = 0;
        }

        protected override void Initialize()
        {
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController());
            controllerList.Add(new GamePadController());
            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ItemsSpriteFactory.Load(Content);
            EnemySpriteFactory.Load(Content);
            MarioSpriteFactory.Load(Content);
            TileSpriteFactory.Load(Content);
            BackgroundElementsSpriteFactory.Load(Content);

            WorldManager.LoadListFromFile("World1-1", this);
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (delay == 4)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update();
                base.Update(gameTime);
                delay = 0;
            }

            else
            {
                delay++;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            WorldManager.Draw();
            base.Draw(gameTime);
        }
    }
}
