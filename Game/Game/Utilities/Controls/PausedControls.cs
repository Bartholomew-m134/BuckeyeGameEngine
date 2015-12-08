using Game.Commands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Controls
{
    public class PausedControls : IControls
    {
        private Game1 game;

        public PausedControls(Game1 game)
        {
            this.game = game;
        }

        public Dictionary<Keys, ICommand> RetrieveKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));

            return keyboardControls;
        }

        public Dictionary<Buttons, ICommand> RetrieveGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));

            return gamePadControls;
        }
    }
}
