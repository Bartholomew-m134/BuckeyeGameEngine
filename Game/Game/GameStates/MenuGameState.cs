using Game.Interfaces;
using Game.SpriteFactories;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.GameStates
{
    public class MenuGameState : IGameState
    {


        private Game1 game;
        private ISprite startMenuSprite;
        private ISprite namesLogoSprite;
        private List<IController> controllerList;
        private int logoCounter = 0;

        public MenuGameState( Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new MenuControls(game)));
            controllerList.Add(new GamePadController());
            startMenuSprite = BackgroundElementsSpriteFactory.CreateStartSprite();
            namesLogoSprite = BackgroundElementsSpriteFactory.CreateLogoSprite();
        }

        public void LoadContent()
        {
            BackgroundElementsSpriteFactory.Load(game.Content);
        }

        public void UnloadContent()
        {
            
        }

        public void Update()
        {
            foreach (IController controller in controllerList)
                controller.Update();

            logoCounter++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (logoCounter < 100)
                namesLogoSprite.Draw(game.spriteBatch, new Vector2(0, 0));
            else
                startMenuSprite.Draw(game.spriteBatch, new Vector2(0, 0));
        }


        public void StartButton()
        {
            throw new NotImplementedException();
        }
    }
}
