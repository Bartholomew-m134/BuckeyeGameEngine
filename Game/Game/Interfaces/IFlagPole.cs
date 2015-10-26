using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IFlagPole : IGameObject
    {
        bool IsActive
        {
            get;
            set;
        }

        bool HasBeenActivatedOnce
        {
            get;
            set;
        }
    }
}
