using Game.Collisions;
using Game.Mario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public static class WorldManager
    {
        private static List<IGameObject> gameObjects;

        public static void LoadListFromFile(string filename, Game1 game)
        {
            LevelLoader loader = new LevelLoader(game);
            CollisionDetector detector = new CollisionDetector();
            gameObjects = new List<IGameObject>();
            
            loader.Load(filename, gameObjects);
        }

        public static void Update()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Update();       
            foreach ()
        }

        public static void Draw()
        {
            foreach (IGameObject gameObject in gameObjects)
                gameObject.Draw(); 
        }

        public static IMario GetMario()
        {
            IGameObject mario = null;

            foreach (IGameObject gameObject in gameObjects)
            {
                if (gameObject is IMario)
                {
                    mario = gameObject;
                    break;
                }
            }

            return (MarioInstance) mario;
        }
    }
}
