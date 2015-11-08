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
        public Dictionary<Keys, ICommand> GetKeyboardControls(Game1 game)
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.P, new PauseGameCommand(game));

            return keyboardControls;
        }

        public Dictionary<Microsoft.Xna.Framework.Input.Keys, ICommand> GamePadControls
        {
            get { return null; }
        }
    }
}
