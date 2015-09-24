using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public interface IBlockState
    {
          void Update();

          void Disappear();

          void GetUsed();
    }
}
