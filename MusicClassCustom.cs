using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MeditationTimerApp
{
    using System.Media;
    /// <summary>
    ///  A class that plays music
    /// </summary>
    public class MySoundPlayer
    {
        /// <summary>
        /// The sound player object
        /// </summary>
        private readonly SoundPlayer soundPlayer;

        public MySoundPlayer()
        {
            soundPlayer = new SoundPlayer();
        }

        /// <summary>
        /// Plays music
        /// </summary>
        /// <param name="filepath">The path to the music file</param>
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
