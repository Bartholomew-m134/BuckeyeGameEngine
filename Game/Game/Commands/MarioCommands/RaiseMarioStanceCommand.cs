﻿using Game.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.MarioCommands
{
    public class RaiseMarioStanceCommand : ICommand
    {
        public RaiseMarioStanceCommand()
        {
        }

        public void Execute()
        {
            WorldManager.GetMario().Jump();
        }

        public void Release()
        {
            Vector2 velocity = WorldManager.GetMario().Physics.Velocity;
            Vector2 acceleration = WorldManager.GetMario().Physics.Acceleration;
            velocity.Y = 5;
            acceleration.Y = 0;
            WorldManager.GetMario().Physics.Velocity = velocity;
            WorldManager.GetMario().Physics.Acceleration = acceleration;
        }
    }
}
