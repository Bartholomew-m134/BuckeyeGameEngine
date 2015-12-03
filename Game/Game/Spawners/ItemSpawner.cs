using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Spawners
{
    public class ItemSpawner : ISpawner
    {
        private IItem item;
        private int count;
        private const int MAXCOUNT = 1;

        public ItemSpawner(IItem item)
        {
            this.item = item;
        }

        public void Release()
        {
            if (count < MAXCOUNT)
            {
                item.Release();
                WorldManager.CreateNewObject(item);
                count++;
            }
        }

        public void Return()
        {
            if (count > 0)
                count--;
        }
    }
}
