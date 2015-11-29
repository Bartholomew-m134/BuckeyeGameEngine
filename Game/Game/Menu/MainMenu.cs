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
        private enum Selections { MarioBros, ProjectBuckeye, FullScreen };

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
            else
            {
                game.graphics.IsFullScreen = !game.graphics.IsFullScreen;
                game.graphics.ApplyChanges();
            }

            return gameState;
        }

        public void Next()
        {
            currentSelection++;
        }

        public void Previous()
        {
            currentSelection--;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);
            spriteBatch.DrawString(font, "MarioBros", IGameStateConstants.VICTORYSCREENGAMESTATECONGRATSMESSAGELOCATION, Color.White);
            spriteBatch.DrawString(font, "ProjectBuckeye", IGameStateConstants.VICTORYSCREENGAMESTATESTARTMESSAGELOCATION + new Vector2(0,100), Color.White);
            spriteBatch.DrawString(font, "FullScreen", IGameStateConstants.VICTORYSCREENGAMESTATESTARTMESSAGELOCATION + new Vector2(0, 200), Color.White);
            spriteBatch.End();
        }
    }
}
