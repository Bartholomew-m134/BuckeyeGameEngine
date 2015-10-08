using Game.Collisions;
using Game.Mario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public static class WorldManager
    {
        private static List<IGameObject> gameObjects;
        private static List<CollisionData> collisionList;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            LevelLoader loader = new LevelLoader(game);
            gameObjects = new List<IGameObject>();
            
            loader.Load(filename, gameObjects);
        }

        public static void Update()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Update();


            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = 0; j < gameObjects.Count; j++)
                {
                    ICollisionSide side = null;

                    if(side != null)
                        collisionList.Add(new CollisionData(gameObjects[i], gameObjects[j], side));             
                }
            }

            foreach (CollisionData collision in collisionList)
            {
                CollisionSelector
            }
        }

        public static void Draw()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Draw(); 
        }

        public static MarioInstance GetMario()
        {
            IGameObject mario = null;

            foreach (IGameObject gameObject in gameObjects)
            {
                if (gameObject is MarioInstance)
                {
                    mario = gameObject;
                    break;
                }
            }

            return (MarioInstance) mario;
        }

        public static void SetMario(MarioInstance mario)
        {
            
        }
    }
}
