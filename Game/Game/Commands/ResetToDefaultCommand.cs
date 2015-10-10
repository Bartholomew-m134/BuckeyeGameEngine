using System;
using System.Linq;
using System.Text;

namespace Game.Commands
{
    public class ResetToDefaultCommand : ICommand
    {
        public ResetToDefaultCommand()
        {
        }

        public void Execute()
        {
            WorldManager.ResetToDefault();
        }

        public void Release()
        {

        }
    }
}
