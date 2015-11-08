using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IControls
    {
        Dictionary<Keys, ICommand> GetKeyboardControls(Game1 game);

        Dictionary<Keys, ICommand> GamePadControls { get; }
    }
}
