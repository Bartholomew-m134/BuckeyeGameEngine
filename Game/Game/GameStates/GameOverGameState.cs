using Game.Interfaces;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.GameStates
{
    public class GameOverGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private List<IController> controllerList;
        private SpriteFont font;

        public GameOverGameState(Game1 game)
        {
            this.game = game;
            Game.SoundEffects.SoundEffectManager.GameOverEffect();
            prevGameState = game.gameState;
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
            spriteBatch.DrawString(font, "Game Over", new Vector2(320, 200), Color.White);
            spriteBatch.End();
        }

        public void StartButton()
        {
            game.gameState = new MenuGameState(game);
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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void MarioPowerUp()
        {
            throw new NotImplementedException();
        }
    }
}
