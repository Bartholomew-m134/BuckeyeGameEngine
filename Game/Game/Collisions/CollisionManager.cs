using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public static class CollisionManager
    {
        public static void Update(List<IGameObject> gameObjects, IGameState gameState)
        {
            HandleCollisionsInOrder(gameObjects, gameState);
        }

        private static void HandleCollisionsInOrder(List<IGameObject> gameObjects, IGameState gameState)
        {
            
            for (int i = gameObjects.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(gameObjects[i], gameObjects[j]);

                    if (side != null)
                        CollisionSelector.HandleCollision(new CollisionData(gameObjects[i], gameObjects[j], side), gameState);
                }  
            }
        }
    }
}
