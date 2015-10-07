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
        public ICollisionSide collisionSide;

        public MarioItemCollisionHandler(CollisionData collision) {
            collidingMario = (MarioInstance)collision.gameObjectA;
            collidingItem = (IItem)collision.gameObjectB;
            collisionSide = collision.collisionSide;
        }

        
        
    }
}
