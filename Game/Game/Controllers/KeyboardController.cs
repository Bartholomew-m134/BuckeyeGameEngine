﻿using Game.Commands;
using Game.Commands.BlockCommands;
using Game.Commands.MarioCommands;
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

        public KeyboardController(Game1 game)
        {
            keyMappings = new Dictionary<Keys, ICommand>();
            prevPressedKeys = Keyboard.GetState().GetPressedKeys();

            RegisterCommand(Keys.Up, new RaiseMarioStanceCommand(game));
            RegisterCommand(Keys.W, new RaiseMarioStanceCommand(game));
            RegisterCommand(Keys.Down, new LowerMarioStanceCommand(game));
            RegisterCommand(Keys.S, new LowerMarioStanceCommand(game));

            RegisterCommand(Keys.Left, new FurtherLeftMarioStanceCommand(game));
            RegisterCommand(Keys.A, new FurtherLeftMarioStanceCommand(game));
            RegisterCommand(Keys.Right, new FurtherRightMarioStanceCommand(game));
            RegisterCommand(Keys.D, new FurtherRightMarioStanceCommand(game));

            RegisterCommand(Keys.R, new ResetToDefaultCommand(game));
        }

        public void RegisterCommand(Keys key, ICommand command)
        {
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
    }
}
