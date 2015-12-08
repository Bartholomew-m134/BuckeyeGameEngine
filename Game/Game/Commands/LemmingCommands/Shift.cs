using Game.Interfaces;
using Game.Lemming.Elevators;
using Game.SoundEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Commands.LemmingCommands
{
    class Shift : ICommand
    {
        public Shift()
        {
        }

        public void Execute()
        {
            foreach (Elevator i in WorldManager.ReturnElevators())
            { i.Shift();}
            foreach (Elevator i in WorldManager.ReturnElevators())
            { i.Shift(); }
            SoundEffectManager.BreakingBlockSoundEffect();
        }

        public void Hold()
        {
            
        }

        public void Release()
        {

        }
    }
}
