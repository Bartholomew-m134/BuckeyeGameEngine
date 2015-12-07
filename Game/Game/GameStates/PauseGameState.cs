using Game.Interfaces;
using Game.Menu;
using Game.SpriteFactories;
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
    public class PauseGameState : IGameState
    {
        private IGameState prevGameState;
        private List<IController> controllerList;
        private IMenu menu;
        private ISprite sprite;

        public PauseGameState(Game1 game)
        {
            prevGameState = game.gameState;
            menu = new PauseMenu(prevGameState, game);
            sprite = MenuSpriteFactory.CreatePauseMenuSprite();
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new MenuControls(menu, game)));
            controllerList.Add(new GamePadController(new MenuControls(menu, game)));
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
            sprite.Draw(spriteBatch, new Vector2(120,80));
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
