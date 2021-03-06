﻿using Game.Interfaces;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
using Game.Utilities;

namespace Game.GameStates
{
    public class GameOverGameState : IGameState
    {
        private Game1 game;
        private const int DeathSoundDelay = 80;
        private List<IController> controllerList;
        private SpriteFont font;
        private int gameOverSoundDelay = 0;

        public GameOverGameState(Game1 game)
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
            if (gameOverSoundDelay == DeathSoundDelay)
                Game.SoundEffects.SoundEffectManager.GameOverEffect();
            foreach (IController controller in controllerList)
                controller.Update();
            gameOverSoundDelay++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScreenScaler.ScalingMatrix);
            spriteBatch.DrawString(font, IGameStateConstants.GAMEOVERSTATEMESSAGE, IGameStateConstants.GAMEOVERSTATEMESSAGELOCATION, Color.White);
            spriteBatch.End();
        }

        public void StartButton()
        {
            game.gameState = new LogoGameState(game);
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
