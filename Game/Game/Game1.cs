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
using Game.Enemies.GreenKoopaClasses;

namespace Game
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        private List<IController> controllerList;

        public IItem coin;
        public IItem flower;
        public IItem redMushroom;
        public IItem greenMushroom;
        public IItem star;

        public MarioInstance mario;

        public Block brickBlock;
        public Block hiddenBlock;
        public Block questionBlock;
        public ISprite solidBlock;
        public ISprite breakingBlock;

        public Goomba goomba;
        public GreenKoopa greenKoopa;


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

            coin = new Coin(this);
            flower = new Flower(this);
            greenMushroom = new GreenMushroom(this);
            redMushroom = new RedMushroom(this);
            star = new Star(this);

            mario = new MarioInstance(this);

            brickBlock = new Block(1, this);
            hiddenBlock = new Block(2, this);
            questionBlock = new Block(3, this);
            solidBlock = TileSpriteFactory.CreateSolidBlockSprite(this);
            breakingBlock = TileSpriteFactory.CreateBreakingBlockSprite(this);

            goomba = new Goomba(this);
            greenKoopa = new GreenKoopa(this);
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

            mario.Update();

            goomba.Update();
            greenKoopa.Update();

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

            mario.Draw();

            brickBlock.Draw();
            hiddenBlock.Draw();
            questionBlock.Draw();


            goomba.Draw();
            greenKoopa.Draw();
        }
    }
}
