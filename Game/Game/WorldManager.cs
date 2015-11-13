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
        private static List<IGameObject> staticObjectZoneList;
        private static List<IGameObject> dynamicObjectZoneList;
        private static List<IGameObject> objectWithinZoneList;

        private static string currentFileName;
        private static Game1 currentGame;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            BackgroundThemeManager.PlayOverWorldTheme();
            objectList = LevelLoader.Load(filename, game);
            staticObjectZoneList = new List<IGameObject>();
            dynamicObjectZoneList = new List<IGameObject>();
            objectWithinZoneList = new List<IGameObject>();
            currentFileName = filename;
            currentGame = game;           
        }

        public static void Update(ICamera camera)
        {
            staticObjectZoneList.Clear();
            dynamicObjectZoneList.Clear();
            objectWithinZoneList.Clear();

            for (int i = objectList.Count - 1; i >= 0; i--)
            {
                Vector2 position = objectList[i].VectorCoordinates;

                if (camera.IsWithinUpdateZone(position))
                {
                    objectList[i].Update();
                    objectWithinZoneList.Add(objectList[i]);
                    if (objectList[i] is IBlock || objectList[i] is IScenery || objectList[i] is IPipe)
                        //staticObjectZoneList.Insert(0, objectList[i]);
                        staticObjectZoneList.Add(objectList[i]);
                    else
                        //dynamicObjectZoneList.Insert(0, objectList[i]);
                        dynamicObjectZoneList.Add(objectList[i]);
                }
                else if (camera.IsWithinReleaseZone(position) || objectList[i] is IProjectile)
                    FreeObject(objectList[i]);
            }

            ResetIfMarioIsDead(camera);
        }

        public static void Draw(ICamera camera)
        {
            /*for (int i = staticObjectZoneList.Count - 1; i >= 0; i--)
                staticObjectZoneList[i].Draw(camera);

            for (int i = dynamicObjectZoneList.Count - 1; i >= 0; i--)
                dynamicObjectZoneList[i].Draw(camera);*/

            for (int i = objectWithinZoneList.Count - 1; i >= 0; i--)
                objectWithinZoneList[i].Draw(camera);
        }

        public static List<IGameObject> GetCurrentObjectList
        {
            get { return objectWithinZoneList; }
        }

        public static List<IGameObject> GetCurrentStaticObjectList
        {
            get { return staticObjectZoneList; }
        }

        public static List<IGameObject> GetCurrentDynamicObjectList
        {
            get { return dynamicObjectZoneList; }
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

        private static void ResetIfMarioIsDead(ICamera camera)
        {
            if (GetMario().MarioState is Mario.MarioStates.DeadMarioState || camera.IsBelowCamera(GetMario().VectorCoordinates))
                FreeObject(GetMario());
        }
    }
}
