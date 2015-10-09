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

namespace Game
{
    public class LevelLoader
    {
        private Game1 game;

        public LevelLoader(Game1 game)
        {
            this.game = game;
        }

        public void Load(string filename, List<IGameObject> gameObjects)
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
        }

    }
}
