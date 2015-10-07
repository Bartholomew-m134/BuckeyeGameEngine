using Game.Blocks;
using Game.Enemies.GoombaClasses;
using Game.Enemies.KoopaClasses;
using Game.Items;
using Game.Mario;
using Game.Pipes;
using Game.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands
{
    public class ResetToDefaultCommand : ICommand
    {
        private Game1 game;

        public ResetToDefaultCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            
        }
    }
}
