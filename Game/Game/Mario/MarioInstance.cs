﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.States;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        public IMarioState state;
        public ISprite sprite;
        public MarioInstance()
        {

        }

        public void Update()
        {

        }

        public void Draw() { 
        
        }
    }
}
