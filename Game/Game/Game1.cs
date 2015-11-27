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
using Game.GameStates;

namespace Game
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public IGameState gameState;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Window.AllowUserResizing = true;
            Window.Title = "BuckeyeGameEngine";
        }

        protected override void Initialize()
        {
            gameState = new MenuGameState(this);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            gameState.LoadContent();
        }

        protected override void UnloadContent()
        {
            gameState.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            ScreenDimensions.Update(graphics);
            gameState.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            gameState.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
