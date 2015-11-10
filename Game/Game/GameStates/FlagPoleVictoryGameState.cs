using Game.Interfaces;
using Game.Mario.MarioStates;
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
    public class FlagPoleVictoryGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private int timer = 0;
        private int updateDelay = 0;
        private List<IController> controllerList;
        private bool slidingDownPole = true;
        private bool hasJumpedOffPole = false;
        private bool hasWalkedIntoCastle = false;

        public FlagPoleVictoryGameState(Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            controllerList = new List<IController>();
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
            if(updateDelay == 5){
                if (slidingDownPole){
                    WorldManager.GetMario().MarioState.PoleSlide();
                    WorldManager.GetMario().Physics.Velocity = new Vector2(0,5);
                    WorldManager.GetMario().Update();
                    if (WorldManager.GetMario().VectorCoordinates.Y > 400){
                        slidingDownPole = false;
                        WorldManager.GetMario().MarioState.FlipAroundPole();

                    }
                }
                else if (timer >= 350 && timer < 600 && !(hasJumpedOffPole))
                {
                    WorldManager.GetMario().MarioState.Jump();
                    WorldManager.GetMario().Physics.Velocity = new Vector2(3,5);
                    WorldManager.GetMario().Update();
                    if (WorldManager.GetMario().VectorCoordinates.Y > 431)
                    {
                        hasJumpedOffPole = true;
                        WorldManager.GetMario().MarioState.FlipAroundPole();
                    }
                }
                else if (hasJumpedOffPole && !(slidingDownPole) && !(hasWalkedIntoCastle))
                {
                    WorldManager.GetMario().Physics.Velocity = new Vector2(5,0);
                    WorldManager.GetMario().Physics.Acceleration = new Vector2(0, 0);
                    WorldManager.GetMario().Update();
                    Console.WriteLine(WorldManager.GetMario().VectorCoordinates.X);
                    if (WorldManager.GetMario().VectorCoordinates.X>=3248)
                    {
                        hasWalkedIntoCastle = true;
                        WorldManager.GetMario().Physics.Velocity = new Vector2(0, 0);
                        WorldManager.GetMario().Physics.Acceleration = new Vector2(0, 0);
                        WorldManager.GetMario().Update();
                    }
                }
                else if (hasJumpedOffPole && !(slidingDownPole) && hasWalkedIntoCastle)
                {
                    WorldManager.GetMario().ToIdle();
                    WorldManager.GetMario().Physics.Velocity = new Vector2(0, 0);
                    WorldManager.GetMario().Physics.Acceleration = new Vector2(0, 0);
                    WorldManager.GetMario().Update();
                }

                    updateDelay = 0;
                }
                foreach (IController controller in controllerList)
                    controller.Update();
                timer++;
                updateDelay++;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            prevGameState.Draw(spriteBatch);
        }

        public void StartButton()
        {
            game.gameState = new PauseGameState(game);
        }


        public void PipeTransition(Vector2 warpLocation)
        {
            game.gameState = prevGameState;
        }
        public void FlagPoleTransition()
        {
            game.gameState = prevGameState;
        }


        public void PlayerDied()
        {
            
        }
    }
}
