using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Blocks
{
    public interface IBlock
    {
        public void Update();

        public void Draw();
    }
}
