using Game.Collisions;
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
using Game.Utilities.Constants;

namespace Game.GameStates
{
    public class FlagPoleVictoryGameState : IGameState
    {
        private Game1 game;
        private IGameState prevGameState;
        private int timer;
        private int updateDelay;
        private List<IController> controllerList;
        private bool slidingDownPole = true;
        private bool hasJumpedOffPole = false;
        private bool hasWalkedIntoCastle = false;
        private bool haveAddedTimePoints = false;
        private IMario tempMario;
        private ICamera camera;

        public FlagPoleVictoryGameState(ICamera camera, Game1 game)
        {
            this.game = game;
            prevGameState = game.gameState;
            this.camera = camera;
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
            tempMario = (IMario)WorldManager.ReturnPlayer();
            if(updateDelay == IGameStateConstants.UPDATEDELAY){
                if (slidingDownPole){
                    tempMario.MarioState.PoleSlide();
                    tempMario.Physics.Velocity = new Vector2(0, IGameStateConstants.POLESLIDEVELOCITY);
                    if (tempMario.VectorCoordinates.Y > IGameStateConstants.ENDPOLESLIDECOORDINATE)
                    {
                        slidingDownPole = false;
                        tempMario.MarioState.FlipAroundPole();

                    }
                }
                else if (timer >= IGameStateConstants.FLAGPOLESTATETIMERJUMPMIN && timer < IGameStateConstants.FLAGPOLESTATETIMERJUMPMAX && !(hasJumpedOffPole))
                {
                    tempMario.MarioState.Jump();
                    tempMario.Physics.Velocity = new Vector2(IGameStateConstants.FLAGPOLESTATEMARIOJUMPXVELOCITY, IGameStateConstants.FLAGPOLESTATEMARIOJUMPYVELOCITY);
                    if ((tempMario.VectorCoordinates.Y + tempMario.Sprite.SpriteDimensions.Y) > IGameStateConstants.FLAGPOLESTATEMARIOHASJUMPEDYCOORDINATE)
                    {
                        hasJumpedOffPole = true;
                        tempMario.MarioState.FlipAroundPole();
                    }
                }
                else if (hasJumpedOffPole && !(slidingDownPole) && !(hasWalkedIntoCastle))
                {
                    tempMario.Physics.Velocity = new Vector2(IGameStateConstants.FLAGPOLESTATEMARIOWALKINGTOWARDSCASTLEXVELOCITY, 0);
                    tempMario.Physics.Acceleration = new Vector2(0, 0);
                    if (tempMario.VectorCoordinates.X >= IGameStateConstants.FLAGPOLESTATECASTLEDOORXCOORDINATE)
                    {
                        hasWalkedIntoCastle = true;
                        tempMario.Physics.Velocity = new Vector2(0, 0);
                        tempMario.Physics.Acceleration = new Vector2(0, 0);
                    }
                    if (!haveAddedTimePoints)
                    {
                        ScoreManager.HandleRemainingTime();
                        HUDManager.SetTimeToZero();
                        haveAddedTimePoints = true;
                    }
                }
                else if (hasJumpedOffPole && !(slidingDownPole) && hasWalkedIntoCastle)
                {
                    tempMario.ToIdle();
                    tempMario.Physics.Velocity = new Vector2(0, 0);
                    tempMario.Physics.Acceleration = new Vector2(0, 0);
                    int victoryWaitTimer = IGameStateConstants.FLAGPOLESTATEVICTORYWAITTIMER;
                    while (victoryWaitTimer > 0)
                        victoryWaitTimer--;
                    game.gameState = new VictoryScreenGameState(game);
                    game.gameState.LoadContent();
                }

                    updateDelay = 0;
                    WorldManager.Update(camera);
                    CollisionManager.Update(this);
                    camera.Update(tempMario);
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
