using Game.Blocks;
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
        public static List<IGameObject> Load(string filename, Game1 game)
        {
            string directory = game.Content.RootDirectory + "\\Levels\\" + filename + ".csv";
            List<string[]> objectList = ParseFile(GetFileContents(directory));
            return CreateNewGameObjects(objectList, game);
        }

        private static List<string[]> ParseFile(List<string> fileContents)
        {
            List<string[]> parsedObjects = new List<string[]>();

            foreach (string line in fileContents)
                parsedObjects.Add(line.Split(','));

            return parsedObjects;
        }

        private static List<string> GetFileContents(string directory)
        {
            List<string> fileContents = new List<string>();
            StreamReader reader = new StreamReader(directory);

            try
            {
                do
                    fileContents.Add(reader.ReadLine());            
                while (reader.Peek() != -1);
            }
            catch
            {
                Debug.WriteLine("File Was Not Loaded\n");
            }
            finally
            {
                reader.Close();
            }

            return fileContents;
        }

        private static List<IGameObject> CreateNewGameObjects(List<string[]> objectList, Game1 game)
        {
            List<IGameObject> gameObjects = new List<IGameObject>();
            
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
            



            return gameObjects;
        }
    }
}
