using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Controllers
{
    public class GamePadController : IController
    {
        private Dictionary<Buttons, ICommand> buttonMappings;

        public GamePadController(Game1 Game)
        {
            buttonMappings = new Dictionary<Buttons, ICommand>();
        }

        public void RegisterCommand(Buttons button, ICommand command)
        {
            buttonMappings.Add(button, command);
        }

        public void Update()
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);

            if (currentState.Buttons.A == ButtonState.Pressed)
            {
                buttonMappings[Buttons.A].Execute();
            }
            if (currentState.Buttons.B == ButtonState.Pressed)
            {
                buttonMappings[Buttons.B].Execute();
            }
            if (currentState.Buttons.X == ButtonState.Pressed)
            {
                buttonMappings[Buttons.X].Execute();
            }
            if (currentState.Buttons.Start == ButtonState.Pressed)
            {
                buttonMappings[Buttons.Start].Execute();
            } 
        }
    }
}
