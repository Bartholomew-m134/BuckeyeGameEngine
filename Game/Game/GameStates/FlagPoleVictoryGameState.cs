using Game.Interfaces;
using Game.Mario;
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
        private bool haveAddedTimePoints = false;
        private IMario tempMario;

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
            tempMario = WorldManager.GetMario();
            if(updateDelay == 5){
                if (slidingDownPole){
                    tempMario.MarioState.PoleSlide();
                    tempMario.Physics.Velocity = new Vector2(0, 5);
                    if (tempMario.VectorCoordinates.Y > 400)
                    {
                        slidingDownPole = false;
                        tempMario.MarioState.FlipAroundPole();

                    }
                }
                else if (timer >= 350 && timer < 600 && !(hasJumpedOffPole))
                {
                    tempMario.MarioState.Jump();
                    tempMario.Physics.Velocity = new Vector2(3, 5);
                    if ((tempMario.VectorCoordinates.Y + tempMario.Sprite.SpriteDimensions.Y) > 448)
                    {
                        hasJumpedOffPole = true;
                        tempMario.MarioState.FlipAroundPole();
                    }
                }
                else if (hasJumpedOffPole && !(slidingDownPole) && !(hasWalkedIntoCastle))
                {
                    tempMario.Physics.Velocity = new Vector2(5, 0);
                    tempMario.Physics.Acceleration = new Vector2(0, 0);
                    if (tempMario.VectorCoordinates.X >= 3248)
                    {
                        hasWalkedIntoCastle = true;
                        tempMario.Physics.Velocity = new Vector2(0, 0);
                        tempMario.Physics.Acceleration = new Vector2(0, 0);
                    }
                }
                else if (hasJumpedOffPole && !(slidingDownPole) && hasWalkedIntoCastle)
                {
                    if (!haveAddedTimePoints){
                        ScoreManager.HandleRemainingTime();
                        haveAddedTimePoints = true;
                    }
                    tempMario.ToIdle();
                    tempMario.Physics.Velocity = new Vector2(0, 0);
                    tempMario.Physics.Acceleration = new Vector2(0, 0);
                }

                    updateDelay = 0;
                    WorldManager.Update(((NormalMarioGameState)prevGameState).camera);
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
    }
}
