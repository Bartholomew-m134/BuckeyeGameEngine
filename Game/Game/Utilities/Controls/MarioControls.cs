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
    public class MarioControls : IControls
    {
        public Dictionary<Keys, ICommand> GetKeyboardControls(Game1 game)
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

            keyboardControls.Add(Keys.Z, new RaiseMarioStanceCommand());
            keyboardControls.Add(Keys.X, new MarioRunFireBallCommand());

            keyboardControls.Add(Keys.R, new ResetToDefaultCommand());
            keyboardControls.Add(Keys.P, new PauseGameCommand(game));

            return keyboardControls;
        }




        public Dictionary<Keys, ICommand> GamePadControls
        {
            get { throw new NotImplementedException(); }
        }
    }
}
