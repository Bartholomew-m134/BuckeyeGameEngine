using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IBooState
    {
        void Die();

        void Left();

        void Right();

        void Up();

        void Down();

        void Update();
    }
}
