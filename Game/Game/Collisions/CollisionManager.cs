using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public static class CollisionManager
    {

        private static List<CollisionData> collisionList;

        public static void Update(List<IGameObject> gameObjects)
        {
            collisionList = new List<CollisionData>();

            HandleCollisionsInOrder(gameObjects);
        }

        private static void HandleCollisionsInOrder(List<IGameObject> gameObjects)
        {
            gameObjects.Reverse();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                List<CollisionData> objectCollisionList = new List<CollisionData>();
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(gameObjects[i], gameObjects[j]);

                    if (side != null)
                        CollisionSelector.HandleCollision(new CollisionData(gameObjects[i], gameObjects[j], side));
                }  
            }
        }
    }
}
