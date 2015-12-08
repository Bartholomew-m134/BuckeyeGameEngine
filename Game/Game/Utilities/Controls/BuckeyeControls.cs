using Game.Commands;
using Game.Commands.BuckeyeCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Controls
{
    public class BuckeyeControls : IControls
    {
        private Game1 game;

        public BuckeyeControls(Game1 game)
        {
            this.game = game;
        }

        public Dictionary<Keys, ICommand> RetrieveKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.Up, new RaiseBuckeyeStanceCommand());
            keyboardControls.Add(Keys.Left, new FurtherLeftBuckeyeStanceCommand());
            keyboardControls.Add(Keys.Down, new LowerBuckeyeStanceCommand());
            keyboardControls.Add(Keys.Right, new FurtherRightBuckeyeStanceCommand());

            keyboardControls.Add(Keys.W, new RaiseBuckeyeStanceCommand());
            keyboardControls.Add(Keys.A, new FurtherLeftBuckeyeStanceCommand());
            keyboardControls.Add(Keys.S, new LowerBuckeyeStanceCommand());
            keyboardControls.Add(Keys.D, new FurtherRightBuckeyeStanceCommand());

            keyboardControls.Add(Keys.Z, new RaiseBuckeyeStanceCommand());
            keyboardControls.Add(Keys.X, new BuckeyeRunFootBallCommand());

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));
            keyboardControls.Add(Keys.Enter, new StartButtonCommand(game));
            keyboardControls.Add(Keys.Escape, new StartButtonCommand(game));

            return keyboardControls;
        }

        public Dictionary<Buttons, ICommand> RetrieveGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();

            gamePadControls.Add(Buttons.LeftThumbstickDown, new LowerBuckeyeStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickLeft, new FurtherLeftBuckeyeStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickRight, new FurtherRightBuckeyeStanceCommand());

            gamePadControls.Add(Buttons.A, new RaiseBuckeyeStanceCommand());
            gamePadControls.Add(Buttons.B, new BuckeyeRunFootBallCommand());

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));

            return gamePadControls;
        }
    }
}
