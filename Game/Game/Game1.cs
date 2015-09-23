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

namespace Game
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        private List<IController> controllerList;
        private IItem coin;
        private IItem flower;
        private IItem redMushroom;
        private IItem greenMushroom;
        private IItem star;

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

            coin = new Coin(this);
            flower = new Flower(this);
            greenMushroom = new GreenMushroom(this);
            redMushroom = new RedMushroom(this);
            star = new Star(this);
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

            coin.Update();
            flower.Update();
            greenMushroom.Update();
            redMushroom.Update();
            star.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);

            coin.Draw();
            flower.Draw();
            greenMushroom.Draw();
            redMushroom.Draw();
            star.Draw();
        }
    }
}
