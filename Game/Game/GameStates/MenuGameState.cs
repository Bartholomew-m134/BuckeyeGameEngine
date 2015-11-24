﻿using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.GameStates
{
    public class MenuGameState : IGameState
    {
        private Game1 game;
        private ISprite startMenuSprite;
        private ISprite namesLogoSprite;
        private List<IController> controllerList;
        private int logoCounter = 0;

        public MenuGameState( Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new MenuControls(game)));
            controllerList.Add(new GamePadController(new MenuControls(game)));
        }

        public void LoadContent()
        {
            MenuSpriteFactory.Load(game.Content);
            startMenuSprite = MenuSpriteFactory.CreateStartSprite();
            namesLogoSprite = MenuSpriteFactory.CreateLogoSprite();
        }


        public void UnloadContent()
        {
            
        }

        public void Update()
        {
            foreach (IController controller in controllerList)
                controller.Update();

            logoCounter++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);
            if (logoCounter < IGameStateConstants.MENUGAMESTATELOGOCOUNTER)
                namesLogoSprite.Draw(game.spriteBatch, Vector2.Zero);
            else
                startMenuSprite.Draw(game.spriteBatch, Vector2.Zero);
        }


        public void StartButton()
        {
            game.gameState = new LoadingGameState(game);
            game.gameState.LoadContent();
            LifeManager.Lives = IGameStateConstants.MENUGAMESTATELIVES;
            ScoreManager.ResetScore();
            LifeManager.ResetLives();
            HUDManager.UpdateHUDScore(0);
            HUDManager.ResetCoins();
        }

        public void StartBuckeyeButton()
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
