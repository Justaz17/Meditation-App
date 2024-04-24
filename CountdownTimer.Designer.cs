namespace Lab1
{
    partial class CountdownTimer
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
            timerLabel = new Label();
            selectBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            startBtn = new Button();
            stopBtn = new Button();
            exitBtn = new Button();
            resetBtn = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            radioButton4 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.FlatStyle = FlatStyle.Popup;
            timerLabel.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point);
            timerLabel.ForeColor = Color.White;
            timerLabel.Location = new Point(355, 93);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(363, 135);
            timerLabel.TabIndex = 0;
            timerLabel.Text = "00:00";
            timerLabel.Click += label1_Click;
            // 
            // selectBox
            // 
            selectBox.FormattingEnabled = true;
            selectBox.Items.AddRange(new object[] { "Seconds", "Minutes" });
            selectBox.Location = new Point(180, 93);
            selectBox.Name = "selectBox";
            selectBox.Size = new Size(151, 26);
            selectBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 188);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 4;
            label2.Text = "Countdown :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 96);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 6;
            label3.Text = "Please select :";
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(0, 205, 51);
            startBtn.FlatStyle = FlatStyle.Popup;
            startBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(237, 268);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(160, 60);
            startBtn.TabIndex = 7;
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
            stopBtn.Location = new Point(403, 268);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(160, 60);
            stopBtn.TabIndex = 8;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            stopBtn.Click += stopBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(365, 334);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(239, 60);
            exitBtn.TabIndex = 9;
            exitBtn.Text = "&Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(25, 130, 191);
            resetBtn.FlatStyle = FlatStyle.Popup;
            resetBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(569, 268);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(160, 60);
            resetBtn.TabIndex = 10;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ActiveCaption;
            radioButton1.Location = new Point(841, 240);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 22);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Dark";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ActiveCaption;
            radioButton2.Location = new Point(841, 284);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 22);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Green";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.ActiveCaption;
            radioButton3.Location = new Point(841, 330);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(62, 22);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Blue";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(759, 301);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 14;
            label1.Text = "Theme";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = SystemColors.ActiveCaption;
            radioButton4.Location = new Point(841, 368);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 22);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Default";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(181, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 24);
            numericUpDown1.TabIndex = 16;
            // 
            // Question5pt2
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1000, 405);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton4);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(resetBtn);
            Controls.Add(exitBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selectBox);
            Controls.Add(timerLabel);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Question5pt2";
            Text = "Countdown";
            Load += Question5pt2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timerLabel;
        private ComboBox selectBox;
        private Label label2;
        private Label label3;
        private Button startBtn;
        private Button stopBtn;
        private Button exitBtn;
        private Button resetBtn;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private RadioButton radioButton4;
        private NumericUpDown numericUpDown1;
    }
}