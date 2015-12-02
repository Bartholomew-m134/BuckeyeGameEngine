using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Interfaces
{
    public interface IBuckeyePlayer : IPlayer
    {
        IBuckeyePlayerState State
        {
            get;
            set;
        }

        void Damage();

        bool IsFacingRight
        {
            get;
            set;
        }
    }
}
