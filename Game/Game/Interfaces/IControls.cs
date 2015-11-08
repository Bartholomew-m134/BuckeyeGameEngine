using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IControls
    {
        Dictionary<Keys, ICommand> GetKeyboardControls();

        Dictionary<Buttons, ICommand> GetGamePadControls();
    }
}
