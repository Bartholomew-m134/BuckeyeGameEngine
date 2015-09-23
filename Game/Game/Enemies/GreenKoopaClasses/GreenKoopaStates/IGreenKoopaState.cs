using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.GreenKoopaClasses.GreenKoopaStates
{
    public interface IGreenKoopaState
    {
        void GreenKoopaEmergingFromShell();
        void GreenKoopaShellFlipped();
        void GreenKoopaHidingInShell();
        void GreenKoopaChangeDirection();
    }
}
