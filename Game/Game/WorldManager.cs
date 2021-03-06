﻿using Game.Interfaces;
using Game.Lemming.Elevators;
using Game.Mario;
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
        public static List<Elevator> ElevatorList = new List<Elevator>();

        private static Game1 currentGame;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            objectList = LevelLoader.Load(filename, game);
            objectWithinZoneList = new List<IGameObject>();
            currentGame = game;
            currentGame.gameState.StateBackgroundTheme();
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

            ResetIfPlayerIsDead(camera);
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

        public static IPlayer ReturnPlayer()
        {
            return (IPlayer)objectList.Find(i => i is IPlayer);
        }

        public static IPaddleBall ReturnPaddleBall()
        {
            return (IPaddleBall)objectList.Find(i => i is IPaddleBall);
        }

        public static IEnemy ReturnLemming()
        {
            return (IEnemy)objectList.Find(i => i is IEnemy);
        }

        public static List<Elevator> ReturnElevators()
        {
            foreach(IGameObject i in objectList){
                if (i is Elevator)
                {
                    ElevatorList.Add((Elevator)i);
                }
                  
            }
            return ElevatorList;
        }

        public static void SetPlayer(IPlayer player)
        {
            int index = objectList.FindIndex(i => i is IPlayer);
            objectList[index] = player;
        }

        public static void FreeObject(IGameObject referenceObject)
        {

            if (referenceObject is IProjectile)
            {
                objectList.Remove(referenceObject);
                ((IProjectile)referenceObject).ReturnObject();           
            }
            else if (referenceObject is IPlayer)
                currentGame.gameState.PlayerDied();
            else if (referenceObject is IPaddleBall) 
            {
                objectList.Remove(referenceObject);
            }
        }

        public static void CreateNewObject(IGameObject newObject)
        {
            objectList.Add(newObject);          
        }

        private static void ResetIfPlayerIsDead(ICamera camera)
        {
            if (ReturnPlayer().IsDead || camera.IsBelowCamera(ReturnPlayer().VectorCoordinates))
                FreeObject(ReturnPlayer());
        }
    }
}
