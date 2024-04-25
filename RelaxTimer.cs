using System.Media;
using System.Timers;
using System.Drawing;

namespace MeditationTimerApp
{
    public partial class RelaxTimer : Form
    {
        System.Timers.Timer timer;
        int hours, minutes, seconds;
        private readonly MySoundPlayer player;

        public RelaxTimer()
        {
            InitializeComponent();
            dropdownForMusic.SelectedIndex = 4;
            player = new MySoundPlayer();
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
            string selectedMusicFile = Program.PickMusicFile(dropdownForMusic.SelectedIndex);

            if (selectedMusicFile != null)
            {
                player.PlayMusic(selectedMusicFile);
            }


        }



        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            player.StopMusic();

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
