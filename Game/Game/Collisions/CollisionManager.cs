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

        public static void Update(List<IGameObject> gameObjects, Camera camera)
        {
            collisionList = new List<CollisionData>();

            GetCollisionList(gameObjects, camera);
            //HandleAllCollisions();
        }

        private static void HandleAllCollisions()
        {
            foreach (CollisionData collision in collisionList)
            {
                CollisionSelector.HandleCollision(collision);
            }
        }

        private static void GetCollisionList(List<IGameObject> gameObjects, Camera camera)
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(gameObjects[i], gameObjects[j]);

                    if (side != null && camera.IsWithinUpdateZone(gameObjects[i].VectorCoordinates))
                    {
                        //collisionList.Add(new CollisionData(gameObjects[i], gameObjects[j], side));
                        CollisionSelector.HandleCollision(new CollisionData(gameObjects[i], gameObjects[j], side));
                    }
                }
            }
        }
    }
}
