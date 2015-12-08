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
        private int brickCount;
        private int ballCount;
        private int deathTimer;

        public MarioBrickBreakerGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new BrickBreakerControls(game)));
            controllerList.Add(new GamePadController(new BrickBreakerControls(game)));
            isUnderground = false;
            brickCount = IGameStateConstants.TOTALBRICKBREAKERBLOCKS;
            ballCount = IGameStateConstants.INITIALBALLCOUNT;
            
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
            HUDManager.UpdateBrickBreakerLives(ballCount);
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

            if (camera.IsBelowCamera(WorldManager.ReturnPaddleBall().VectorCoordinates)) 
            {
                ballCount--;
                WorldManager.FreeObject(WorldManager.ReturnPaddleBall());
                if (ballCount > 0)
                    ((IPaddle)WorldManager.ReturnPlayer()).RespawnPaddleBall();
                else 
                {

                    while (deathTimer != IGameStateConstants.PACMARIODEATHTIMER)
                    {
                        deathTimer++;
                    }
                    
                        camera.Update(WorldManager.ReturnPlayer());
                        game.gameState = prevGameState;
                        game.gameState.LoadContent();
                        
                    
                    
                }
                    
            }


            if (brickCount == 0) 
            {
                game.gameState = new MinigameVictoryScreenGameState(game);
                game.gameState.LoadContent();
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

        public int BrickBlockCount
        {
            get { return brickCount; }
            set { brickCount = value; }
        }

        public int BallCount
        {
            get { return ballCount; }
            set { ballCount = value; }
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
