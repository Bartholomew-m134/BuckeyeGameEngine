using Game.Commands;
using Game.Commands.MarioCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyMappings;
        private Keys[] prevPressedKeys;

        public KeyboardController()
        {
            keyMappings = new Dictionary<Keys, ICommand>();
            prevPressedKeys = Keyboard.GetState().GetPressedKeys();

            RegisterCommand(Keys.Up, new RaiseMarioStanceCommand());
            RegisterCommand(Keys.Left, new FurtherLeftMarioStanceCommand());
            RegisterCommand(Keys.Down, new LowerMarioStanceCommand());
            RegisterCommand(Keys.Right, new FurtherRightMarioStanceCommand());

            RegisterCommand(Keys.W, new RaiseMarioStanceCommand());
            RegisterCommand(Keys.A, new FurtherLeftMarioStanceCommand());
            RegisterCommand(Keys.S, new LowerMarioStanceCommand());
            RegisterCommand(Keys.D, new FurtherRightMarioStanceCommand());

            RegisterCommand(Keys.Z, new RaiseMarioStanceCommand());
            RegisterCommand(Keys.X, new MarioFireBallCommand());

            RegisterCommand(Keys.R, new ResetToDefaultCommand());
        }

        public void RegisterCommand(Keys key, ICommand command)
        {
            if(!keyMappings.ContainsKey(key))
                keyMappings.Add(key, command);
        }

        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
                    
            foreach (Keys key in pressedKeys)
            {
                if (keyMappings.ContainsKey(key))
                    keyMappings[key].Execute();               
            }

            foreach (Keys key in prevPressedKeys)
            {
                if (keyMappings.ContainsKey(key) && !pressedKeys.Contains(key))
                    keyMappings[key].Release();
            }

            prevPressedKeys = pressedKeys;
        }

        public void ClearControls()
        {
            keyMappings.Clear();
        }
    }
}
