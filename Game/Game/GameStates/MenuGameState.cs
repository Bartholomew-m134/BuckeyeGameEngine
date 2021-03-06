﻿using Game.Interfaces;
using Game.Menu;
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
    public class MenuGameState : IGameState
    {
        private Game1 game;
        private List<IController> controllerList;
        private IMenu menu;
        private ISprite sprite;

        public MenuGameState(Game1 game)
        {
            this.game = game;
            menu = new MainMenu(game);
            sprite = MenuSpriteFactory.CreateMainMenuBackgroundSprite();
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new MenuControls(menu, game)));
            controllerList.Add(new GamePadController(new MenuControls(menu, game)));
        }

        public void LoadContent()
        {
            MenuSpriteFactory.Load(game.Content);
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
            menu.Draw(spriteBatch);
        }

        public void StartButton()
        {
            menu.SelectChoice();
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

        public void MarioPowerUp()
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

        public void StateBackgroundTheme()
        {
            
        }
    }
}
