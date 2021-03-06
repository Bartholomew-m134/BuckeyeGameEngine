﻿using Game.Collisions;
using Game.Mario;
using Game.Interfaces;
using Game.Mario.MarioStates;
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
using Game.Music;

namespace Game.GameStates
{
    public class NormalMarioGameState : IGameState
    {
        private Game1 game;
        private ICamera camera;
        private List<IController> controllerList;
        private int delay;
        private bool isUnderground;

        public NormalMarioGameState(Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new MarioControls(game)));
            controllerList.Add(new GamePadController(new MarioControls(game)));
            isUnderground = false;
        }

        public void LoadContent()
        {
            ItemsSpriteFactory.Load(game.Content);
            EnemySpriteFactory.Load(game.Content);
            MarioSpriteFactory.Load(game.Content);
            TileSpriteFactory.Load(game.Content);
            ProjectileSpriteFactory.Load(game.Content);
            BackgroundElementsSpriteFactory.Load(game.Content);

            WorldManager.LoadListFromFile(IGameStateConstants.NORMALMARIOWORLD, game);

            camera = new MarioCamera(WorldManager.ReturnPlayer().VectorCoordinates);

        }


        public void UnloadContent()
        {
            
        }

        public void Update()
        {
            HUDManager.UpdateHUDMarioString(HUDConstants.MARIOHUDSTRING);
            if (delay == IGameStateConstants.UPDATEDELAY)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update(camera);
                CollisionManager.Update(this);
                camera.Update(WorldManager.ReturnPlayer());
                ScoreManager.Update();
                HUDManager.Update();
                delay = 0;
            }
            else
            {
                delay++;
            }

            if (HUDManager.OutOfTime)
                ((IMario)WorldManager.ReturnPlayer()).MarioState = new DeadMarioState((IMario)WorldManager.ReturnPlayer());
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isUnderground)
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
            game.gameState = new PipeTransitioningGameState(camera, warpPipe, game);
        }
        public void FlagPoleTransition()
        {
            game.gameState = new FlagPoleVictoryGameState(camera, game);
        }

        public void PlayerDied()
        {
            game.gameState = new MarioDeathGameState(game);
        }

        public bool IsUnderground 
        {
            get { return isUnderground; }
            set { isUnderground = value; }
        }


        public void MarioPowerUp()
        {
            game.gameState = new MarioPowerUpGameState(camera, game);
        }

        public void StateBackgroundTheme()
        {
            BackgroundThemeManager.PlayOverWorldTheme();
        }
    }
}
