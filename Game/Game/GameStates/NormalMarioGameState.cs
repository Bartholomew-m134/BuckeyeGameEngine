using Game.Interfaces;
using Game.SpriteFactories;
using Game.Utilities;
using Game.Utilities.Controls;
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
        private ICamera camera;
        private List<IController> controllerList;
        private int delay;

        public NormalMarioGameState(Game1 game)
        {
            this.game = game;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new MarioControls(game)));
            controllerList.Add(new GamePadController());
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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            WorldManager.Draw(camera);
            ScoreManager.DrawScore(spriteBatch, camera);
            HUDManager.DrawHUD(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(this, game);
        }
    }
}
