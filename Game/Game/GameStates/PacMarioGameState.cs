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
using Game.ProjectPacMario.PlayerClasses;
using Game.ProjectPacMario.PlayerClasses.PlayerStates;

namespace Game.GameStates
{
    public class PacMarioGameState : IGameState
    {
        private Game1 game;
        private ICamera camera;
        private List<IController> controllerList;
        private IGameState prevGameState;
        private int delay;
        private bool isUnderground;
        private int deathTimer;
        private int initialCoins;

        public PacMarioGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PacMarioControls(game)));
            controllerList.Add(new GamePadController(new PacMarioControls(game)));
            isUnderground = false;
            initialCoins = HUDManager.CurrentAmountOfCoins();
        }

        public void LoadContent()
        {
            ItemsSpriteFactory.Load(game.Content);
            EnemySpriteFactory.Load(game.Content);
            TileSpriteFactory.Load(game.Content);
            PacMarioSpriteFactory.Load(game.Content);
            BackgroundElementsSpriteFactory.Load(game.Content);

            WorldManager.LoadListFromFile(IGameStateConstants.PACMARIO_WORLD, game);

            camera = new StillCamera();
        }

        public void UnloadContent()
        {
        }

        public void Update()
        {
            HUDManager.UpdateHUDMarioString(HUDConstants.PACMARIOHUDSTRING);
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
            if ((HUDManager.CurrentAmountOfCoins() - IGameStateConstants.TOTALPACLEVELCOINS) == initialCoins){
                Console.WriteLine("all done");
            }
            /*if (((PacMario)WorldManager.ReturnPlayer()).MarioState is PacMarioDeadState)
            {
                if (deathTimer == 50)
                {
                    game.gameState = prevGameState;
                    WorldManager.ReturnPlayer().VectorCoordinates = new Vector2(0, 0);
                    CollisionManager.Update(this);
                    camera.Update(WorldManager.ReturnPlayer());
                }
                deathTimer++;
            }
             */
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
            BackgroundThemeManager.PlayPacManLevelTheme();
        }
    }
}
