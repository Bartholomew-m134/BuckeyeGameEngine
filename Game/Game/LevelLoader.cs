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
using Game.Background_Elements;
using Microsoft.Xna.Framework;

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
            Vector2 location = new Vector2(0,0);
            
            /*
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
            



            gameObjects.Add(new BigHill(game));
            gameObjects.Add(new SmallHill(game));
            gameObjects.Add(new SingleCloud(game));
            gameObjects.Add(new TripleCloud(game));
            gameObjects.Add(new SingleBush(game));
            gameObjects.Add(new TripleBush(game));
            */

            objectList.RemoveAt(0);

            foreach(string[] line in objectList)
            {
                foreach(string objectName in line)
                {
                    IGameObject gameObject = null;


                    if (objectName.Equals("Mario"))
                        gameObject = new MarioInstance(game);
                    else if (objectName.Equals("Coin"))
                        gameObject = new Coin(game);
                    else if (objectName.Equals("Flower"))
                        gameObject = new Flower(game);
                    else if (objectName.Equals("GreenMush"))
                        gameObject = new GreenMushroom(game);
                    else if (objectName.Equals("RedMush"))
                        gameObject = new RedMushroom(game);
                    else if (objectName.Equals("Star"))
                        gameObject = new Star(game);
                    else if (objectName.Equals("Koopa"))
                        gameObject = new GreenKoopa(game);
                    else if (objectName.Equals("Goomba"))
                        gameObject = new Goomba(game);
                    else if (objectName.Equals("Pipe"))
                        gameObject = new Pipe(game);
                    else if (objectName.Equals("SolidBlock"))
                        gameObject = new Block(4, game);
                    else if (objectName.Equals("InvisBlock"))
                        gameObject = new Block(2, game);
                    else if (objectName.Equals("QuestionBlock"))
                        gameObject = new Block(3, game);
                    else if (objectName.Equals("BrickBlock"))
                        gameObject = new Block(1, game);
                    else if (objectName.Equals("BreakingBlock"))
                        gameObject = new Block(5, game);
                    else if (objectName.Equals("Pipe"))
                        gameObject = new Pipe(game);
                    else if (objectName.Equals("BigHill"))
                    {
                        gameObject = new BigHill(game);
                        gameObject.VectorCoordinates = location;
                        Debug.WriteLine(gameObject.VectorCoordinates.Y);
                    }
                    else if (objectName.Equals("Bush"))
                        gameObject = new SingleBush(game);
                    else if (objectName.Equals("Cloud"))
                        gameObject = new SingleCloud(game);
                    else if (objectName.Equals("SmHill"))
                        gameObject = new SmallHill(game);
                    else if (objectName.Equals("TripleBush"))
                        gameObject = new TripleBush(game);
                    else if (objectName.Equals("TripleCloud"))
                        gameObject = new TripleCloud(game);

                    

                    if(gameObject != null){
                        gameObject.VectorCoordinates = location;  
                        gameObjects.Add(gameObject);   
                    }
                    location.X += 16;
                }

                location.Y += 16;
                location.X = 0;
            }

            return gameObjects;
        }
    }
}
