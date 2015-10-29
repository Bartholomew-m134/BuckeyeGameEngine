using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using Game.Interfaces;


namespace Game.Music
{
    public class BackgroundMusic : IMusic
    {
        private Stream backgroundSoundFile= TitleContainer.OpenStream(@"Content\SoundTracks\01-main-theme-overworld.wav");
        private SoundEffect backgroundSoundEffect;
        private SoundEffectInstance instance;

        public BackgroundMusic()
        {
            backgroundSoundEffect = SoundEffect.FromStream(backgroundSoundFile);
            instance = backgroundSoundEffect.CreateInstance();
            instance.IsLooped = true;
        }

        public void StopTheme(){
            instance.Stop();
        }

        public void ResumeTheme()
        {
            instance.Resume();
        }

        public void PlayTheme()
        {
            instance.Play();
        }

        public void ReleaseTheme()
        {
            instance.Stop();
        }
    }
}
