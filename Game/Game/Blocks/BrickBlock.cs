using Game.States.BlockStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Game.Blocks
{
    public class BrickBlock : IBlock
    {
        private IBlockState blockState;

        public BrickBlock(Game1 game)
        {

        }

        public void Update()
        {
            
        }

        public void Draw()
        {
            
        }

        public void ToUsed()
        {
            blockState = new UsedBlockState();
        }
    }
}
