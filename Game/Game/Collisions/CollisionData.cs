using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public class CollisionData
    {
        public IGameObject gameObjectA;
        public IGameObject gameObjectB;
        public ICollisionSide collisionSide;

        public CollisionData(IGameObject objectA, IGameObject objectB, ICollisionSide side) {
            gameObjectA = objectA;
            gameObjectB = objectB;
            collisionSide = side;
        }

    }
}
