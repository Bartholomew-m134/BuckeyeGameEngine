using Game.Commands;
using Game.Commands.MarioCommands;
using Game.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class GamePadController : IController
    {
        private Dictionary<Buttons, ICommand> buttonMappings;
        private GamePadState prevState;

        public GamePadController(IControls controls)
        {
            buttonMappings = controls.RetrieveGamePadControls();
            prevState = GamePad.GetState(PlayerIndex.One);
        }

        public void RegisterCommand(Buttons button, ICommand command)
        {
            if(!buttonMappings.ContainsKey(button))
                buttonMappings.Add(button, command);
        }

        public void Update()
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);

            if (currentState.IsButtonDown(Buttons.LeftThumbstickUp))
            {
                buttonMappings[Buttons.LeftThumbstickUp].Execute();
            }
            else if (currentState.IsButtonDown(Buttons.LeftThumbstickDown))
            {
                buttonMappings[Buttons.LeftThumbstickDown].Execute();
            }
            else if (currentState.IsButtonDown(Buttons.LeftThumbstickRight))
            {
                buttonMappings[Buttons.LeftThumbstickRight].Execute();
            }
            else if (currentState.IsButtonDown(Buttons.LeftThumbstickLeft))
            {
                buttonMappings[Buttons.LeftThumbstickLeft].Execute();
            }


            if (prevState.IsButtonDown(Buttons.LeftThumbstickUp) && currentState.IsButtonUp(Buttons.LeftThumbstickUp))
            {
                buttonMappings[Buttons.LeftThumbstickUp].Release();
            }
            else if (prevState.IsButtonDown(Buttons.LeftThumbstickDown) && currentState.IsButtonUp(Buttons.LeftThumbstickDown))
            {
                buttonMappings[Buttons.LeftThumbstickDown].Release();
            }
            else if (prevState.IsButtonDown(Buttons.LeftThumbstickRight) && currentState.IsButtonUp(Buttons.LeftThumbstickRight))
            {
                buttonMappings[Buttons.LeftThumbstickRight].Release();
            }
            else if (prevState.IsButtonDown(Buttons.LeftThumbstickLeft) && currentState.IsButtonUp(Buttons.LeftThumbstickLeft))
            {
                buttonMappings[Buttons.LeftThumbstickLeft].Release();
            }

            prevState = currentState;
        }

        public void ClearControls()
        {
            buttonMappings.Clear();
        }
    }
}
