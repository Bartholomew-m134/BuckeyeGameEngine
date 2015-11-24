using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;
namespace Game.GameStates
{
    public class MarioDeathGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private System.Diagnostics.Stopwatch timer;
        private int delay;
       public MarioDeathGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;

            timer = new System.Diagnostics.Stopwatch();
            timer.Start();
        }
        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }

        public void Update()
        {
            if (delay == IGameStateConstants.UPDATEDELAY)
            {
                WorldManager.ReturnPlayer().Update();

                if (timer.ElapsedMilliseconds > IGameStateConstants.MARIODEATHSTATETIMER)
                {
                    timer.Reset();
                    LifeManager.DecrementLives();

                    if (LifeManager.Lives > 0)
                    {
                        game.gameState = new LoadingGameState(game);
                        game.gameState.LoadContent();
                    }
                    else
                    {
                        game.gameState = new GameOverGameState(game);
                        game.gameState.LoadContent();
                    }
                }
                delay = 0;
            }
            else
                delay++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            prevGameState.Draw(spriteBatch);
        }

        public void StartButton()
        {

        }

        public void PipeTransition(IPipe warpPipe)
        {

        }

        public void PlayerDied()
        {
            
        }


        public void FlagPoleTransition()
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
