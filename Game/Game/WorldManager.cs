using Game.Collisions;
using Game.Interfaces;
using Game.Mario;
using Game.Music;
using Game.Utilities;
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
        private static List<IGameObject> objectWithinZoneList;

        private static string currentFileName;
        private static Game1 currentGame;
        private static ICamera camera;


        public static void LoadListFromFile(string filename, Game1 game)
        {
            BackgroundThemeManager.PlayOverWorldTheme();
            objectList = LevelLoader.Load(filename, game);
            objectWithinZoneList = new List<IGameObject>();
            currentFileName = filename;
            currentGame = game;           
        }

        public static void Update(ICamera currentCamera)
        {
            objectWithinZoneList.Clear();
            camera = currentCamera;

            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                Vector2 position = objectList[i].VectorCoordinates;

                if (camera.IsWithinUpdateZone(position))
                {
                    objectList[i].Update();
                    objectWithinZoneList.Add(objectList[i]);
                }
                else if (camera.IsWithinReleaseZone(position) || objectList[i] is IProjectile)
                    FreeObject(objectList[i]);
            }

            CollisionManager.Update(objectWithinZoneList, currentGame.gameState);
            camera.Update(GetMario());
            ResetIfMarioIsDead();
        }

        public static void Draw(ICamera currentCamera)
        {
            camera = currentCamera;

            for (int i = objectWithinZoneList.Count - 1; i >= 0; i--)
                    objectWithinZoneList[i].Draw(camera);
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

            if (referenceObject is IProjectile)
            {
                objectList.Remove(referenceObject);
                ((IProjectile)referenceObject).ReturnObject();           
            }
            else if (referenceObject is IMario)
                currentGame.gameState.PlayerDied();
        }

        public static void CreateNewObject(IGameObject newObject)
        {
            int index = 0;
            while (objectList[index] is IScenery)
                index++;

            objectList.Insert(index, newObject);
            
        }

        private static void ResetIfMarioIsDead()
        {
            if (GetMario().MarioState is Mario.MarioStates.DeadMarioState || !camera.IsWithinBounds(GetMario().VectorCoordinates) || HUDManager.OutOfTime)
                FreeObject(GetMario());
        }
    }
}
