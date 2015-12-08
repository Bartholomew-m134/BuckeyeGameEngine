using Game.Interfaces;
using Game.Music;
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
    public class CreditsGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private SpriteFont font;
        private ISprite sprite;
        private List<IController> controllerList;

        public CreditsGameState(IGameState prevGameState, Game1 game)
        {
            this.game = game;
            this.prevGameState = prevGameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
        }

        public void LoadContent()
        {
            MenuSpriteFactory.Load(game.Content);
            font = MenuSpriteFactory.CreateHUDFont();
            sprite = MenuSpriteFactory.CreateMainMenuBackgroundSprite();
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
            sprite.Draw(spriteBatch, Vector2.Zero);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);

            spriteBatch.DrawString(font, "Software Engineers: ", new Vector2(25, 20), Color.White);
            spriteBatch.DrawString(font, "Matt Bartholomew", new Vector2(55, 60), Color.DarkGray);
            spriteBatch.DrawString(font, "John Cramer", new Vector2(55, 100), Color.DarkGray);
            spriteBatch.DrawString(font, "Jackson Luken", new Vector2(55, 140), Color.DarkGray);
            spriteBatch.DrawString(font, "Kyle Powers", new Vector2(55, 180), Color.DarkGray);
            spriteBatch.DrawString(font, "Connor Swick", new Vector2(55, 220), Color.DarkGray);

            spriteBatch.DrawString(font, "Logo Designer: ", new Vector2(25, 280), Color.White);
            spriteBatch.DrawString(font, "Collin Mullet", new Vector2(55, 320), Color.DarkGray);

            spriteBatch.DrawString(font, "Music Director: ", new Vector2(25, 380), Color.White);
            spriteBatch.DrawString(font, "Nick Smith", new Vector2(55, 420), Color.DarkGray);
            spriteBatch.End();
        }


        public void StartButton()
        {
            game.gameState = prevGameState;
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
            set { }
        }


        public void MarioPowerUp()
        {

        }


        public void StateBackgroundTheme()
        {
        }
    }
}
