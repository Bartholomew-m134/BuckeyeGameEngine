using Game.Items;
using Game.Mario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions.ItemCollisionHandling
{
    public class MarioItemCollisionHandler
    {
        private MarioInstance collidingMario;
        public IItem collidingItem;
  

        public MarioItemCollisionHandler(CollisionData collision) {
            if (collision.gameObjectA is IMario)
            {
                collidingMario = (MarioInstance)collision.gameObjectA;
                collidingItem = (IItem)collision.gameObjectB;
            }
            else
            {
                collidingMario = (MarioInstance)collision.gameObjectB;
                collidingItem = (IItem)collision.gameObjectA;
            }

        }

        public void HandleCollision() {
            if (collidingItem is Coin) {
                collidingItem.Disappear();
            }
            else if (collidingItem is Flower) {
                collidingItem.Disappear();
                collidingMario.Flower();
            }
            else if (collidingItem is GreenMushroom) {
                collidingItem.Disappear();
            }
            else if (collidingItem is RedMushroom) {
                collidingItem.Disappear();
                collidingMario.Mushroom();
            }
            else if (collidingItem is Star) {
                collidingItem.Disappear();
                collidingMario.Star();
            }
        }
        
    }
}
