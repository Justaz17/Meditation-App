using System.Media;
using System.Timers;
using System.Drawing;

namespace Lab1
{
    public partial class RelaxTimer : Form
    {
        System.Timers.Timer timer;
        int hours, minutes, seconds;
        readonly SoundPlayer musicPlayer = new SoundPlayer();

        public RelaxTimer()
        {
            InitializeComponent();
            dropdownForMusic.SelectedIndex = 0;
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
            string selectedMusicFile = dropdownForMusic.SelectedIndex switch
            {
                0 => "thinking.wav",
                1 => "tune1.wav",
                2 => "tune2.wav",
                3 => "tune3.wav",
                4 => "tune4.wav",
                5 => "tune5.wav",
                _ => null // Default case if no other matches are found
            };

            if (selectedMusicFile != null)
            {
                PlayMusic(selectedMusicFile);
            }


        }
        public void PlayMusic(string filepath)
        {
            musicPlayer.SoundLocation = filepath;
            musicPlayer.PlayLooping();
        }

        public void continueMusic()
        {
            musicPlayer.Play();
        }
        public void StopMusic()
        {
            musicPlayer.Stop();
        }
        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            StopMusic();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            writeTimeToFile();
            timer.Stop();
            hours = 0;
            minutes = 0;
            timerLabel.Text = "00:00";

        }

        public void writeTimeToFile()
        {
            string path = "timeSpentMeditating.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(timerLabel.Text);
            }
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void countdownBtn_Click(object sender, EventArgs e)
        {
            var newform = new CountdownTimer();
            newform.Show();
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }



        private void Question5_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }
        //test comment
        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                seconds += 1;
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes += 1;
                }
                if (minutes == 60)
                {
                    minutes = 0;
                    hours = 1;

                }
                timerLabel.Text = string.Format("{0}:{1}", hours.ToString().PadLeft(2, '0'), minutes.ToString().PadLeft(2, '0'));


            }));
        }

        private void dropdownForMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
