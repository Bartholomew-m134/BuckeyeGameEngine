using Game.Collisions;
using Game.Interfaces;
using Game.Mario;
using Game.Music;
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
        private static System.Diagnostics.Stopwatch timer;
        private static IMusic backgroundMusic;
        public static void LoadListFromFile(string filename, Game1 game)
        {
            objectList = LevelLoader.Load(filename, game);
            objectWithinZoneList = new List<IGameObject>();
            currentFileName = filename;
            currentGame = game;
            timer = new System.Diagnostics.Stopwatch();
            backgroundMusic = new BackgroundMusic();
            backgroundMusic.PlayTheme();
        }

        public static void Update(ICamera currentCamera)
        {
            camera = currentCamera;

            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                if (objectList[i] is IProjectile && (camera.IsRightOfCamera(objectList[i].VectorCoordinates) || camera.IsBelowCamera(objectList[i].VectorCoordinates)))
                    FreeObject(objectList[i]);

                if (camera.IsWithinUpdateZone(objectList[i].VectorCoordinates))
                {
                    objectList[i].Update();
                    objectWithinZoneList.Add(objectList[i]);
                }
                else if ((camera.IsBelowCamera(objectList[i].VectorCoordinates)||camera.IsLeftOfCamera(objectList[i].VectorCoordinates)) && camera.LeftScrollingDisabled)
                    FreeObject(objectList[i]);
            }

            CollisionManager.Update(objectWithinZoneList);

            objectWithinZoneList.Clear();

            camera.Update(GetMario());

            if (GetMario().MarioState is Mario.MarioStates.DeadMarioState)
            {
                timer.Start();
                if (timer.ElapsedMilliseconds > 1500)
                {
                    timer.Reset();
                    ResetToDefault();                   
                }
            }
        }

        public static void Draw(ICamera currentCamera)
        {
            camera = currentCamera;

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
            if (referenceObject is IProjectile)
                ((IProjectile)referenceObject).ReturnObject();
            if (referenceObject is IMario)
                ResetToDefault();
        }

        public static void CreateNewObject(IGameObject newObject)
        {
            int index = 0;
            while (objectList[index] is IScenery)
                index++;

            objectList.Insert(index, newObject);
            
        }

        public static void ResetToDefault()
        {
            backgroundMusic.StopTheme();
            LoadListFromFile(currentFileName, currentGame);
            camera.MoveToPosition(Vector2.Zero);

        }
    }
}
