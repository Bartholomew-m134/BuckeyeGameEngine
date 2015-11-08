using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.GameStates
{
    public class PauseGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private List<IController> controllerList;

        public PauseGameState(IGameState gameState, Game1 game)
        {
            this.game = game;
            prevGameState = gameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController());
        }

        public void LoadContent()
        {
            
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
            prevGameState.Draw(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = prevGameState;
        }
    }
}
