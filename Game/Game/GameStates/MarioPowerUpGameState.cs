using Game.Interfaces;
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
    public class MarioPowerUpGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private List<IController> controllerList;
        ObjectPhysics storedPhysics;
        private int timer;
        private int delay;
        ICamera camera;
        public MarioPowerUpGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            controllerList = new List<IController>();
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
            camera = ((NormalMarioGameState)prevGameState).camera;
            storedPhysics = WorldManager.GetMario().Physics;

            WorldManager.GetMario().Physics.Acceleration = Vector2.Zero;
            WorldManager.GetMario().Physics.Velocity = Vector2.Zero;
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
                foreach (IController controller in controllerList)
                    controller.Update();

                WorldManager.Update(camera);

                if (timer > 10)
                {
                    game.gameState = prevGameState;

                    WorldManager.GetMario().Physics.ResetPhysics();
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
            game.gameState = prevGameState;
        }


        public void PipeTransition(Vector2 warpLocation)
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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void MarioPowerUp()
        {
            
        }
    }
}
