using Game.Interfaces;
using Game.Utilities.Constants;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Game.Music
{
    public class PacMarioEndTheme : IMusic
    {
        private Stream backgroundSoundFile = TitleContainer.OpenStream(SoundConstants.PACENDTHEME);
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public PacMarioEndTheme()
        {
            backgroundSoundEffect = SoundEffect.FromStream(backgroundSoundFile);
            instance = backgroundSoundEffect.CreateInstance();
            instance.IsLooped = false;
        }

        public void StopTheme(){
            instance.Stop();
        }

        public void PlayTheme()
        {
            instance.Play();
        }

        public bool IsPlaying()
        {
            bool isPlaying = false;
            if (instance.State == SoundState.Playing)
                isPlaying = true;
            return isPlaying;
        }
    }
}
