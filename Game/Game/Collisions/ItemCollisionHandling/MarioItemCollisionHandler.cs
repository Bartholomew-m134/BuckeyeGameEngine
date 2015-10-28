using Game.Interfaces;
using Game.Items;
using Game.Mario;
using Game.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions.ItemCollisionHandling
{
    public class MarioItemCollisionHandler
    {
        private IMario collidingMario;
        private IItem collidingItem;
  

        public MarioItemCollisionHandler(CollisionData collision) {
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
                    collidingItem.Disappear();
                    
                }
                else if (collidingItem is Flower)
                {
                    collidingItem.Disappear();
                    collidingMario.Flower();
                }
                else if (collidingItem is GreenMushroom)
                {
                    collidingItem.Disappear();
                }
                else if (collidingItem is RedMushroom)
                {
                    collidingItem.Disappear();
                    collidingMario.Mushroom();
                }
                else if (collidingItem is Star)
                {
                    collidingItem.Disappear();
                    collidingMario.Star();
                }
            }
        }
        public void HandleScore()
        {
            if(collidingItem is Coin && !collidingItem.IsInsideBlock){
                ScoreManager.IncreaseScore(200);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is RedMushroom && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(1000);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is GreenMushroom && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(1000);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is Star && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(1000);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
            else if (collidingItem is Flower && !collidingItem.IsInsideBlock)
            {
                ScoreManager.IncreaseScore(1000);
                ScoreManager.location = collidingItem.VectorCoordinates;
            }
        }
        
    }
}
