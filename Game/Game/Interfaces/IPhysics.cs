using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game.Interfaces
{
    public interface IPhysics
    {
        Vector2 Update(Vector2 coordinates);

        Vector2 OldCoordinates
        {
            get;
        }

        Vector2 Velocity
        {
            get;
            set;
        }

        Vector2 Acceleration
        {
            get;
            set;
        }

        Vector2 VelocityMaximum
        {
            get;
            set;
        }

        Vector2 VelocityMinimum
        {
            get;
            set;
        }

        void ResetY();

        void ResetX();

        void ResetPhysics();

        void DampenRight();

        void DampenLeft();
    }
}
