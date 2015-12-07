using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game.SoundEffects
{
    public class PacMarioExtraLifeEffect : ISoundEffect
    {
        private Stream backgroundSoundFile = TitleContainer.OpenStream(SoundConstants.PACEXTRALIFE);
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public PacMarioExtraLifeEffect()
        {
            backgroundSoundEffect = SoundEffect.FromStream(backgroundSoundFile);
            instance = backgroundSoundEffect.CreateInstance();
            instance.IsLooped = false;
        }

        public void Play()
        {
            instance.Play();
        }
    }
}
