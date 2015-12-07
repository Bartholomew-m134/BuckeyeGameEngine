using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MenuCommands
{
    public class NextMenuCommand : ICommand
    {
        private IMenu menu;

        public NextMenuCommand(IMenu menu)
        {
            this.menu = menu;
        }

        public void Execute()
        {
            menu.NextChoice();
        }

        public void Hold()
        {
            
        }

        public void Release()
        {
            
        }
    }
}
