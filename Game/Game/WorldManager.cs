using Game.Collisions;
using Game.Interfaces;
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
        private static List<IGameObject> objectList;
        private static string currentFileName;
        private static Game1 currentGame;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            objectList = LevelLoader.Load(filename, game);
            currentFileName = filename;
            currentGame = game;
        }

        public static void Update()
        {
            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                    objectList[i].Update();
            }

            CollisionManager.Update(objectList);
        }

        public static void Draw()
        {
            foreach (IGameObject gameObject in objectList)
                gameObject.Draw(); 
        }

        public static IMario GetMario()
        {
            return (IMario)objectList.Find(i => i is IMario);
        }

        public static void SetMario(IMario mario)
        {
            int index = objectList.FindIndex(i => i is IMario);
            objectList[index] = mario;
        }

        public static void FreeObject(IGameObject referenceObject)
        {
            objectList.Remove(referenceObject);
        }

        public static void ResetToDefault()
        {
            LoadListFromFile(currentFileName, currentGame);
        }
    }
}
