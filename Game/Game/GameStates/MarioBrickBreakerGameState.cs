using Game.Collisions;
using Game.Interfaces;
using Game.Music;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.GameStates
{
    public class MarioBrickBreakerGameState : IGameState
    {

        private Game1 game;
        private ICamera camera;
        private List<IController> controllerList;
        private IGameState prevGameState;
        private int delay;
        private bool isUnderground;
        

        public MarioBrickBreakerGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new BrickBreakerControls(game)));
            controllerList.Add(new GamePadController(new BrickBreakerControls(game)));
            isUnderground = false;
            
        }

        public void LoadContent()
        {
            MarioBrickBreakerSpriteFactory.Load(game.Content);
            

            WorldManager.LoadListFromFile(IGameStateConstants.BRICKBREAKER_WORLD, game);

            camera = new StillCamera();
        }

        public void UnloadContent()
        {
        }

        public void Update()
        {
            HUDManager.UpdateHUDMarioString(HUDConstants.BRICKBREAKERHUDSTRING);
            if (delay == IGameStateConstants.UPDATEDELAY)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update(camera);
                CollisionManager.Update(this);
                camera.Update(WorldManager.ReturnPlayer());
                delay = 0;
            }
            else
            {
                delay++;
            }
            
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            game.GraphicsDevice.Clear(Color.Black);
            WorldManager.Draw(camera);
            ScoreManager.DrawScore(spriteBatch, camera);
            HUDManager.DrawHUD(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(game);
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
            get { return isUnderground; }
            set { isUnderground = value; }
        }

        public void StateBackgroundTheme()
        {
            BackgroundThemeManager.PlayOverWorldTheme();
        }
    }
}
