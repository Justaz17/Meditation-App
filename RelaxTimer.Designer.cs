namespace Lab1
{
    partial class RelaxTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Timer = new System.Windows.Forms.Timer(components);
            startBtn = new Button();
            stopBtn = new Button();
            resetBtn = new Button();
            countdownBtn = new Button();
            timerLabel = new Label();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(0, 205, 51);
            startBtn.FlatStyle = FlatStyle.Popup;
            startBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(87, 226);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(160, 60);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.BackColor = Color.FromArgb(247, 86, 91);
            stopBtn.FlatStyle = FlatStyle.Popup;
            stopBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            stopBtn.ForeColor = Color.White;
            stopBtn.Location = new Point(295, 226);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(160, 60);
            stopBtn.TabIndex = 1;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            stopBtn.Click += stopBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(25, 130, 191);
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(500, 226);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(160, 60);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // countdownBtn
            // 
            countdownBtn.BackColor = Color.FromArgb(44, 64, 23);
            countdownBtn.FlatStyle = FlatStyle.Popup;
            countdownBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            countdownBtn.ForeColor = Color.White;
            countdownBtn.Location = new Point(198, 292);
            countdownBtn.Name = "countdownBtn";
            countdownBtn.Size = new Size(160, 60);
            countdownBtn.TabIndex = 3;
            countdownBtn.Text = "Countdown";
            countdownBtn.UseVisualStyleBackColor = false;
            countdownBtn.Click += countdownBtn_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.ForeColor = Color.White;
            timerLabel.Location = new Point(198, 9);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(353, 159);
            timerLabel.TabIndex = 4;
            timerLabel.Text = "00:00";
            timerLabel.Click += timerLabel_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(397, 292);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(160, 60);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "&Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // Question5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(786, 350);
            Controls.Add(exitBtn);
            Controls.Add(timerLabel);
            Controls.Add(countdownBtn);
            Controls.Add(resetBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Question5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stopwatch";
            Load += Question5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Button startBtn;
        private Button stopBtn;
        private Button resetBtn;
        private Button countdownBtn;
        private Label timerLabel;
        private Button exitBtn;
    }
}