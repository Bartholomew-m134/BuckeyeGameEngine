using Game.Interfaces;
using Game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Collisions
{
    public static class CollisionManager
    {
        public static void Update(IGameState gameState)
        {
            HandleCollisionsInOrder(WorldManager.GetCurrentObjectList, gameState);
        }

        private static void HandleCollisionsInOrder(List<IGameObject> objectList, IGameState gameState)
        {
            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                if (!(objectList[i] is IBlock || objectList[i] is IPipe || objectList[i] is IScenery || objectList[i] is Coin))
                {
                    for (int j = objectList.Count - 1; j >= 0; j--)
                    {
                        ICollisionSide side = CollisionDetector.DetectCollision(objectList[i], objectList[j]);

                        if (side != null && i != j)
                            CollisionSelector.HandleCollision(new CollisionData(objectList[i], objectList[j], side), gameState);
                    }
                }
            }
        }
    }
}
