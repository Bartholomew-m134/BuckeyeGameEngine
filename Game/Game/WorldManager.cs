using Game.Collisions;
using Game.Mario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public static class WorldManager
    {
        private static List<IGameObject> gameObjects;
        private static List<CollisionData> collisionList;
        private static string currentFileName;
        private static Game1 currentGame;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            gameObjects = LevelLoader.Load(filename, game);
            currentFileName = filename;
            currentGame = game;
        }

        public static void Update()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Update();

            collisionList = new List<CollisionData>();

            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(gameObjects[i], gameObjects[j]);

                    if (side != null)
                    {
                        collisionList.Add(new CollisionData(gameObjects[i], gameObjects[j], side));
                    }
                }
            }

            foreach (CollisionData collision in collisionList)
            {
                CollisionSelector.HandleCollision(collision);
            }
        }

        public static void Draw()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Draw(); 
        }

        public static IMario GetMario()
        {
            IGameObject mario = null;

            foreach (IGameObject gameObject in gameObjects)
            {
                if (gameObject is IMario)
                {
                    mario = gameObject;
                    break;
                }
            }

            return (IMario)mario;
        }

        public static void SetMario(IMario mario)
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                if (gameObjects[i] is IMario)
                {
                    gameObjects[i] = mario;
                    break;
                }
            }
        }

        public static void ResetToDefault()
        {
            LoadListFromFile(currentFileName, currentGame);
        }
    }
}
