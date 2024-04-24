using System.Timers;

namespace Lab1
{
    public partial class Question5pt2 : Form
    {
        private System.Timers.Timer timer;
        private int totalTimeInSeconds;
        public Question5pt2()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += TimerElapsed;
            timer.Interval = 1000;
            timer.AutoReset = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            if (totalTimeInSeconds > 0)
            {
                totalTimeInSeconds--;

                int minutes = totalTimeInSeconds / 60;
                int seconds = totalTimeInSeconds % 60;

                UpdateTimerLabel(minutes, seconds);
            }
            else
            {

                timer.Stop();

                timerLabel.Invoke(new Action(() => timerLabel.Text = "Times Up!"));
            }
        }

        private void UpdateTimerLabel(int minutes, int seconds)
        {
            timerLabel.Invoke(new Action(() =>
            {
                timerLabel.Text = $"{minutes:D2}:{seconds:D2}";
            }));
        }

        private void Question5pt2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string selectedUnit = selectBox.SelectedItem.ToString();

            int userInputTime = int.Parse(countdownTime.Text);

            totalTimeInSeconds = selectedUnit == "Minutes" ? userInputTime * 60 : userInputTime;

            timer.Start();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerLabel.Text = "00:00";
        }
    }
}

