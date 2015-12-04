﻿using Game.Commands;
using Game.Commands.MarioBrickBreakerCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Utilities.Controls
{
    public class BrickBreakerControls : IControls
    {
        private Game1 game;

        public BrickBreakerControls(Game1 game)
        {
            this.game = game;
        }

        public Dictionary<Keys, ICommand> GetKeyboardControls()
        {
            Dictionary<Keys, ICommand> keyboardControls = new Dictionary<Keys, ICommand>();

            keyboardControls.Add(Keys.Up, new ReleaseBallPaddleCommand());
            keyboardControls.Add(Keys.Left, new FurtherLeftPaddleCommand());
            keyboardControls.Add(Keys.Right, new FurtherRightPaddleCommand());

            keyboardControls.Add(Keys.W, new ReleaseBallPaddleCommand());
            keyboardControls.Add(Keys.A, new FurtherLeftPaddleCommand());
            keyboardControls.Add(Keys.D, new FurtherRightPaddleCommand());

            keyboardControls.Add(Keys.P, new StartButtonCommand(game));

            return keyboardControls;
        }

        public Dictionary<Buttons, ICommand> GetGamePadControls()
        {
            Dictionary<Buttons, ICommand> gamePadControls = new Dictionary<Buttons, ICommand>();

            gamePadControls.Add(Buttons.LeftThumbstickLeft, new FurtherLeftPaddleCommand());
            gamePadControls.Add(Buttons.LeftThumbstickRight, new FurtherRightPaddleCommand());

            gamePadControls.Add(Buttons.A, new ReleaseBallPaddleCommand());

            gamePadControls.Add(Buttons.Start, new StartButtonCommand(game));

            return gamePadControls;
        }
    }
}
