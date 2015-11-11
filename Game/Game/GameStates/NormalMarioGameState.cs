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

namespace Game.GameStates
{
    public class NormalMarioGameState : IGameState
    {
        private Game1 game;
        public ICamera camera;
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

            WorldManager.LoadListFromFile("World1-1", game);

            camera = new MarioCamera(WorldManager.GetMario().VectorCoordinates);
        }


        public void UnloadContent()
        {
            
        }

        public void Update()
        {
            if (delay == 3)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update(camera);
                ScoreManager.Update();
                HUDManager.Update();
                delay = 0;
            }

            else
            {
                delay++;
            }
            if (HUDManager.OutOfTime)
            {
                WorldManager.GetMario().MarioState = new DeadMarioState(WorldManager.GetMario());
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isUnderground)
                game.GraphicsDevice.Clear(Color.DarkGray);
            WorldManager.Draw(camera);
            ScoreManager.DrawScore(spriteBatch, camera);
            HUDManager.DrawHUD(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(game);
        }


        public void PipeTransition(Vector2 warpLocation)
        {
            game.gameState = new PipeTransitioningGameState(warpLocation, game);
        }
        public void FlagPoleTransition()
        {
            game.gameState = new FlagPoleVictoryGameState(game);
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
    }
}
