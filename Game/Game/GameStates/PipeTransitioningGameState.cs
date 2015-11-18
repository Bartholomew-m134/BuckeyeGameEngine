using Game.Collisions;
using Game.Interfaces;
using Game.Utilities;
using Game.Utilities.Constants;
using Game.Utilities.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Game.GameStates
{
    public class PipeTransitioningGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private List<IController> controllerList;
        private int timer;
        private Vector2 warpLocation;
        private ICamera camera;

        public PipeTransitioningGameState(ICamera camera, Vector2 warpLocation, Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            this.warpLocation = warpLocation;
            this.camera = camera;
            WorldManager.ReturnPlayer().Physics.ResetX();
            WorldManager.ReturnPlayer().Physics.ResetY();
            controllerList = new List<IController>();
            timer = IGameStateConstants.PIPETRANSITIONINGGAMESTATETIMER;
            controllerList.Add(new KeyboardController(new PausedControls(game)));
            controllerList.Add(new GamePadController(new PausedControls(game)));
            
            
        }

        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }

        public void Update()
        {
            if (timer > 0)
            {
                foreach (IController controller in controllerList)
                    controller.Update();
                if (prevGameState.IsUnderground) {
                    WorldManager.ReturnPlayer().Physics.Acceleration = new Vector2(0, 0);
                    WorldManager.ReturnPlayer().Physics.Velocity = new Vector2(IGameStateConstants.PIPETRANSITIONINGGGAMESTATEMARIOXVELOCITY, 0);
                }
                else { 
                WorldManager.ReturnPlayer().Physics.Velocity = new Vector2(0, IGameStateConstants.PIPETRANSITIONINGGGAMESTATEMARIOYVELOCITY);
                }
                WorldManager.ReturnPlayer().Update();
                timer--;
            }
            else
            {
                
                game.gameState = prevGameState;
    
                WorldManager.ReturnPlayer().VectorCoordinates = warpLocation;
                CollisionManager.Update(this);
                camera.Update(WorldManager.ReturnPlayer());

                prevGameState.IsUnderground = !prevGameState.IsUnderground;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            prevGameState.Draw(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(game);
        }


        public void PipeTransition(Vector2 warpLoc)
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

        public void StartBuckeyeButton()
        {
        }
    }
}