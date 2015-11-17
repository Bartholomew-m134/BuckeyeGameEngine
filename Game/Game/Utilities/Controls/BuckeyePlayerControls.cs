using Game.Commands;
using Game.Commands.BuckeyePlayerCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Controls
{
    public class BuckeyePlayerControls : IControls
    {
        private Game1 game;

        public BuckeyePlayerControls(Game1 game)
        {
            this.game = game;
        }

        public Dictionary<Keys, ICommand> GetKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();
            /*
            keyboardControls.Add(Keys.Up, new RaiseMarioStanceCommand());
            keyboardControls.Add(Keys.Left, new FurtherLeftMarioStanceCommand());
            keyboardControls.Add(Keys.Down, new LowerMarioStanceCommand());
            keyboardControls.Add(Keys.Right, new FurtherRightMarioStanceCommand());

            keyboardControls.Add(Keys.W, new RaiseMarioStanceCommand());
            keyboardControls.Add(Keys.A, new FurtherLeftMarioStanceCommand());
            keyboardControls.Add(Keys.S, new LowerMarioStanceCommand());
            keyboardControls.Add(Keys.D, new FurtherRightMarioStanceCommand());

            keyboardControls.Add(Keys.Z, new RaiseMarioStanceCommand());
            keyboardControls.Add(Keys.X, new MarioRunFireBallCommand());

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));
            */
            return keyboardControls;

        }

        public Dictionary<Buttons, ICommand> GetGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();
            /*
            gamePadControls.Add(Buttons.LeftThumbstickDown, new LowerMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickLeft, new FurtherLeftMarioStanceCommand());
            gamePadControls.Add(Buttons.LeftThumbstickRight, new FurtherRightMarioStanceCommand());

            gamePadControls.Add(Buttons.A, new RaiseMarioStanceCommand());
            gamePadControls.Add(Buttons.B, new MarioRunFireBallCommand());

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));
            */
            return gamePadControls;
        }
    }
}
