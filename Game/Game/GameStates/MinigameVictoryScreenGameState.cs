using Game.Interfaces;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;
using Game.SpriteFactories;

namespace Game.GameStates
{
    public class MinigameVictoryScreenGameState : IGameState
    {
        private Game1 game;
        private List<IController> controllerList;
        private SpriteFont font;
        private ISprite messageBackground;

        public MinigameVictoryScreenGameState(Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
        }

        public void LoadContent()
        {
            font = SpriteFactories.MenuSpriteFactory.CreateHUDFont();
            messageBackground = MenuSpriteFactory.CreateMessageBackgroundSprite();
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
            messageBackground.Draw(spriteBatch, IGameStateConstants.MINIGAMEVICTORYSCREENGAMESTATEBACKGROUNDLOCATION);
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.DrawString(font, IGameStateConstants.MINIGAMEVICTORYSCREENGAMESTATECONGRATSMESSAGE, IGameStateConstants.MINIGAMEVICTORYSCREENGAMESTATECONGRATSMESSAGELOCATION, Color.White);
            spriteBatch.DrawString(font, IGameStateConstants.MINIGAMEVICTORYSCREENGAMESTATESTARTMESSAGE, IGameStateConstants.MINIGAMEVICTORYSCREENGAMESTATESTARTMESSAGELOCATION, Color.White);
            spriteBatch.End();
        }

        public void StartButton()
        {
            game.gameState = new ProjectBuckeyeGameState(game);
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

        public void StateBackgroundTheme()
        {
        }
    }
}
