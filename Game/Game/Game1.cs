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
using Game.Utilities;

namespace Game
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public ICamera camera;
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
            ProjectileSpriteFactory.Load(Content);
            BackgroundElementsSpriteFactory.Load(Content);

            WorldManager.LoadListFromFile("World1-1", this);

            camera = new MarioCamera(WorldManager.GetMario().VectorCoordinates);
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (delay == 3)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update(camera);
                ScoreManager.Update();
                HUDManager.Update();
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
            WorldManager.Draw(camera);
            ScoreManager.DrawScore(spriteBatch, camera);
            HUDManager.DrawHUD(spriteBatch, camera);
            base.Draw(gameTime);
        }
    }
}
