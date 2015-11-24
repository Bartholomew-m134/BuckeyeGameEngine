using Game.Interfaces;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.GameStates
{
    public class VictoryScreenGameState : IGameState
    {
        private Game1 game;
        private List<IController> controllerList;
        private SpriteFont font;

        public VictoryScreenGameState(Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
        }

        public void LoadContent()
        {
            font = SpriteFactories.MenuSpriteFactory.CreateHUDFont();
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
            spriteBatch.Begin();
            spriteBatch.DrawString(font, IGameStateConstants.VICTORYSCREENGAMESTATECONGRATSMESSAGE, IGameStateConstants.VICTORYSCREENGAMESTATECONGRATSMESSAGELOCATION, Color.White);
            spriteBatch.DrawString(font, IGameStateConstants.VICTORYSCREENGAMESTATESTARTMESSAGE, IGameStateConstants.VICTORYSCREENGAMESTATESTARTMESSAGELOCATION, Color.White);
            spriteBatch.End();
        }

        public void StartButton()
        {
            game.gameState = new MenuGameState(game);
            game.gameState.LoadContent();
        }

        public void PipeTransition(IPipe warpPipe)
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


        public void StateBackgroundTheme()
        {
        }
    }
}
