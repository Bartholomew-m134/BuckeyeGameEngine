﻿using Game.Blocks;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Items;
using Game.Mario;
using Game.Pipes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Game
{
    public static class LevelLoader
    {
        public static void Load(string filename, List<IGameObject> gameObjects, Game1 game)
        {
            
            gameObjects.Add(new Coin(game));
            gameObjects.Add(new Flower(game));
            gameObjects.Add(new GreenMushroom(game));
            gameObjects.Add(new RedMushroom(game));
            gameObjects.Add(new Star(game));

            gameObjects.Add(new MarioInstance(game));

            gameObjects.Add(new Block(1, game));
            gameObjects.Add(new Block(2, game));
            gameObjects.Add(new Block(3, game));
            gameObjects.Add(new Block(4, game));
            gameObjects.Add(new Block(5, game));

            gameObjects.Add(new Goomba(game));
            gameObjects.Add(new GreenKoopa(game));

            gameObjects.Add(new Pipe(game));
            
            List<string> fileContents = new List<string>();
            string winDir = System.Environment.GetEnvironmentVariable("windir");
            Debug.WriteLine(winDir);
        }

        private static void ParseFile(string filename)
        {

        }

        //private static string

    }
}
