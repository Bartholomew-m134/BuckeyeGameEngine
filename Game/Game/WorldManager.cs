using Game.Blocks;
using Game.Enemies.GoombaClasses;
using Game.Enemies.GreenKoopaClasses;
using Game.Items;
using Game.Mario;
using Game.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public static class WorldManager
    {
        public static List<IMario> players;
        public static List<IBlock> blocks;
        public static List<IPipe> pipes;
        public static List<Goomba> goombas;
        public static List<GreenKoopa> koopas;
        public static List<IItem> items;

        public static void LoadListFromFile(string filename)
        {
            LevelLoader loader = new LevelLoader();

            players = new List<IMario>();
            blocks = new List<IBlock>();
            pipes = new List<IPipe>();
            goombas = new List<Goomba>();
            koopas = new List<GreenKoopa>();
            items = new List<IItem>();

            loader.Load(filename, players, blocks, pipes, goombas, koopas, items);
        }

        public static void Update()
        {
            foreach (IMario mario in players)
                mario.Update();
            foreach (IBlock block in blocks)
                block.Update();
            foreach (IPipe pipe in pipes)
                pipe.Update();
            foreach (Goomba goomba in goombas)
                goomba.Update();
            foreach (GreenKoopa koopa in koopas)
                koopa.Update();
            foreach (IItem item in items)
                item.Update();
        }

        public static void Draw()
        {
            foreach (IMario mario in players)
                mario.Draw();
            foreach (IBlock block in blocks)
                block.Draw();
            foreach (IPipe pipe in pipes)
                pipe.Draw();
            foreach (Goomba goomba in goombas)
                goomba.Draw();
            foreach (GreenKoopa koopa in koopas)
                koopa.Draw();
            foreach (IItem item in items)
                item.Draw();
        }
    }
}
