using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Question5 : Form
    {
        System.Timers.Timer timer;
        int h, m, s, ms;

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            timerLabel.Text = "00:00:00:00";
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
        /// <summary>
        /// 
        public Question5()
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
            Invoke(new Action(() => {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h = 1;
                
                }
                timerLabel.Text = string.Format("{0}:{1}:{2}:{3}",h.ToString().PadLeft(2,'0'),m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'), ms.ToString()).PadLeft(2, '0');


            }));
        }
    }
}
