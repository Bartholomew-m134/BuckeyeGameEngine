using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Enemies.KoopaClasses.KoopaStates
{
    public interface IKoopaState
    {
        void KoopaEmergingFromShell();
        void KoopaShellFlipped();
        void KoopaHidingInShell();
        void KoopaChangeDirection();
    }
}
