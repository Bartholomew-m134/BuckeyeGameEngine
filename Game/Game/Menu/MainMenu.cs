using Game.GameStates;
using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Menu
{
    public class MainMenu : IMenu
    {
        private enum Selections { MarioBros=0, ProjectBuckeye=1, Credits=2, FullScreen=3, Quit=4};

        private Game1 game;
        private Selections currentSelection;
        private SpriteFont font;

        public MainMenu(Game1 game)
        {
            this.game = game;
            currentSelection = Selections.MarioBros;
            font = MenuSpriteFactory.CreateHUDFont();
        }

        public void SelectChoice()
        {
            if (currentSelection == Selections.MarioBros)
            {
                game.gameState = new LoadingGameState(game);
                game.gameState.LoadContent();
                LifeManager.Lives = IGameStateConstants.MENUGAMESTATELIVES;
                ScoreManager.ResetScore();
                LifeManager.ResetLives();
                HUDManager.UpdateHUDScore(0);
                HUDManager.ResetCoins();
            }
            else if (currentSelection == Selections.ProjectBuckeye)
            {
                game.gameState = new ProjectBuckeyeGameState(game);
                game.gameState.LoadContent();
            }
            else if (currentSelection == Selections.Credits)
            {
                game.gameState = new CreditsGameState(game.gameState, game);
                game.gameState.LoadContent();
            }
            else if (currentSelection == Selections.FullScreen)
            {
                ToggleFullScreen();
            }
            else
            {
                game.Exit();
            }
        }

        public void NextChoice()
        {
            currentSelection++;
            if (((int)currentSelection) == Enum.GetNames(typeof(Selections)).Length)
                currentSelection = 0;
        }

        public void PreviousChoice()
        {
            currentSelection--;
            if (((int)currentSelection) < 0)
                currentSelection = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.DrawString(font, Selections.MarioBros.ToString(), new Vector2(25, 20), SelectColor(Selections.MarioBros));
            spriteBatch.DrawString(font, Selections.ProjectBuckeye.ToString(), new Vector2(25, 120), SelectColor(Selections.ProjectBuckeye));
            spriteBatch.DrawString(font, Selections.Credits.ToString(), new Vector2(25, 220), SelectColor(Selections.Credits));
            spriteBatch.DrawString(font, "FullScreen: " + game.graphics.IsFullScreen, new Vector2(25, 320), SelectColor(Selections.FullScreen));
            spriteBatch.DrawString(font, Selections.Quit.ToString(), new Vector2(25, 420), SelectColor(Selections.Quit));
            spriteBatch.End();
        }

        private Color SelectColor(Selections selected)
        {
            if (currentSelection == selected)
                return Color.White;
            else
                return Color.DarkGray;
        }

        private void ToggleFullScreen()
        {
            if (game.graphics.IsFullScreen)
            {
                game.graphics.PreferredBackBufferWidth = (int)ScreenConstants.DEFAULT_SCREEN_DIMENSIONS.X;
                game.graphics.PreferredBackBufferHeight = (int)ScreenConstants.DEFAULT_SCREEN_DIMENSIONS.Y;
            }
            else
            {
                game.graphics.PreferredBackBufferWidth = game.graphics.GraphicsDevice.DisplayMode.Width;
                game.graphics.PreferredBackBufferHeight = game.graphics.GraphicsDevice.DisplayMode.Height;
            }

            game.graphics.ToggleFullScreen();
            game.graphics.ApplyChanges();
        }
    }
}
