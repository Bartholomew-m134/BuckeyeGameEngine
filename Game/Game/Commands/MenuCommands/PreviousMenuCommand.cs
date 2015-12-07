using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MenuCommands
{
    public class PreviousMenuCommand : ICommand
    {
        private IMenu menu;

        public PreviousMenuCommand(IMenu menu)
        {
            this.menu = menu;
        }

        public void Execute()
        {
            menu.PreviousChoice();
        }

        public void Hold()
        {

        }

        public void Release()
        {

        }
    }
}
