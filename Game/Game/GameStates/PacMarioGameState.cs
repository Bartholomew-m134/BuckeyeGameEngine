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
using Game.Music;

namespace Game.GameStates
{
    public class PacMarioGameState : IGameState
    {
        private Game1 game;
        private ICamera camera;
        private List<IController> controllerList;
        private int delay;
        private bool isUnderground;

        public PacMarioGameState(Game1 game)
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
            TileSpriteFactory.Load(game.Content);
            BackgroundElementsSpriteFactory.Load(game.Content);

            WorldManager.LoadListFromFile(IGameStateConstants.PACMARIO_WORLD, game);

            camera = new StillCamera();
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

        public void StartBuckeyeButton()
        {
        }


        public void StateBackgroundTheme()
        {
            BackgroundThemeManager.PlayPacManLevelTheme();
        }
    }
}
