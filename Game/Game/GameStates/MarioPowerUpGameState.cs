using Game.Collisions;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utilities.Constants;

namespace Game.GameStates
{
    public class MarioPowerUpGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private List<IController> controllerList;
        private int timer;
        private int delay;
        private ICamera camera;

        public MarioPowerUpGameState(ICamera camera, Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            this.camera = camera;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));

            WorldManager.ReturnPlayer().Physics.Acceleration = Vector2.Zero;
            WorldManager.ReturnPlayer().Physics.Velocity = Vector2.Zero;
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
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.ReturnPlayer().Update();
                CollisionManager.Update(this);
                camera.Update(WorldManager.ReturnPlayer());

                if (timer > IGameStateConstants.MARIOPOWERUPSTATETIMER)
                {
                    WorldManager.ReturnPlayer().Physics.ResetPhysics();
                    game.gameState = prevGameState;
                }
                timer++;
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
