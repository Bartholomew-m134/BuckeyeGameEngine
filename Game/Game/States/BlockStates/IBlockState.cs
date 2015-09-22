using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public interface IBlockState
    {
        public void Draw();

        public void Update();
    }
}
