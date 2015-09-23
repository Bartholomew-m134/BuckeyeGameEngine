using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.States.BlockStates
{
    public class HiddenBlockState : IBlockState
    {
        private Game1 game;

        public HiddenBlockState(Game1 game)
        {
            this.game = game;
        }

        public void Draw() 
        {
        }

        public void Update()
        {
            
        }

        public void ToUsed()
        {

        }
    }
}
