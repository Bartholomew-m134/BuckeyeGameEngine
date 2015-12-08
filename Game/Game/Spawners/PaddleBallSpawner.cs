using Game.Interfaces;
using Game.ProjectMarioBrickBreaker.BallClasses;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Spawners
{
    public class PaddleBallSpawner
    {
        private Game1 game;
        

        public PaddleBallSpawner(Game1 game)
        {
            this.game = game;
        }

        public void RespawnPaddleBall(Vector2 location)
        {
            
                IPaddleBall paddleBall = new PaddleBall(game);
                Vector2 paddleCoordinates = new Vector2(location.X + PaddleBallConstants.PADDLESPAWNXOFFSET, location.Y - PaddleBallConstants.NORMALPADDLEBALLDIMENSIONS.Y);
                paddleBall.VectorCoordinates = paddleCoordinates;
                WorldManager.CreateNewObject(paddleBall);
             
           
        }
    }
}
