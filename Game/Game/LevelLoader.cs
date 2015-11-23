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
using Game.FlagPoles;
using Game.ProjectBuckeye.PlayerClasses;
using Game.GameStates;

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
                    else if (objectName.Equals("Castle"))
                        gameObject = new Castle(game);
                    else if (objectName.Equals("FlagPole"))
                        gameObject = new FlagPole(game);
                    else if (objectName.Equals("FlagPoleBarrier"))
                        gameObject = new InvisibleFlagPoleBarrier(game);
                    else if (objectName.Equals("SolidBlock"))
                        gameObject = new Block(Block.Type.SolidBlock, false, game);
                    else if (objectName.Equals("InvisCoinBlock"))
                    {
                        objectsItem = new Coin(true, game);
                        gameObject = new Block(Block.Type.HiddenBlock, false, game);
                    }
                    else if (objectName.Equals("InvisGreenMushBlock"))
                    {
                        objectsItem = new GreenMushroom(true, game);
                        gameObject = new Block(Block.Type.HiddenBlock, false, game);
                    }
                    else if (objectName.Equals("QuestionCoinBlock"))
                    {
                        objectsItem = new Coin(true, game);
                        gameObject = new Block(Block.Type.QuestionBlock, false, game);
                    }
                    else if (objectName.Equals("BrickCoinBlock"))
                    {
                        objectsItem = new Coin(true, game);
                        gameObject = new Block(Block.Type.BrickBlock, false, game);
                    }
                    else if (objectName.Equals("QuestionRedMushBlock"))
                    {
                        objectsItem = new RedMushroom(true, game);
                        gameObject = new Block(Block.Type.QuestionBlock, false, game);
                    }
                    else if (objectName.Equals("QuestionGreenMushBlock"))
                    {
                        objectsItem = new GreenMushroom(true, game);
                        gameObject = new Block(Block.Type.QuestionBlock, false, game);
                    }
                    else if (objectName.Equals("QuestionFlowerBlock"))
                    {
                        objectsItem = new Flower(true, game);
                        gameObject = new Block(Block.Type.QuestionBlock, false, game);
                    }
                    else if (objectName.Equals("QuestionStarBlock"))
                    {
                        objectsItem = new Star(true, game);
                        gameObject = new Block(Block.Type.QuestionBlock, false, game);
                    }
                    else if (objectName.Equals("BrickStarBlock"))
                    {
                        objectsItem = new Star(true, game);
                        gameObject = new Block(Block.Type.BrickBlock, false, game);
                    }
                    else if (objectName.Equals("BrickBlock"))
                        gameObject = new Block(Block.Type.BrickBlock, false, game);
                    else if (objectName.Equals("UndergroundBrickBlock"))
                        gameObject = new Block(Block.Type.BrickBlock, true, game);
                    else if (objectName.Equals("BreakingBlock"))
                        gameObject = new Block(Block.Type.BreakingBlock, false, game);
                    else if (objectName.Equals("UndergroundBreakingBlock"))
                        gameObject = new Block(Block.Type.BreakingBlock, true, game);
                    else if (objectName.Equals("Pipe"))
                        gameObject = new Pipe(game);
                    else if (objectName.Equals("DoublePipe"))
                        gameObject = new DoublePipe(game);
                    else if (objectName.Equals("TriplePipe"))
                        gameObject = new TriplePipe(game);
                    else if (objectName.Equals("BottomSidePipe"))
                        gameObject = new SidePipe(game);
                    else if (objectName.Equals("VerticalPipe"))
                        gameObject = new VerticalPipe(game);
                    else if (objectName.StartsWith("TripleWarpPipe"))
                    {
                        string[] parsedName = objectName.Split('-');
                        float x = Int32.Parse(parsedName[1]);
                        float y = Int32.Parse(parsedName[2]);
                        gameObject = new TriplePipe(new Vector2(x, y), game);
                    }
                    else if (objectName.StartsWith("TripleGameStatePipe"))
                    {
                        string[] parsedName = objectName.Split('-');
                        IGameState gameState = createNewGameState(parsedName[1], game);
                        gameObject = new TriplePipe(gameState, game);
                    }
                    else if (objectName.StartsWith("SideWarpPipe"))
                    {
                        string[] parsedName = objectName.Split('-');
                        float x = Int32.Parse(parsedName[1]);
                        float y = Int32.Parse(parsedName[2]);
                        gameObject = new SidePipe(new Vector2(x, y), game);
                    }
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
                    else if (objectName.Equals("Buckeye"))
                        gameObject = new BuckeyePlayer(game);

                    if (objectsItem != null)
                    {
                        objectsItem.VectorCoordinates = location + new Vector2(0, -objectsItem.Sprite.SpriteDimensions.Y);
                        gameObjects.Add(objectsItem);
                    }

                    if(gameObject != null){
                        gameObject.VectorCoordinates = location + new Vector2(0, -gameObject.Sprite.SpriteDimensions.Y + 16);

                        if (gameObject is IFlagPole)
                            gameObject.VectorCoordinates += new Vector2(0,16);

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

            for (int index = 0; index < gameObjects.Count; index++)
            {
                if (gameObjects[index] is IScenery)
                {
                    IGameObject scenery = gameObjects[index];
                    gameObjects.RemoveAt(index);
                    gameObjects.Insert(0, scenery);
                }
                else if (gameObjects[index] is IPipe)
                {
                    IGameObject pipe = gameObjects[index];
                    gameObjects.RemoveAt(index);
                    gameObjects.Add(pipe);
                }
            }

                return gameObjects;
        }


        public static IGameState createNewGameState(string text, Game1 game)
        {
            IGameState gameState = null;

            if(text.Equals("ProjectBuckeyeGameState"))
            {
                gameState = new ProjectBuckeyeGameState(game);
            }
            else if (text.Equals("PacMarioGameState"))
            {
                gameState = new PacMarioGameState(game);
            }

            return gameState;
        }

    }
}
