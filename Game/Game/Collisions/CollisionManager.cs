using Game.Interfaces;
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
            HandleCollisionsInOrder(WorldManager.GetCurrentObjectList, WorldManager.GetCurrentDynamicObjectList, gameState);
        }

        private static void HandleCollisionsInOrder(List<IGameObject> objectList, List<IGameObject> dynamicObjects, IGameState gameState)
        {
            /*for (int i = dynamicObjects.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(dynamicObjects[i], dynamicObjects[j]);

                    if (side != null)
                        CollisionSelector.HandleCollision(new CollisionData(dynamicObjects[i], dynamicObjects[j], side), gameState);
                }
            }

            foreach (IGameObject dynamicObject in dynamicObjects)
            {
                foreach (IGameObject staticObject in staticObjects)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(dynamicObject, staticObject);

                    if (side != null)
                        CollisionSelector.HandleCollision(new CollisionData(dynamicObject, staticObject, side), gameState);
                }
            }*/


            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                if (!(objectList[i] is IBlock || objectList[i] is IPipe || objectList[i] is IScenery))
                {
                    for (int j = objectList.Count - 1; j >= 0; j--)
                    {
                        ICollisionSide side = CollisionDetector.DetectCollision(objectList[i], objectList[j]);
                        if (i == j)
                            side = null;

                        if (side != null)
                            CollisionSelector.HandleCollision(new CollisionData(objectList[i], objectList[j], side), gameState);
                    }
                }
            }


            /*for (int i = staticObjects.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(staticObjects[i], staticObjects[j]);

                    if (side != null)
                        CollisionSelector.HandleCollision(new CollisionData(staticObjects[i], staticObjects[j], side), gameState);
                }  
            }*/
        }
    }
}
