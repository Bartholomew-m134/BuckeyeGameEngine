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
using Game.Background_Elements;
using Microsoft.Xna.Framework;
using Game.Interfaces;

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
                Console.WriteLine("File Was Not Loaded\n");
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
            
            objectList.RemoveAt(0);

            foreach(string[] line in objectList)
            {
                foreach(string objectName in line)
                {
                    IGameObject gameObject = null;
                    IGameObject objectsItem = null;

                    if (objectName.Equals("Mario"))
                        gameObject = new MarioInstance(game);
                    else if (objectName.Equals("Coin"))
                        gameObject = new Coin(false, game);
                    else if (objectName.Equals("Flower"))
                        gameObject = new Flower(false, game);
                    else if (objectName.Equals("GreenMush"))
                        gameObject = new GreenMushroom(false, game);
                    else if (objectName.Equals("RedMush"))
                        gameObject = new RedMushroom(false, game);
                    else if (objectName.Equals("Star"))
                        gameObject = new Star(false, game);
                    else if (objectName.Equals("Koopa"))
                        gameObject = new GreenKoopa(game);
                    else if (objectName.Equals("Goomba"))
                        gameObject = new Goomba(game);
                    else if (objectName.Equals("Pipe"))
                        gameObject = new Pipe(game);
                    else if (objectName.Equals("SolidBlock"))
                        gameObject = new Block(Block.Type.SolidBlock, game);
                    else if (objectName.Equals("InvisCoinBlock"))
                    {
                        objectsItem = new Coin(true, game);
                        gameObject = new Block(Block.Type.HiddenBlock, game);
                    }
                    else if (objectName.Equals("QuestionRedMushBlock"))
                    {
                        objectsItem = new RedMushroom(true, game);
                        gameObject = new Block(Block.Type.QuestionBlock, game);
                    }
                    else if (objectName.Equals("BrickBlock"))
                        gameObject = new Block(Block.Type.BrickBlock, game);
                    else if (objectName.Equals("BreakingBlock"))
                        gameObject = new Block(Block.Type.BreakingBlock, game);
                    else if (objectName.Equals("Pipe"))
                        gameObject = new Pipe(game);
                    else if (objectName.Equals("BigHill"))
                        gameObject = new BigHill(game);
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

                    if (objectsItem != null)
                    {
                        objectsItem.VectorCoordinates = location + new Vector2(0, -objectsItem.Sprite.SpriteDimensions.Y + 1);
                        gameObjects.Add(objectsItem);
                    }

                    if(gameObject != null){
                        gameObject.VectorCoordinates = location;  
                        gameObjects.Add(gameObject);   
                    }
                    
                    location.X += 16;
                }

                location.Y += 16;
                location.X = 0;
            }

            for(int index = 0; index < gameObjects.Count; index++)
            {
                if (gameObjects[index] is IMario)
                {
                    IGameObject mario = gameObjects[index];
                    gameObjects.RemoveAt(index);
                    gameObjects.Add(mario);
                    break;
                }
            }

            return gameObjects;
        }
    }
}
