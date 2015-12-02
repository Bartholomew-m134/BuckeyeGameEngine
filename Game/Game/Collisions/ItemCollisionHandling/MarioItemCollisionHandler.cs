using Game.Interfaces;
using Game.Items;
using Game.Mario;
using Game.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.SoundEffects;
using Game.Utilities.Constants;
using Game.ProjectPacMario.PlayerClasses;

namespace Game.Collisions.ItemCollisionHandling
{
    public class MarioItemCollisionHandler
    {
        private IMario collidingMario;
        private IItem collidingItem;
        private IGameState gameState;
  

        public MarioItemCollisionHandler(CollisionData collision, IGameState gameState) 
        {
            this.gameState = gameState;

            if (collision.GameObjectA is IMario)
            {
                collidingMario = (IMario)collision.GameObjectA;
                collidingItem = (IItem)collision.GameObjectB;
            }
            else
            {
                collidingMario = (IMario)collision.GameObjectB;
                collidingItem = (IItem)collision.GameObjectA;
            }

        }

        public void HandleCollision() {
            HandleScore();
            if (!collidingItem.IsInsideBlock)
            {
                if (collidingItem is Coin)
                {
                    SoundEffectManager.CoinEffect();
                    collidingItem.Disappear();
                }
                else if (collidingItem is PacMarioCoin)
                {
                    SoundEffectManager.PacMarioChompEffect();
                    collidingItem.Disappear();
                    collidingMario.Star();
                }
                else if (collidingItem is PacMarioNormalCoin)
                {
                    SoundEffectManager.PacMarioChompEffect();
                    collidingItem.Disappear();
                }
                else if (collidingItem is Flower)
                {
                    collidingItem.Disappear();
                    collidingMario.Flower();
                    if(!collidingMario.IsFireMario())
                        gameState.MarioPowerUp();
                }
                else if (collidingItem is GreenMushroom)
                {
                    SoundEffectManager.OneUpEffect();
                    LifeManager.IncrementLives();
                    collidingItem.Disappear();
                }
                else if (collidingItem is RedMushroom)
                {
                    collidingItem.Disappear();
                    collidingMario.Mushroom();
                    if(!collidingMario.IsBigMario())
                        gameState.MarioPowerUp();
                }
                else if (collidingItem is Star)
                {
                    collidingItem.Disappear();
                    collidingMario.Star();
                }
                else if (collidingItem is PacMarioCoin)
                {
                    collidingItem.Disappear();
                    collidingMario.Star();
                }
            }
        }
        public void HandleScore()
        {
            ScoreManager.stompStreak = ScoreManagerConstants.RESETTOZERO;
            if(collidingItem is Coin && !collidingItem.IsInsideBlock || collidingItem is PacMarioNormalCoin){
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
