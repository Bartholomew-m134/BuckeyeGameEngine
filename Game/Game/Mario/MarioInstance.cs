using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.States;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        public static IMarioState state;
        public static ISprite sprite;
        public MarioInstance()
        {

        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Draw() 
        {
            throw new NotImplementedException();
        }
    }
}
