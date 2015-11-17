using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Interfaces;
using Game.Utilities.Constants;
using Game.Collisions;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game.GameStates;

namespace Game.GameStates
{
    public class ProjectBuckeyeGameState : IGameState
    {
        private Game1 game;
        private ICamera camera;
        private List<IController> controllerList;
        private int delay;
        private bool isUnderground;

        public ProjectBuckeyeGameState(Game1 game)
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
            BuckeyePlayerSpriteFactory.Load(game.Content);
            TileSpriteFactory.Load(game.Content);
            ProjectileSpriteFactory.Load(game.Content);
            BackgroundElementsSpriteFactory.Load(game.Content);

            WorldManager.LoadListFromFile(IGameStateConstants.PROJECT_BUCKEYE_TEST_WORLD, game);

            camera = new MarioCamera(WorldManager.GetPlayer().VectorCoordinates);
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
                camera.Update(WorldManager.GetPlayer());
                delay = 0;
            }
            else
            {
                delay++;
            }
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            WorldManager.Draw(camera);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(game);
        }

        public void PipeTransition(Microsoft.Xna.Framework.Vector2 warpLocation)
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

        public void StartBuckeyeButton()
        {
        }
    }
}
