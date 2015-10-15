using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game;
using Microsoft.Xna.Framework;
using Game.States.BlockStates;

namespace Game.Blocks
{
    public interface IBlock : IGameObject
    {
        IBlockState State { get; set; }

        void Disappear();

        void GetUsed();
    }
}
