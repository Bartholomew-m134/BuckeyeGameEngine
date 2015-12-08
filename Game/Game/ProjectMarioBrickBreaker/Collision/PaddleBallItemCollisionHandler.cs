using Game.Collisions;
using Game.GameStates;
using Game.Interfaces;
using Game.Items;
using Game.SoundEffects;
using Game.Utilities;
using Game.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.ProjectMarioBrickBreaker.Collision
{
    public class PaddleBallItemCollisionHandler
    {
        private IPaddleBall paddleBall;
        private IItem collidingItem;
        private ICollisionSide collisionSide;
        private IGameState brickBreakerGameState;

        public PaddleBallItemCollisionHandler(CollisionData collision, IGameState gameState)
        {
            brickBreakerGameState = gameState;
            collisionSide = (ICollisionSide)collision.CollisionSide;
            if (collision.GameObjectA is IPaddle)
            {
                paddleBall = (IPaddleBall)collision.GameObjectA;
                collidingItem = (IItem)collision.GameObjectB;
            }
            else
            {
                paddleBall = (IPaddleBall)collision.GameObjectB;
                collidingItem = (IItem)collision.GameObjectA;
                collisionSide = collisionSide.FlipSide();
            }
        }

        public void HandleCollision()
        {
            HandleScore();
            if (collidingItem is RedMushroom)
            {
                ((IPaddle)WorldManager.ReturnPlayer()).MushroomPowerUp();
                SoundEffectManager.PowerPlayerUpEffect();
                collidingItem.Disappear();
            }
            else if (collidingItem is GreenMushroom)
            {
                SoundEffectManager.OneUpEffect();
                ((MarioBrickBreakerGameState)brickBreakerGameState).BallCount++;
                collidingItem.Disappear();
            }
            else if (collidingItem is Coin) 
            {
                SoundEffectManager.CoinEffect();
                collidingItem.Disappear();
            }
            else if (collidingItem is Flower)
            {
                SoundEffectManager.PowerPlayerUpEffect();
                collidingItem.Disappear();
                paddleBall.ToSuperPaddleBall();
            }
            else if (collidingItem is Star) 
            {
                SoundEffectManager.PowerPlayerUpEffect();
                collidingItem.Disappear();
                paddleBall.ToFastPaddleBall();
            }
             
        }

        public void HandleScore()
        {
            ScoreManager.stompStreak = ScoreManagerConstants.RESETTOZERO;
            if (collidingItem is Coin && !collidingItem.IsInsideBlock || collidingItem is PacMarioNormalCoin)
            {
                HUDManager.UpdateHUDCoins(ScoreManagerConstants.ADDONECOIN);
                ScoreManager.IncreaseScore(ScoreManagerConstants.TWOHUNDREDPOINTS);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is RedMushroom && !collidingItem.IsInsideBlock || collidingItem is PacMarioCoin)
            {
                HUDManager.UpdateHUDCoins(ScoreManagerConstants.ADDONECOIN);
                ScoreManager.IncreaseScore(ScoreManagerConstants.ONETHOUSANDPOINTS);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is GreenMushroom && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(ScoreManagerConstants.ONETHOUSANDPOINTS);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is Star && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(ScoreManagerConstants.ONETHOUSANDPOINTS);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is Flower && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(ScoreManagerConstants.ONETHOUSANDPOINTS);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
        }
    }
}
