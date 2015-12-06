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
        private enum Selections { MarioBros=0, ProjectBuckeye=1, FullScreen=2, Quit=3};

        private Game1 game;
        private Selections currentSelection;
        private SpriteFont font;

        public MainMenu(Game1 game)
        {
            this.game = game;
            currentSelection = Selections.MarioBros;
            font = MenuSpriteFactory.CreateHUDFont();
        }

        public IGameState Select()
        {
            IGameState gameState = null;

            if (currentSelection == Selections.MarioBros)
            {
                gameState = new NormalMarioGameState(game);
            }
            else if (currentSelection == Selections.ProjectBuckeye)
            {
                gameState = new ProjectBuckeyeGameState(game);
            }
            else if (currentSelection == Selections.FullScreen)
            {
                ToggleFullScreen();
            }
            else
            {
                game.Exit();
            }

            return gameState;
        }

        public void Next()
        {
            currentSelection++;
            if (((int)currentSelection) == Enum.GetNames(typeof(Selections)).Length)
                currentSelection = 0;
        }

        public void Previous()
        {
            currentSelection--;
            if (((int)currentSelection) < 0)
                currentSelection = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.DrawString(font, "MarioBros", new Vector2(25, 100), SelectColor(Selections.MarioBros));
            spriteBatch.DrawString(font, "ProjectBuckeye", new Vector2(25, 200), SelectColor(Selections.ProjectBuckeye));
            spriteBatch.DrawString(font, "FullScreen: " + game.graphics.IsFullScreen, new Vector2(25, 300), SelectColor(Selections.FullScreen));
            spriteBatch.DrawString(font, "Quit", new Vector2(25, 400), SelectColor(Selections.Quit));
            spriteBatch.End();
        }

        private Color SelectColor(Selections selected)
        {
            if (currentSelection == selected)
                return Color.Yellow;
            else
                return Color.White;
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
