using Game.Collisions;
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
    public class LemmingGameState : IGameState
    {
        private Game1 game;
        private ICamera camera;
        private List<IController> controllerList;
        private int delay;
        private bool isUnderground;

        public LemmingGameState(Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new LemmingControls(game)));
            controllerList.Add(new GamePadController(new LemmingControls(game)));
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
            LemmingSpriteFactory.Load(game.Content);

            WorldManager.LoadListFromFile(IGameStateConstants.LEMMINGWORLD, game);

            
            camera = new MarioCamera(WorldManager.ReturnLemming().VectorCoordinates);
        }


        public void UnloadContent()
        {

        }

        public void Update()
        {
            if (delay == IGameStateConstants.UPDATEDELAY)
            {
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update(camera);
                CollisionManager.Update(this);
                camera.Update(WorldManager.ReturnLemming());
                delay = 0;
            }
            else
            {
                delay++;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isUnderground)
                game.GraphicsDevice.Clear(Color.Black);
            WorldManager.Draw(camera);
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
            game.gameState = new VictoryScreenGameState(game);
            game.gameState.LoadContent();
        }

        public void PlayerDied()
        {
            game.gameState = new LemmingGameState(game);
            game.gameState.LoadContent();
        }

        public bool IsUnderground
        {
            get { return isUnderground; }
            set { isUnderground = value; }
        }


        public void MarioPowerUp()
        {
            
        }

        public void StateBackgroundTheme()
        {
            BackgroundThemeManager.PlayOverWorldTheme();
        }
    }
}
