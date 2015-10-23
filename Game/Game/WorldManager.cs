using Game.Collisions;
using Game.Interfaces;
using Game.Mario;
using Microsoft.Xna.Framework;
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
        private static Camera camera;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            objectList = LevelLoader.Load(filename, game);
            currentFileName = filename;
            currentGame = game;
            camera = new Camera(GetMario().VectorCoordinates);
        }

        public static void Update()
        {
            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                if(camera.IsWithinUpdateZone(objectList[i].VectorCoordinates))
                    objectList[i].Update();
            }

            CollisionManager.Update(objectList);

            camera.Update(GetMario());
        }

        public static void Draw()
        {
            foreach (IGameObject gameObject in objectList)
            {
                if (camera.IsWithinUpdateZone(gameObject.VectorCoordinates))
                    gameObject.Draw(camera);
            }
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
