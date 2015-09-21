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

        public KeyboardController(Game1 game)
        {
            keyMappings = new Dictionary<Keys, ICommand>();
            
            RegisterCommand(Keys.Y, new SwitchToSmallMarioCommand(game));
            RegisterCommand(Keys.U, new SwitchToBigMarioCommand(game));
            RegisterCommand(Keys.I, new SwitchToFireMarioCommand(game));
            RegisterCommand(Keys.O, new SwitchToDeadMarioCommand(game));

            RegisterCommand(Keys.Z, new SwitchToUsedQuestionBlockCommand(game));
            RegisterCommand(Keys.X, new RemoveBrickBlockCommand(game));
            RegisterCommand(Keys.C, new SwitchToUsedBlock(game));
            
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
                {
                    keyMappings[key].Execute();
                }
            }
        }
    }
}
