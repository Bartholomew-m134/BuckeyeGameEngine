using Game.Commands;
using Game.Commands.MenuCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Controls
{
    public class MenuControls : IControls
    {
        private Game1 game;
        private IMenu menu;

        public MenuControls(IMenu menu, Game1 game)
        {
            this.game = game;
            this.menu = menu;
        }

        public Dictionary<Keys, ICommand> RetrieveKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));
            keyboardControls.Add(Keys.Enter, new StartButtonCommand(game));
            keyboardControls.Add(Keys.Escape, new StartButtonCommand(game));
            keyboardControls.Add(Keys.Down, new NextMenuCommand(menu));
            keyboardControls.Add(Keys.Up, new PreviousMenuCommand(menu));

            return keyboardControls;
        }

        public Dictionary<Buttons, ICommand> RetrieveGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));
            gamePadControls.Add(Buttons.DPadDown, new NextMenuCommand(menu));
            gamePadControls.Add(Buttons.DPadUp, new PreviousMenuCommand(menu));

            return gamePadControls;
        }
    }
}
