using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.States;

namespace Game.Mario
{
    public class MarioInstance : IMario
    {
        public IMarioState state;
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
