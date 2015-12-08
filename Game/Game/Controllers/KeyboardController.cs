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

        public KeyboardController(IControls controls)
        {
            keyMappings = controls.RetrieveKeyboardControls();
            prevPressedKeys = Keyboard.GetState().GetPressedKeys();
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
                if (keyMappings.ContainsKey(key) && prevPressedKeys.Contains(key))
                    keyMappings[key].Hold();
                else if (keyMappings.ContainsKey(key))
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
