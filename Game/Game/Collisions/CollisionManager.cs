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

            GetCollisionList(gameObjects);
            HandleAllCollisions();
        }

        private static void HandleAllCollisions()
        {
            foreach (CollisionData collision in collisionList)
            {
                CollisionSelector.HandleCollision(collision);
            }
        }

        private static void GetCollisionList(List<IGameObject> gameObjects)
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(gameObjects[i], gameObjects[j]);

                    if (side != null)
                        collisionList.Add(new CollisionData(gameObjects[i], gameObjects[j], side));                  
                }
            }
        }
    }
}
