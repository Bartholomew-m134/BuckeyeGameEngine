using Game.Commands;
using Game.Commands.MarioCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Controls
{
    public class PacMarioControls : IControls
    {
        private Game1 game;

        public PacMarioControls(Game1 game)
        {
            this.game = game;
        }

        public Dictionary<Keys, ICommand> RetrieveKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.Up, new RaisePacMarioStanceCommand());
            keyboardControls.Add(Keys.Left, new FurtherLeftPacMarioStanceCommand());
            keyboardControls.Add(Keys.Down, new LowerPacMarioStanceCommand());
            keyboardControls.Add(Keys.Right, new FurtherRightPacMarioStanceCommand());

            keyboardControls.Add(Keys.W, new RaisePacMarioStanceCommand());
            keyboardControls.Add(Keys.A, new FurtherLeftPacMarioStanceCommand());
            keyboardControls.Add(Keys.S, new LowerPacMarioStanceCommand());
            keyboardControls.Add(Keys.D, new FurtherRightPacMarioStanceCommand());

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));

            return keyboardControls;
        }

        public Dictionary<Buttons, ICommand> RetrieveGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();

            gamePadControls.Add(Buttons.LeftThumbstickDown, new LowerPacMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickLeft, new FurtherLeftPacMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickRight, new FurtherRightPacMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickUp, new RaisePacMarioStanceCommand());

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));

            return gamePadControls;
        }
    }
}
