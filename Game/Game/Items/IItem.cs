using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Items
{
    public interface IItem : IGameObject
    {
        void Disappear();


    }
}
