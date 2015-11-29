using Game.GameStates;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
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

        public MainMenu(Game1 game)
        {
            this.game = game;
            currentSelection = Selections.MarioBros;
        }

        public IGameState CurrentSelection()
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
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenDimensions.ScalingMatrix);

            spriteBatch.End();
        }
    }
}
