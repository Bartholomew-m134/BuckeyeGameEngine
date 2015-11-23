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
    public class LemmingControls : IControls
    {
        private Game1 game;

        public LemmingControls(Game1 game)
        {
            this.game = game;
        }

        public Dictionary<Keys, ICommand> GetKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.Up, new RaiseMarioStanceCommand());
            keyboardControls.Add(Keys.Left, new FurtherLeftMarioStanceCommand());
            keyboardControls.Add(Keys.Down, new LowerMarioStanceCommand());
            keyboardControls.Add(Keys.Right, new FurtherRightMarioStanceCommand());

            keyboardControls.Add(Keys.W, new RaiseMarioStanceCommand());
            keyboardControls.Add(Keys.A, new FurtherLeftMarioStanceCommand());
            keyboardControls.Add(Keys.S, new LowerMarioStanceCommand());
            keyboardControls.Add(Keys.D, new FurtherRightMarioStanceCommand());

            //add in Lemming commands
            //keyboardControls.Add(Keys.Z, new RaisePlatformCommand());
            //keyboardControls.Add(Keys.X, new LowerPlatformCommand());

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));

            return keyboardControls;
        }

        public Dictionary<Buttons, ICommand> GetGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();

            gamePadControls.Add(Buttons.LeftThumbstickDown, new LowerMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickLeft, new FurtherLeftMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickRight, new FurtherRightMarioStanceCommand());

            //gamePadControls.Add(Buttons.A, new RaisePlatformCommand());
            //gamePadControls.Add(Buttons.B, new LowerPlatformCommand());

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));

            return gamePadControls;
        }
    }
}
