using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.GameStates
{
    public class PipeTransitioningGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private List<IController> controllerList;
        private int timer = 100;
        private Vector2 warpLocation;

        public PipeTransitioningGameState(Vector2 warpLocation, Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            this.warpLocation = warpLocation;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
            
        }

        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }

        public void Update()
        {
            if (timer > 0)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.GetMario().Update();
            }
            else
            {
                game.gameState = prevGameState;
                WorldManager.GetMario().VectorCoordinates = warpLocation;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            prevGameState.Draw(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(game);
        }


        public void PipeTransition(Vector2 warpLocation)
        {
            game.gameState = prevGameState;
        }
    }
}