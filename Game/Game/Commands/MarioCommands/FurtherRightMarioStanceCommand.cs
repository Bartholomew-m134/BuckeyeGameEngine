using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class FurtherRightMarioStanceCommand : ICommand
    {
        public FurtherRightMarioStanceCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Right();
        }

        public void Release()
        {
            WorldManager.GetMario().Left();
        }
    }
}
