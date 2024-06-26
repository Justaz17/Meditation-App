﻿using System.Media;
using System.Numerics;
using System.Timers;

namespace MeditationTimerApp
{
    public partial class CountdownTimerForm : Form
    {
        private System.Timers.Timer timer;
        private int totalTimeInSeconds;
        private int sessionSeconds;
         readonly MySoundPlayer musicPlayer = new MySoundPlayer();

        public CountdownTimerForm()
        {
            InitializeComponent();
            InitializeTimer();
            selectBox.SelectedIndex = 1;
            musicDropDown.SelectedIndex = 4;


        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += TimerElapsed;
            timer.Interval = 1000;
            timer.AutoReset = true;
        }

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
                musicPlayer.StopMusic();
                timerLabel.Invoke(new Action(() => timerLabel.Text = " Zen over"));

                int minutes = totalTimeInSeconds / 60;
                int seconds = totalTimeInSeconds % 60;

                string message = $"Session over\n you meditated for {sessionSeconds} seconds" ;
                string title = "meditation over";
                MessageBox.Show(message, title); 

                
            }
        }

        private void UpdateTimerLabel(int minutes, int seconds)
        {
            timerLabel.Invoke(new Action(() =>
            {
                timerLabel.Text = $"{minutes:D2}:{seconds:D2}";
            }));
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            musicPlayer.StopMusic();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string selectedUnit = selectBox.SelectedItem.ToString();

            int userInputTime = int.Parse(numericUpDown1.Text);

            totalTimeInSeconds = selectedUnit == "Minutes" ? userInputTime * 60 : userInputTime;
           
            

            sessionSeconds = totalTimeInSeconds;

            timer.Start();
            string selectedMusicFile = Program.PickMusicFile(musicDropDown.SelectedIndex);
            if (selectedMusicFile != null)
            {
                musicPlayer.PlayMusic(selectedMusicFile);
            }
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
            label3.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            timerLabel.BackColor = Color.Gray;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Cyan;
            label3.BackColor = Color.Blue;
            label2.BackColor = Color.Blue;
            timerLabel.BackColor = Color.Blue;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            label3.BackColor = Color.DarkSeaGreen;
            label2.BackColor = Color.DarkSeaGreen;
            timerLabel.BackColor = Color.DarkSeaGreen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            label3.BackColor = Color.Gray;
            label2.BackColor = Color.Gray;
            timerLabel.BackColor = Color.Gray;
        }

    }
}

