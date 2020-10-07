namespace ChallengesUI
{
    partial class BinaryClockView
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
            this.components = new System.ComponentModel.Container();
            this.BackToAllButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTexBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.leftSU1 = new System.Windows.Forms.TextBox();
            this.leftSU2 = new System.Windows.Forms.TextBox();
            this.leftSU4 = new System.Windows.Forms.TextBox();
            this.leftSU8 = new System.Windows.Forms.TextBox();
            this.leftMU8 = new System.Windows.Forms.TextBox();
            this.leftMU4 = new System.Windows.Forms.TextBox();
            this.leftMU2 = new System.Windows.Forms.TextBox();
            this.leftMU1 = new System.Windows.Forms.TextBox();
            this.leftST4 = new System.Windows.Forms.TextBox();
            this.leftST2 = new System.Windows.Forms.TextBox();
            this.leftST1 = new System.Windows.Forms.TextBox();
            this.leftMT4 = new System.Windows.Forms.TextBox();
            this.leftMT2 = new System.Windows.Forms.TextBox();
            this.leftMT1 = new System.Windows.Forms.TextBox();
            this.leftHT2 = new System.Windows.Forms.TextBox();
            this.leftHT1 = new System.Windows.Forms.TextBox();
            this.leftHU8 = new System.Windows.Forms.TextBox();
            this.leftHU4 = new System.Windows.Forms.TextBox();
            this.leftHU2 = new System.Windows.Forms.TextBox();
            this.leftHU1 = new System.Windows.Forms.TextBox();
            this.rightHT2 = new System.Windows.Forms.TextBox();
            this.rightHT1 = new System.Windows.Forms.TextBox();
            this.rightHU8 = new System.Windows.Forms.TextBox();
            this.rightHU4 = new System.Windows.Forms.TextBox();
            this.rightHU2 = new System.Windows.Forms.TextBox();
            this.rightHU1 = new System.Windows.Forms.TextBox();
            this.rightMT4 = new System.Windows.Forms.TextBox();
            this.rightMT2 = new System.Windows.Forms.TextBox();
            this.rightMT1 = new System.Windows.Forms.TextBox();
            this.rightST4 = new System.Windows.Forms.TextBox();
            this.rightST2 = new System.Windows.Forms.TextBox();
            this.rightST1 = new System.Windows.Forms.TextBox();
            this.rightMU8 = new System.Windows.Forms.TextBox();
            this.rightMU4 = new System.Windows.Forms.TextBox();
            this.rightMU2 = new System.Windows.Forms.TextBox();
            this.rightMU1 = new System.Windows.Forms.TextBox();
            this.rightSU8 = new System.Windows.Forms.TextBox();
            this.rightSU4 = new System.Windows.Forms.TextBox();
            this.rightSU2 = new System.Windows.Forms.TextBox();
            this.rightSU1 = new System.Windows.Forms.TextBox();
            this.L1L = new System.Windows.Forms.Label();
            this.L2L = new System.Windows.Forms.Label();
            this.L8L = new System.Windows.Forms.Label();
            this.L4L = new System.Windows.Forms.Label();
            this.LH1L = new System.Windows.Forms.Label();
            this.LH2L = new System.Windows.Forms.Label();
            this.LM1L = new System.Windows.Forms.Label();
            this.LM2L = new System.Windows.Forms.Label();
            this.LS1L = new System.Windows.Forms.Label();
            this.LS2L = new System.Windows.Forms.Label();
            this.RS2L = new System.Windows.Forms.Label();
            this.RS1L = new System.Windows.Forms.Label();
            this.RM2L = new System.Windows.Forms.Label();
            this.RM1L = new System.Windows.Forms.Label();
            this.RH2L = new System.Windows.Forms.Label();
            this.RH1L = new System.Windows.Forms.Label();
            this.R8L = new System.Windows.Forms.Label();
            this.R4L = new System.Windows.Forms.Label();
            this.R2L = new System.Windows.Forms.Label();
            this.R1L = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ShowHideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 468);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(164, 45);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "";
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(720, 90);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(113, 40);
            this.timePicker.TabIndex = 1;
            this.timePicker.Value = new System.DateTime(2020, 10, 4, 0, 0, 0, 0);
            // 
            // timeTexBox
            // 
            this.timeTexBox.BackColor = System.Drawing.SystemColors.Window;
            this.timeTexBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.timeTexBox.Location = new System.Drawing.Point(187, 90);
            this.timeTexBox.Name = "timeTexBox";
            this.timeTexBox.ReadOnly = true;
            this.timeTexBox.Size = new System.Drawing.Size(95, 40);
            this.timeTexBox.TabIndex = 2;
            this.timeTexBox.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderLabel.Location = new System.Drawing.Point(426, 20);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(169, 37);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "Binary Clock";
            // 
            // leftSU1
            // 
            this.leftSU1.BackColor = System.Drawing.Color.Gray;
            this.leftSU1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftSU1.Location = new System.Drawing.Point(398, 357);
            this.leftSU1.Name = "leftSU1";
            this.leftSU1.ReadOnly = true;
            this.leftSU1.Size = new System.Drawing.Size(26, 26);
            this.leftSU1.TabIndex = 4;
            // 
            // leftSU2
            // 
            this.leftSU2.BackColor = System.Drawing.Color.Gray;
            this.leftSU2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftSU2.Location = new System.Drawing.Point(398, 308);
            this.leftSU2.Name = "leftSU2";
            this.leftSU2.ReadOnly = true;
            this.leftSU2.Size = new System.Drawing.Size(26, 26);
            this.leftSU2.TabIndex = 5;
            // 
            // leftSU4
            // 
            this.leftSU4.BackColor = System.Drawing.Color.Gray;
            this.leftSU4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftSU4.Location = new System.Drawing.Point(398, 259);
            this.leftSU4.Name = "leftSU4";
            this.leftSU4.ReadOnly = true;
            this.leftSU4.Size = new System.Drawing.Size(26, 26);
            this.leftSU4.TabIndex = 6;
            // 
            // leftSU8
            // 
            this.leftSU8.BackColor = System.Drawing.Color.Gray;
            this.leftSU8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftSU8.Location = new System.Drawing.Point(398, 210);
            this.leftSU8.Name = "leftSU8";
            this.leftSU8.ReadOnly = true;
            this.leftSU8.Size = new System.Drawing.Size(26, 26);
            this.leftSU8.TabIndex = 7;
            // 
            // leftMU8
            // 
            this.leftMU8.BackColor = System.Drawing.Color.Gray;
            this.leftMU8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMU8.Location = new System.Drawing.Point(256, 210);
            this.leftMU8.Name = "leftMU8";
            this.leftMU8.ReadOnly = true;
            this.leftMU8.Size = new System.Drawing.Size(26, 26);
            this.leftMU8.TabIndex = 15;
            // 
            // leftMU4
            // 
            this.leftMU4.BackColor = System.Drawing.Color.Gray;
            this.leftMU4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMU4.Location = new System.Drawing.Point(256, 259);
            this.leftMU4.Name = "leftMU4";
            this.leftMU4.ReadOnly = true;
            this.leftMU4.Size = new System.Drawing.Size(26, 26);
            this.leftMU4.TabIndex = 14;
            // 
            // leftMU2
            // 
            this.leftMU2.BackColor = System.Drawing.Color.Gray;
            this.leftMU2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMU2.Location = new System.Drawing.Point(256, 308);
            this.leftMU2.Name = "leftMU2";
            this.leftMU2.ReadOnly = true;
            this.leftMU2.Size = new System.Drawing.Size(26, 26);
            this.leftMU2.TabIndex = 13;
            // 
            // leftMU1
            // 
            this.leftMU1.BackColor = System.Drawing.Color.Gray;
            this.leftMU1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMU1.Location = new System.Drawing.Point(256, 357);
            this.leftMU1.Name = "leftMU1";
            this.leftMU1.ReadOnly = true;
            this.leftMU1.Size = new System.Drawing.Size(26, 26);
            this.leftMU1.TabIndex = 12;
            // 
            // leftST4
            // 
            this.leftST4.BackColor = System.Drawing.Color.Gray;
            this.leftST4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftST4.Location = new System.Drawing.Point(336, 259);
            this.leftST4.Name = "leftST4";
            this.leftST4.ReadOnly = true;
            this.leftST4.Size = new System.Drawing.Size(26, 26);
            this.leftST4.TabIndex = 18;
            // 
            // leftST2
            // 
            this.leftST2.BackColor = System.Drawing.Color.Gray;
            this.leftST2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftST2.Location = new System.Drawing.Point(336, 308);
            this.leftST2.Name = "leftST2";
            this.leftST2.ReadOnly = true;
            this.leftST2.Size = new System.Drawing.Size(26, 26);
            this.leftST2.TabIndex = 17;
            // 
            // leftST1
            // 
            this.leftST1.BackColor = System.Drawing.Color.Gray;
            this.leftST1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftST1.Location = new System.Drawing.Point(336, 357);
            this.leftST1.Name = "leftST1";
            this.leftST1.ReadOnly = true;
            this.leftST1.Size = new System.Drawing.Size(26, 26);
            this.leftST1.TabIndex = 16;
            // 
            // leftMT4
            // 
            this.leftMT4.BackColor = System.Drawing.Color.Gray;
            this.leftMT4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMT4.Location = new System.Drawing.Point(194, 259);
            this.leftMT4.Name = "leftMT4";
            this.leftMT4.ReadOnly = true;
            this.leftMT4.Size = new System.Drawing.Size(26, 26);
            this.leftMT4.TabIndex = 21;
            // 
            // leftMT2
            // 
            this.leftMT2.BackColor = System.Drawing.Color.Gray;
            this.leftMT2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMT2.Location = new System.Drawing.Point(194, 308);
            this.leftMT2.Name = "leftMT2";
            this.leftMT2.ReadOnly = true;
            this.leftMT2.Size = new System.Drawing.Size(26, 26);
            this.leftMT2.TabIndex = 20;
            // 
            // leftMT1
            // 
            this.leftMT1.BackColor = System.Drawing.Color.Gray;
            this.leftMT1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftMT1.Location = new System.Drawing.Point(194, 357);
            this.leftMT1.Name = "leftMT1";
            this.leftMT1.ReadOnly = true;
            this.leftMT1.Size = new System.Drawing.Size(26, 26);
            this.leftMT1.TabIndex = 19;
            // 
            // leftHT2
            // 
            this.leftHT2.BackColor = System.Drawing.Color.Gray;
            this.leftHT2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftHT2.Location = new System.Drawing.Point(52, 308);
            this.leftHT2.Name = "leftHT2";
            this.leftHT2.ReadOnly = true;
            this.leftHT2.Size = new System.Drawing.Size(26, 26);
            this.leftHT2.TabIndex = 27;
            // 
            // leftHT1
            // 
            this.leftHT1.BackColor = System.Drawing.Color.Gray;
            this.leftHT1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftHT1.Location = new System.Drawing.Point(52, 357);
            this.leftHT1.Name = "leftHT1";
            this.leftHT1.ReadOnly = true;
            this.leftHT1.Size = new System.Drawing.Size(26, 26);
            this.leftHT1.TabIndex = 26;
            // 
            // leftHU8
            // 
            this.leftHU8.BackColor = System.Drawing.Color.Gray;
            this.leftHU8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftHU8.Location = new System.Drawing.Point(114, 210);
            this.leftHU8.Name = "leftHU8";
            this.leftHU8.ReadOnly = true;
            this.leftHU8.Size = new System.Drawing.Size(26, 26);
            this.leftHU8.TabIndex = 25;
            // 
            // leftHU4
            // 
            this.leftHU4.BackColor = System.Drawing.Color.Gray;
            this.leftHU4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftHU4.Location = new System.Drawing.Point(114, 259);
            this.leftHU4.Name = "leftHU4";
            this.leftHU4.ReadOnly = true;
            this.leftHU4.Size = new System.Drawing.Size(26, 26);
            this.leftHU4.TabIndex = 24;
            // 
            // leftHU2
            // 
            this.leftHU2.BackColor = System.Drawing.Color.Gray;
            this.leftHU2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftHU2.Location = new System.Drawing.Point(114, 308);
            this.leftHU2.Name = "leftHU2";
            this.leftHU2.ReadOnly = true;
            this.leftHU2.Size = new System.Drawing.Size(26, 26);
            this.leftHU2.TabIndex = 23;
            // 
            // leftHU1
            // 
            this.leftHU1.BackColor = System.Drawing.Color.Gray;
            this.leftHU1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.leftHU1.Location = new System.Drawing.Point(114, 357);
            this.leftHU1.Name = "leftHU1";
            this.leftHU1.ReadOnly = true;
            this.leftHU1.Size = new System.Drawing.Size(26, 26);
            this.leftHU1.TabIndex = 22;
            // 
            // rightHT2
            // 
            this.rightHT2.BackColor = System.Drawing.Color.Gray;
            this.rightHT2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightHT2.Location = new System.Drawing.Point(603, 308);
            this.rightHT2.Name = "rightHT2";
            this.rightHT2.ReadOnly = true;
            this.rightHT2.Size = new System.Drawing.Size(26, 26);
            this.rightHT2.TabIndex = 47;
            // 
            // rightHT1
            // 
            this.rightHT1.BackColor = System.Drawing.Color.Gray;
            this.rightHT1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightHT1.Location = new System.Drawing.Point(603, 357);
            this.rightHT1.Name = "rightHT1";
            this.rightHT1.ReadOnly = true;
            this.rightHT1.Size = new System.Drawing.Size(26, 26);
            this.rightHT1.TabIndex = 46;
            // 
            // rightHU8
            // 
            this.rightHU8.BackColor = System.Drawing.Color.Gray;
            this.rightHU8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightHU8.Location = new System.Drawing.Point(665, 210);
            this.rightHU8.Name = "rightHU8";
            this.rightHU8.ReadOnly = true;
            this.rightHU8.Size = new System.Drawing.Size(26, 26);
            this.rightHU8.TabIndex = 45;
            // 
            // rightHU4
            // 
            this.rightHU4.BackColor = System.Drawing.Color.Gray;
            this.rightHU4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightHU4.Location = new System.Drawing.Point(665, 259);
            this.rightHU4.Name = "rightHU4";
            this.rightHU4.ReadOnly = true;
            this.rightHU4.Size = new System.Drawing.Size(26, 26);
            this.rightHU4.TabIndex = 44;
            // 
            // rightHU2
            // 
            this.rightHU2.BackColor = System.Drawing.Color.Gray;
            this.rightHU2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightHU2.Location = new System.Drawing.Point(665, 308);
            this.rightHU2.Name = "rightHU2";
            this.rightHU2.ReadOnly = true;
            this.rightHU2.Size = new System.Drawing.Size(26, 26);
            this.rightHU2.TabIndex = 43;
            // 
            // rightHU1
            // 
            this.rightHU1.BackColor = System.Drawing.Color.Gray;
            this.rightHU1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightHU1.Location = new System.Drawing.Point(665, 357);
            this.rightHU1.Name = "rightHU1";
            this.rightHU1.ReadOnly = true;
            this.rightHU1.Size = new System.Drawing.Size(26, 26);
            this.rightHU1.TabIndex = 42;
            // 
            // rightMT4
            // 
            this.rightMT4.BackColor = System.Drawing.Color.Gray;
            this.rightMT4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMT4.Location = new System.Drawing.Point(745, 259);
            this.rightMT4.Name = "rightMT4";
            this.rightMT4.ReadOnly = true;
            this.rightMT4.Size = new System.Drawing.Size(26, 26);
            this.rightMT4.TabIndex = 41;
            // 
            // rightMT2
            // 
            this.rightMT2.BackColor = System.Drawing.Color.Gray;
            this.rightMT2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMT2.Location = new System.Drawing.Point(745, 308);
            this.rightMT2.Name = "rightMT2";
            this.rightMT2.ReadOnly = true;
            this.rightMT2.Size = new System.Drawing.Size(26, 26);
            this.rightMT2.TabIndex = 40;
            // 
            // rightMT1
            // 
            this.rightMT1.BackColor = System.Drawing.Color.Gray;
            this.rightMT1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMT1.Location = new System.Drawing.Point(745, 357);
            this.rightMT1.Name = "rightMT1";
            this.rightMT1.ReadOnly = true;
            this.rightMT1.Size = new System.Drawing.Size(26, 26);
            this.rightMT1.TabIndex = 39;
            // 
            // rightST4
            // 
            this.rightST4.BackColor = System.Drawing.Color.Gray;
            this.rightST4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightST4.Location = new System.Drawing.Point(887, 259);
            this.rightST4.Name = "rightST4";
            this.rightST4.ReadOnly = true;
            this.rightST4.Size = new System.Drawing.Size(26, 26);
            this.rightST4.TabIndex = 38;
            // 
            // rightST2
            // 
            this.rightST2.BackColor = System.Drawing.Color.Gray;
            this.rightST2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightST2.Location = new System.Drawing.Point(887, 308);
            this.rightST2.Name = "rightST2";
            this.rightST2.ReadOnly = true;
            this.rightST2.Size = new System.Drawing.Size(26, 26);
            this.rightST2.TabIndex = 37;
            // 
            // rightST1
            // 
            this.rightST1.BackColor = System.Drawing.Color.Gray;
            this.rightST1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightST1.Location = new System.Drawing.Point(887, 357);
            this.rightST1.Name = "rightST1";
            this.rightST1.ReadOnly = true;
            this.rightST1.Size = new System.Drawing.Size(26, 26);
            this.rightST1.TabIndex = 36;
            // 
            // rightMU8
            // 
            this.rightMU8.BackColor = System.Drawing.Color.Gray;
            this.rightMU8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMU8.Location = new System.Drawing.Point(807, 210);
            this.rightMU8.Name = "rightMU8";
            this.rightMU8.ReadOnly = true;
            this.rightMU8.Size = new System.Drawing.Size(26, 26);
            this.rightMU8.TabIndex = 35;
            // 
            // rightMU4
            // 
            this.rightMU4.BackColor = System.Drawing.Color.Gray;
            this.rightMU4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMU4.Location = new System.Drawing.Point(807, 259);
            this.rightMU4.Name = "rightMU4";
            this.rightMU4.ReadOnly = true;
            this.rightMU4.Size = new System.Drawing.Size(26, 26);
            this.rightMU4.TabIndex = 34;
            // 
            // rightMU2
            // 
            this.rightMU2.BackColor = System.Drawing.Color.Gray;
            this.rightMU2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMU2.Location = new System.Drawing.Point(807, 308);
            this.rightMU2.Name = "rightMU2";
            this.rightMU2.ReadOnly = true;
            this.rightMU2.Size = new System.Drawing.Size(26, 26);
            this.rightMU2.TabIndex = 33;
            // 
            // rightMU1
            // 
            this.rightMU1.BackColor = System.Drawing.Color.Gray;
            this.rightMU1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightMU1.Location = new System.Drawing.Point(807, 357);
            this.rightMU1.Name = "rightMU1";
            this.rightMU1.ReadOnly = true;
            this.rightMU1.Size = new System.Drawing.Size(26, 26);
            this.rightMU1.TabIndex = 32;
            // 
            // rightSU8
            // 
            this.rightSU8.BackColor = System.Drawing.Color.Gray;
            this.rightSU8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightSU8.Location = new System.Drawing.Point(949, 210);
            this.rightSU8.Name = "rightSU8";
            this.rightSU8.ReadOnly = true;
            this.rightSU8.Size = new System.Drawing.Size(26, 26);
            this.rightSU8.TabIndex = 31;
            // 
            // rightSU4
            // 
            this.rightSU4.BackColor = System.Drawing.Color.Gray;
            this.rightSU4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightSU4.Location = new System.Drawing.Point(949, 259);
            this.rightSU4.Name = "rightSU4";
            this.rightSU4.ReadOnly = true;
            this.rightSU4.Size = new System.Drawing.Size(26, 26);
            this.rightSU4.TabIndex = 30;
            // 
            // rightSU2
            // 
            this.rightSU2.BackColor = System.Drawing.Color.Gray;
            this.rightSU2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightSU2.Location = new System.Drawing.Point(949, 308);
            this.rightSU2.Name = "rightSU2";
            this.rightSU2.ReadOnly = true;
            this.rightSU2.Size = new System.Drawing.Size(26, 26);
            this.rightSU2.TabIndex = 29;
            // 
            // rightSU1
            // 
            this.rightSU1.BackColor = System.Drawing.Color.Gray;
            this.rightSU1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rightSU1.Location = new System.Drawing.Point(949, 357);
            this.rightSU1.Name = "rightSU1";
            this.rightSU1.ReadOnly = true;
            this.rightSU1.Size = new System.Drawing.Size(26, 26);
            this.rightSU1.TabIndex = 28;
            // 
            // L1L
            // 
            this.L1L.AutoSize = true;
            this.L1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.L1L.Location = new System.Drawing.Point(24, 358);
            this.L1L.Name = "L1L";
            this.L1L.Size = new System.Drawing.Size(22, 25);
            this.L1L.TabIndex = 48;
            this.L1L.Tag = "help";
            this.L1L.Text = "1";
            this.L1L.Visible = false;
            // 
            // L2L
            // 
            this.L2L.AutoSize = true;
            this.L2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.L2L.Location = new System.Drawing.Point(24, 309);
            this.L2L.Name = "L2L";
            this.L2L.Size = new System.Drawing.Size(22, 25);
            this.L2L.TabIndex = 49;
            this.L2L.Tag = "help";
            this.L2L.Text = "2";
            this.L2L.Visible = false;
            // 
            // L8L
            // 
            this.L8L.AutoSize = true;
            this.L8L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.L8L.Location = new System.Drawing.Point(24, 211);
            this.L8L.Name = "L8L";
            this.L8L.Size = new System.Drawing.Size(22, 25);
            this.L8L.TabIndex = 51;
            this.L8L.Tag = "help";
            this.L8L.Text = "8";
            this.L8L.Visible = false;
            // 
            // L4L
            // 
            this.L4L.AutoSize = true;
            this.L4L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.L4L.Location = new System.Drawing.Point(24, 260);
            this.L4L.Name = "L4L";
            this.L4L.Size = new System.Drawing.Size(22, 25);
            this.L4L.TabIndex = 50;
            this.L4L.Tag = "help";
            this.L4L.Text = "4";
            this.L4L.Visible = false;
            // 
            // LH1L
            // 
            this.LH1L.AutoSize = true;
            this.LH1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LH1L.Location = new System.Drawing.Point(53, 386);
            this.LH1L.Name = "LH1L";
            this.LH1L.Size = new System.Drawing.Size(25, 25);
            this.LH1L.TabIndex = 52;
            this.LH1L.Tag = "help";
            this.LH1L.Text = "H";
            this.LH1L.Visible = false;
            // 
            // LH2L
            // 
            this.LH2L.AutoSize = true;
            this.LH2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LH2L.Location = new System.Drawing.Point(115, 386);
            this.LH2L.Name = "LH2L";
            this.LH2L.Size = new System.Drawing.Size(25, 25);
            this.LH2L.TabIndex = 53;
            this.LH2L.Tag = "help";
            this.LH2L.Text = "H";
            this.LH2L.Visible = false;
            // 
            // LM1L
            // 
            this.LM1L.AutoSize = true;
            this.LM1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LM1L.Location = new System.Drawing.Point(195, 386);
            this.LM1L.Name = "LM1L";
            this.LM1L.Size = new System.Drawing.Size(29, 25);
            this.LM1L.TabIndex = 54;
            this.LM1L.Tag = "help";
            this.LM1L.Text = "M";
            this.LM1L.Visible = false;
            // 
            // LM2L
            // 
            this.LM2L.AutoSize = true;
            this.LM2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LM2L.Location = new System.Drawing.Point(257, 386);
            this.LM2L.Name = "LM2L";
            this.LM2L.Size = new System.Drawing.Size(29, 25);
            this.LM2L.TabIndex = 55;
            this.LM2L.Tag = "help";
            this.LM2L.Text = "M";
            this.LM2L.Visible = false;
            // 
            // LS1L
            // 
            this.LS1L.AutoSize = true;
            this.LS1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LS1L.Location = new System.Drawing.Point(337, 386);
            this.LS1L.Name = "LS1L";
            this.LS1L.Size = new System.Drawing.Size(22, 25);
            this.LS1L.TabIndex = 56;
            this.LS1L.Tag = "help";
            this.LS1L.Text = "S";
            this.LS1L.Visible = false;
            // 
            // LS2L
            // 
            this.LS2L.AutoSize = true;
            this.LS2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.LS2L.Location = new System.Drawing.Point(399, 386);
            this.LS2L.Name = "LS2L";
            this.LS2L.Size = new System.Drawing.Size(22, 25);
            this.LS2L.TabIndex = 57;
            this.LS2L.Tag = "help";
            this.LS2L.Text = "S";
            this.LS2L.Visible = false;
            // 
            // RS2L
            // 
            this.RS2L.AutoSize = true;
            this.RS2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.RS2L.Location = new System.Drawing.Point(950, 386);
            this.RS2L.Name = "RS2L";
            this.RS2L.Size = new System.Drawing.Size(22, 25);
            this.RS2L.TabIndex = 63;
            this.RS2L.Tag = "help";
            this.RS2L.Text = "S";
            this.RS2L.Visible = false;
            // 
            // RS1L
            // 
            this.RS1L.AutoSize = true;
            this.RS1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.RS1L.Location = new System.Drawing.Point(888, 386);
            this.RS1L.Name = "RS1L";
            this.RS1L.Size = new System.Drawing.Size(22, 25);
            this.RS1L.TabIndex = 62;
            this.RS1L.Tag = "help";
            this.RS1L.Text = "S";
            this.RS1L.Visible = false;
            // 
            // RM2L
            // 
            this.RM2L.AutoSize = true;
            this.RM2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.RM2L.Location = new System.Drawing.Point(808, 386);
            this.RM2L.Name = "RM2L";
            this.RM2L.Size = new System.Drawing.Size(29, 25);
            this.RM2L.TabIndex = 61;
            this.RM2L.Tag = "help";
            this.RM2L.Text = "M";
            this.RM2L.Visible = false;
            // 
            // RM1L
            // 
            this.RM1L.AutoSize = true;
            this.RM1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.RM1L.Location = new System.Drawing.Point(746, 386);
            this.RM1L.Name = "RM1L";
            this.RM1L.Size = new System.Drawing.Size(29, 25);
            this.RM1L.TabIndex = 60;
            this.RM1L.Tag = "help";
            this.RM1L.Text = "M";
            this.RM1L.Visible = false;
            // 
            // RH2L
            // 
            this.RH2L.AutoSize = true;
            this.RH2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.RH2L.Location = new System.Drawing.Point(666, 386);
            this.RH2L.Name = "RH2L";
            this.RH2L.Size = new System.Drawing.Size(25, 25);
            this.RH2L.TabIndex = 59;
            this.RH2L.Tag = "help";
            this.RH2L.Text = "H";
            this.RH2L.Visible = false;
            // 
            // RH1L
            // 
            this.RH1L.AutoSize = true;
            this.RH1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.RH1L.Location = new System.Drawing.Point(604, 386);
            this.RH1L.Name = "RH1L";
            this.RH1L.Size = new System.Drawing.Size(25, 25);
            this.RH1L.TabIndex = 58;
            this.RH1L.Tag = "help";
            this.RH1L.Text = "H";
            this.RH1L.Visible = false;
            // 
            // R8L
            // 
            this.R8L.AutoSize = true;
            this.R8L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.R8L.Location = new System.Drawing.Point(575, 211);
            this.R8L.Name = "R8L";
            this.R8L.Size = new System.Drawing.Size(22, 25);
            this.R8L.TabIndex = 67;
            this.R8L.Tag = "help";
            this.R8L.Text = "8";
            this.R8L.Visible = false;
            // 
            // R4L
            // 
            this.R4L.AutoSize = true;
            this.R4L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.R4L.Location = new System.Drawing.Point(575, 260);
            this.R4L.Name = "R4L";
            this.R4L.Size = new System.Drawing.Size(22, 25);
            this.R4L.TabIndex = 66;
            this.R4L.Tag = "help";
            this.R4L.Text = "4";
            this.R4L.Visible = false;
            // 
            // R2L
            // 
            this.R2L.AutoSize = true;
            this.R2L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.R2L.Location = new System.Drawing.Point(575, 309);
            this.R2L.Name = "R2L";
            this.R2L.Size = new System.Drawing.Size(22, 25);
            this.R2L.TabIndex = 65;
            this.R2L.Tag = "help";
            this.R2L.Text = "2";
            this.R2L.Visible = false;
            // 
            // R1L
            // 
            this.R1L.AutoSize = true;
            this.R1L.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.R1L.Location = new System.Drawing.Point(575, 358);
            this.R1L.Name = "R1L";
            this.R1L.Size = new System.Drawing.Size(22, 25);
            this.R1L.TabIndex = 64;
            this.R1L.Tag = "help";
            this.R1L.Text = "1";
            this.R1L.Visible = false;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.ConvertButton.Location = new System.Drawing.Point(839, 90);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(99, 40);
            this.ConvertButton.TabIndex = 68;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ShowHideButton
            // 
            this.ShowHideButton.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.ShowHideButton.Location = new System.Drawing.Point(458, 386);
            this.ShowHideButton.Name = "ShowHideButton";
            this.ShowHideButton.Size = new System.Drawing.Size(105, 40);
            this.ShowHideButton.TabIndex = 69;
            this.ShowHideButton.Text = "show/hide";
            this.ShowHideButton.UseVisualStyleBackColor = true;
            this.ShowHideButton.Click += new System.EventHandler(this.ShowHideButton_Click);
            // 
            // BinaryClockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 525);
            this.Controls.Add(this.ShowHideButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.R8L);
            this.Controls.Add(this.R4L);
            this.Controls.Add(this.R2L);
            this.Controls.Add(this.R1L);
            this.Controls.Add(this.RS2L);
            this.Controls.Add(this.RS1L);
            this.Controls.Add(this.RM2L);
            this.Controls.Add(this.RM1L);
            this.Controls.Add(this.RH2L);
            this.Controls.Add(this.RH1L);
            this.Controls.Add(this.LS2L);
            this.Controls.Add(this.LS1L);
            this.Controls.Add(this.LM2L);
            this.Controls.Add(this.LM1L);
            this.Controls.Add(this.LH2L);
            this.Controls.Add(this.LH1L);
            this.Controls.Add(this.L8L);
            this.Controls.Add(this.L4L);
            this.Controls.Add(this.L2L);
            this.Controls.Add(this.L1L);
            this.Controls.Add(this.rightHT2);
            this.Controls.Add(this.rightHT1);
            this.Controls.Add(this.rightHU8);
            this.Controls.Add(this.rightHU4);
            this.Controls.Add(this.rightHU2);
            this.Controls.Add(this.rightHU1);
            this.Controls.Add(this.rightMT4);
            this.Controls.Add(this.rightMT2);
            this.Controls.Add(this.rightMT1);
            this.Controls.Add(this.rightST4);
            this.Controls.Add(this.rightST2);
            this.Controls.Add(this.rightST1);
            this.Controls.Add(this.rightMU8);
            this.Controls.Add(this.rightMU4);
            this.Controls.Add(this.rightMU2);
            this.Controls.Add(this.rightMU1);
            this.Controls.Add(this.rightSU8);
            this.Controls.Add(this.rightSU4);
            this.Controls.Add(this.rightSU2);
            this.Controls.Add(this.rightSU1);
            this.Controls.Add(this.leftHT2);
            this.Controls.Add(this.leftHT1);
            this.Controls.Add(this.leftHU8);
            this.Controls.Add(this.leftHU4);
            this.Controls.Add(this.leftHU2);
            this.Controls.Add(this.leftHU1);
            this.Controls.Add(this.leftMT4);
            this.Controls.Add(this.leftMT2);
            this.Controls.Add(this.leftMT1);
            this.Controls.Add(this.leftST4);
            this.Controls.Add(this.leftST2);
            this.Controls.Add(this.leftST1);
            this.Controls.Add(this.leftMU8);
            this.Controls.Add(this.leftMU4);
            this.Controls.Add(this.leftMU2);
            this.Controls.Add(this.leftMU1);
            this.Controls.Add(this.leftSU8);
            this.Controls.Add(this.leftSU4);
            this.Controls.Add(this.leftSU2);
            this.Controls.Add(this.leftSU1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.timeTexBox);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "BinaryClockView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox timeTexBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox leftSU1;
        private System.Windows.Forms.TextBox leftSU2;
        private System.Windows.Forms.TextBox leftSU4;
        private System.Windows.Forms.TextBox leftSU8;
        private System.Windows.Forms.TextBox leftMU8;
        private System.Windows.Forms.TextBox leftMU4;
        private System.Windows.Forms.TextBox leftMU2;
        private System.Windows.Forms.TextBox leftMU1;
        private System.Windows.Forms.TextBox leftST4;
        private System.Windows.Forms.TextBox leftST2;
        private System.Windows.Forms.TextBox leftST1;
        private System.Windows.Forms.TextBox leftMT4;
        private System.Windows.Forms.TextBox leftMT2;
        private System.Windows.Forms.TextBox leftMT1;
        private System.Windows.Forms.TextBox leftHT2;
        private System.Windows.Forms.TextBox leftHT1;
        private System.Windows.Forms.TextBox leftHU8;
        private System.Windows.Forms.TextBox leftHU4;
        private System.Windows.Forms.TextBox leftHU2;
        private System.Windows.Forms.TextBox leftHU1;
        private System.Windows.Forms.TextBox rightHT2;
        private System.Windows.Forms.TextBox rightHT1;
        private System.Windows.Forms.TextBox rightHU8;
        private System.Windows.Forms.TextBox rightHU4;
        private System.Windows.Forms.TextBox rightHU2;
        private System.Windows.Forms.TextBox rightHU1;
        private System.Windows.Forms.TextBox rightMT4;
        private System.Windows.Forms.TextBox rightMT2;
        private System.Windows.Forms.TextBox rightMT1;
        private System.Windows.Forms.TextBox rightST4;
        private System.Windows.Forms.TextBox rightST2;
        private System.Windows.Forms.TextBox rightST1;
        private System.Windows.Forms.TextBox rightMU8;
        private System.Windows.Forms.TextBox rightMU4;
        private System.Windows.Forms.TextBox rightMU2;
        private System.Windows.Forms.TextBox rightMU1;
        private System.Windows.Forms.TextBox rightSU8;
        private System.Windows.Forms.TextBox rightSU4;
        private System.Windows.Forms.TextBox rightSU2;
        private System.Windows.Forms.TextBox rightSU1;
        private System.Windows.Forms.Label L1L;
        private System.Windows.Forms.Label L2L;
        private System.Windows.Forms.Label L8L;
        private System.Windows.Forms.Label L4L;
        private System.Windows.Forms.Label LH1L;
        private System.Windows.Forms.Label LH2L;
        private System.Windows.Forms.Label LM1L;
        private System.Windows.Forms.Label LM2L;
        private System.Windows.Forms.Label LS1L;
        private System.Windows.Forms.Label LS2L;
        private System.Windows.Forms.Label RS2L;
        private System.Windows.Forms.Label RS1L;
        private System.Windows.Forms.Label RM2L;
        private System.Windows.Forms.Label RM1L;
        private System.Windows.Forms.Label RH2L;
        private System.Windows.Forms.Label RH1L;
        private System.Windows.Forms.Label R8L;
        private System.Windows.Forms.Label R4L;
        private System.Windows.Forms.Label R2L;
        private System.Windows.Forms.Label R1L;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ShowHideButton;
    }
}