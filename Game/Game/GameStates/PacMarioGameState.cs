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
        private bool hasPlayedEndTheme;

        public PacMarioGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PacMarioControls(game)));
            controllerList.Add(new GamePadController(new PacMarioControls(game)));
            isUnderground = false;
            hasPlayedEndTheme = false;
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
            if (delay == IGameStateConstants.UPDATEDELAY && !didPacMarioWin() && !isPacMarioDead())
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

            if (didPacMarioWin() && !isPacMarioDead())
            {
                if (deathTimer == IGameStateConstants.PACMARIOVICTORYTIMER)
                {
                    LifeManager.DecrementLives();
                    CollisionManager.Update(this);
                    camera.Update(WorldManager.ReturnPlayer());
                    game.gameState = prevGameState;
                    game.gameState.LoadContent();
                    deathTimer = 0;
                }
                deathTimer++;
            }
            else if (isPacMarioDead() && !didPacMarioWin())
            {
                if (deathTimer == IGameStateConstants.PACMARIODEATHTIMER)
                {
                    LifeManager.DecrementLives();
                    CollisionManager.Update(this);
                    camera.Update(WorldManager.ReturnPlayer());
                    game.gameState = prevGameState;
                    game.gameState.LoadContent();
                    deathTimer = 0;
                }
                deathTimer++;
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
            BackgroundThemeManager.PlayPacManLevelTheme();
        }

        private bool didPacMarioWin()
        {
            if (((HUDManager.CurrentAmountOfCoins() - IGameStateConstants.TOTALPACLEVELCOINS) == initialCoins) && !hasPlayedEndTheme)
            {
                BackgroundThemeManager.PlayPacManEndTheme();
                hasPlayedEndTheme = true;
            }
            return (HUDManager.CurrentAmountOfCoins() - IGameStateConstants.TOTALPACLEVELCOINS) == initialCoins;
        }
        private bool isPacMarioDead()
        {
            return (((IMario)WorldManager.ReturnPlayer()).MarioState is PacMarioDeadState);
        }
    }
}
