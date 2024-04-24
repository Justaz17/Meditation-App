using System.Media;
using System.Reflection.Metadata.Ecma335;
using System.Timers;
namespace Lab1
{
    public partial class Timer : Form
    {
        System.Timers.Timer timer;
        int hours, minutes, seconds;
        SoundPlayer musicPlayer;
        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
            if (timerLabel.Text == "00:00")
            {
                musicPlayer = new SoundPlayer();
                PlayMusic("thinking.wav");
            }
            else { 
            
            continueMusic();
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
            var newform = new Question5pt2();
            newform.Show();
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }
        public Timer()
        {
            InitializeComponent();
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
    }
}
