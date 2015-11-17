using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Game.GameStates
{
    public class LoadingGameState : IGameState
    {
        private Game1 game;
        private List<IController> controllerList;
        private ISprite marioSprite;
        private SpriteFont font;

        public LoadingGameState(Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
        }

        public void LoadContent()
        {
            MenuSpriteFactory.Load(game.Content);
            MarioSpriteFactory.Load(game.Content);
            ItemsSpriteFactory.Load(game.Content);

            marioSprite = MarioSpriteFactory.CreateSmallRightIdleSprite();
            font = MenuSpriteFactory.CreateHUDFont();

            HUDManager.SetToStartingTime();
        }

        public void UnloadContent()
        {
        
        }

        public void Update()
        {
            foreach (IController controller in controllerList)
                controller.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);
            HUDManager.DrawHUD(spriteBatch);

            marioSprite.Draw(spriteBatch, IGameStateConstants.LOADINGGAMESTATEMARIOLOCATION);

            spriteBatch.Begin();
            spriteBatch.DrawString(font, IGameStateConstants.LOADINGGAMESTATEX + LifeManager.Lives, IGameStateConstants.LOADINGGAMESTATEMESSAGELOCATION, Color.White);
            spriteBatch.End();
        }


        public void StartButton()
        {
            game.gameState = new NormalMarioGameState(game);
            game.gameState.LoadContent();
        }


        public void PipeTransition(Vector2 warpLocation)
        {
            
        }
        public void FlagPoleTransition()
        {
        }


        public void PlayerDied()
        {
            
        }


        public bool IsUnderground
        {
            get
            {
                return false;
            }
            set
            {
                
            }
        }


        public void MarioPowerUp()
        {
         
        }

        public void StartBuckeyeButton()
        {
        }
    }
}
