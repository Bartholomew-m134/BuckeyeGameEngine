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

        private static Game1 currentGame;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            BackgroundThemeManager.PlayOverWorldTheme();
            objectList = LevelLoader.Load(filename, game);
            objectWithinZoneList = new List<IGameObject>();
            currentGame = game;           
        }

        public static void Update(ICamera camera)
        {
            objectWithinZoneList.Clear();

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

            ResetIfMarioIsDead(camera);
        }

        public static void Draw(ICamera camera)
        {
            for (int i = objectWithinZoneList.Count - 1; i >= 0; i--)
                objectWithinZoneList[i].Draw(camera);
        }

        public static List<IGameObject> GetCurrentObjectList
        {
            get { return objectWithinZoneList; }
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
            objectList.Add(newObject);          
        }

        private static void ResetIfMarioIsDead(ICamera camera)
        {
            if (GetMario().MarioState is Mario.MarioStates.DeadMarioState || camera.IsBelowCamera(GetMario().VectorCoordinates))
                FreeObject(GetMario());
        }
    }
}
