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
        private static List<Collision> collisionList;
        private static string currentFileName;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            gameObjects = new List<IGameObject>();
            currentFileName = filename;
            
            LevelLoader.Load(filename, gameObjects, game);
        }

        public static void Update()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Update();

            collisionList = new List<Collision>();

            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    ICollisionSide side = CollisionDetector.DetectCollision(gameObjects[i], gameObjects[j]);

                    if (side != null)
                    {
                        collisionList.Add(new Collision(gameObjects[i], gameObjects[j], side));
                    }
                }
            }

            foreach (Collision collision in collisionList)
            {
                CollisionSelector.HandleCollision(collision);
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
            for (int i = 0; i < gameObjects.Count; i++)
            {
                if (gameObjects[i] is IMario)
                {
                    gameObjects[i] = mario;
                    break;
                }
            }
        }

        public static void ResetToDefault(Game1 game)
        {
            LoadListFromFile(currentFileName, game);
        }
    }
}
