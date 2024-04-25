using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MeditationTimerApp
{
    using System.Media;

    public class MySoundPlayer
    {
        private readonly SoundPlayer soundPlayer;

        public MySoundPlayer()
        {
            soundPlayer = new SoundPlayer();
        }

        public void PlayMusic(string filepath)
        {
            soundPlayer.SoundLocation = filepath;
            soundPlayer.PlayLooping();
        }

        public void StopMusic()
        {
            soundPlayer.Stop();
        }

    }

}
