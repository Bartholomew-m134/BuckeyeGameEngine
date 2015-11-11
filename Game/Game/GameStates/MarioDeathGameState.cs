﻿using Game.Interfaces;
using Game.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (delay == 3)
            {
                WorldManager.GetMario().Update();

                if (timer.ElapsedMilliseconds > 1500)
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

        public void PipeTransition(Vector2 warpLocation)
        {

        }

        public void PlayerDied()
        {
            
        }


        public void FlagPoleTransition()
        {
            throw new NotImplementedException();
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
