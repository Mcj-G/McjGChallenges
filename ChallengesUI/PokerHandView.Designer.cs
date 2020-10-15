namespace ChallengesUI
{
    partial class PokerHandView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokerHandView));
            this.BackToAllButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTexBox = new System.Windows.Forms.TextBox();
            this.ColrLabel = new System.Windows.Forms.Label();
            this.HeartsCheckBox = new System.Windows.Forms.CheckBox();
            this.DiamondsCheckBox = new System.Windows.Forms.CheckBox();
            this.ClubsCheckBox = new System.Windows.Forms.CheckBox();
            this.SpadesCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonK = new System.Windows.Forms.Button();
            this.ButtonQ = new System.Windows.Forms.Button();
            this.ButtonJ = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.CardsLabel = new System.Windows.Forms.Label();
            this.CardsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 619);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(182, 42);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.Location = new System.Drawing.Point(467, 15);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(133, 32);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Desription:";
            // 
            // DescriptionTexBox
            // 
            this.DescriptionTexBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionTexBox.Location = new System.Drawing.Point(12, 62);
            this.DescriptionTexBox.Multiline = true;
            this.DescriptionTexBox.Name = "DescriptionTexBox";
            this.DescriptionTexBox.ReadOnly = true;
            this.DescriptionTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTexBox.Size = new System.Drawing.Size(1043, 161);
            this.DescriptionTexBox.TabIndex = 4;
            this.DescriptionTexBox.Text = resources.GetString("DescriptionTexBox.Text");
            // 
            // ColrLabel
            // 
            this.ColrLabel.AutoSize = true;
            this.ColrLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ColrLabel.Location = new System.Drawing.Point(12, 247);
            this.ColrLabel.Name = "ColrLabel";
            this.ColrLabel.Size = new System.Drawing.Size(114, 32);
            this.ColrLabel.TabIndex = 6;
            this.ColrLabel.Text = "Set color:";
            // 
            // HeartsCheckBox
            // 
            this.HeartsCheckBox.AutoSize = true;
            this.HeartsCheckBox.Checked = true;
            this.HeartsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeartsCheckBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.HeartsCheckBox.Location = new System.Drawing.Point(203, 242);
            this.HeartsCheckBox.Name = "HeartsCheckBox";
            this.HeartsCheckBox.Size = new System.Drawing.Size(102, 39);
            this.HeartsCheckBox.TabIndex = 7;
            this.HeartsCheckBox.Text = "hearts";
            this.HeartsCheckBox.UseVisualStyleBackColor = true;
            this.HeartsCheckBox.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // DiamondsCheckBox
            // 
            this.DiamondsCheckBox.AutoSize = true;
            this.DiamondsCheckBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.DiamondsCheckBox.Location = new System.Drawing.Point(375, 242);
            this.DiamondsCheckBox.Name = "DiamondsCheckBox";
            this.DiamondsCheckBox.Size = new System.Drawing.Size(145, 39);
            this.DiamondsCheckBox.TabIndex = 8;
            this.DiamondsCheckBox.Text = "diamonds";
            this.DiamondsCheckBox.UseVisualStyleBackColor = true;
            this.DiamondsCheckBox.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // ClubsCheckBox
            // 
            this.ClubsCheckBox.AutoSize = true;
            this.ClubsCheckBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.ClubsCheckBox.Location = new System.Drawing.Point(590, 242);
            this.ClubsCheckBox.Name = "ClubsCheckBox";
            this.ClubsCheckBox.Size = new System.Drawing.Size(92, 39);
            this.ClubsCheckBox.TabIndex = 9;
            this.ClubsCheckBox.Text = "clubs";
            this.ClubsCheckBox.UseVisualStyleBackColor = true;
            this.ClubsCheckBox.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // SpadesCheckBox
            // 
            this.SpadesCheckBox.AutoSize = true;
            this.SpadesCheckBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.SpadesCheckBox.Location = new System.Drawing.Point(752, 240);
            this.SpadesCheckBox.Name = "SpadesCheckBox";
            this.SpadesCheckBox.Size = new System.Drawing.Size(112, 39);
            this.SpadesCheckBox.TabIndex = 10;
            this.SpadesCheckBox.Text = "spades";
            this.SpadesCheckBox.UseVisualStyleBackColor = true;
            this.SpadesCheckBox.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // ButtonA
            // 
            this.ButtonA.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonA.Location = new System.Drawing.Point(273, 310);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(86, 45);
            this.ButtonA.TabIndex = 11;
            this.ButtonA.Text = "Ace";
            this.ButtonA.UseVisualStyleBackColor = true;
            this.ButtonA.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // ButtonK
            // 
            this.ButtonK.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonK.Location = new System.Drawing.Point(418, 310);
            this.ButtonK.Name = "ButtonK";
            this.ButtonK.Size = new System.Drawing.Size(86, 45);
            this.ButtonK.TabIndex = 12;
            this.ButtonK.Text = "King";
            this.ButtonK.UseVisualStyleBackColor = true;
            this.ButtonK.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // ButtonQ
            // 
            this.ButtonQ.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonQ.Location = new System.Drawing.Point(563, 310);
            this.ButtonQ.Name = "ButtonQ";
            this.ButtonQ.Size = new System.Drawing.Size(86, 45);
            this.ButtonQ.TabIndex = 13;
            this.ButtonQ.Text = "Queen";
            this.ButtonQ.UseVisualStyleBackColor = true;
            this.ButtonQ.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // ButtonJ
            // 
            this.ButtonJ.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ButtonJ.Location = new System.Drawing.Point(708, 310);
            this.ButtonJ.Name = "ButtonJ";
            this.ButtonJ.Size = new System.Drawing.Size(86, 45);
            this.ButtonJ.TabIndex = 14;
            this.ButtonJ.Text = "Jack";
            this.ButtonJ.UseVisualStyleBackColor = true;
            this.ButtonJ.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button10
            // 
            this.Button10.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button10.Location = new System.Drawing.Point(248, 380);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(86, 45);
            this.Button10.TabIndex = 15;
            this.Button10.Text = "10";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button9.Location = new System.Drawing.Point(369, 380);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(86, 45);
            this.Button9.TabIndex = 16;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button8.Location = new System.Drawing.Point(490, 380);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(86, 45);
            this.Button8.TabIndex = 17;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button7.Location = new System.Drawing.Point(611, 380);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(86, 45);
            this.Button7.TabIndex = 18;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button6.Location = new System.Drawing.Point(732, 380);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(86, 45);
            this.Button6.TabIndex = 19;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button5.Location = new System.Drawing.Point(273, 450);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(86, 45);
            this.Button5.TabIndex = 20;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button4.Location = new System.Drawing.Point(418, 450);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(86, 45);
            this.Button4.TabIndex = 21;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button3.Location = new System.Drawing.Point(563, 450);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(86, 45);
            this.Button3.TabIndex = 22;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Button2.Location = new System.Drawing.Point(708, 450);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(86, 45);
            this.Button2.TabIndex = 23;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // CardsLabel
            // 
            this.CardsLabel.AutoSize = true;
            this.CardsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardsLabel.Location = new System.Drawing.Point(6, 546);
            this.CardsLabel.Name = "CardsLabel";
            this.CardsLabel.Size = new System.Drawing.Size(129, 32);
            this.CardsLabel.TabIndex = 24;
            this.CardsLabel.Text = "Your cards:";
            // 
            // CardsTextBox
            // 
            this.CardsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CardsTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.CardsTextBox.Location = new System.Drawing.Point(141, 543);
            this.CardsTextBox.Name = "CardsTextBox";
            this.CardsTextBox.ReadOnly = true;
            this.CardsTextBox.Size = new System.Drawing.Size(246, 40);
            this.CardsTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(679, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Result:";
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.CheckButton.Location = new System.Drawing.Point(478, 538);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(110, 45);
            this.CheckButton.TabIndex = 27;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.ResultTextBox.Location = new System.Drawing.Point(771, 540);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(246, 40);
            this.ResultTextBox.TabIndex = 28;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.ClearButton.Location = new System.Drawing.Point(277, 589);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(110, 39);
            this.ClearButton.TabIndex = 29;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PokerHandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 673);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardsTextBox);
            this.Controls.Add(this.CardsLabel);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.ButtonJ);
            this.Controls.Add(this.ButtonQ);
            this.Controls.Add(this.ButtonK);
            this.Controls.Add(this.ButtonA);
            this.Controls.Add(this.SpadesCheckBox);
            this.Controls.Add(this.ClubsCheckBox);
            this.Controls.Add(this.DiamondsCheckBox);
            this.Controls.Add(this.HeartsCheckBox);
            this.Controls.Add(this.ColrLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTexBox);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "PokerHandView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Hand Ranking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTexBox;
        private System.Windows.Forms.Label ColrLabel;
        private System.Windows.Forms.CheckBox HeartsCheckBox;
        private System.Windows.Forms.CheckBox DiamondsCheckBox;
        private System.Windows.Forms.CheckBox ClubsCheckBox;
        private System.Windows.Forms.CheckBox SpadesCheckBox;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonK;
        private System.Windows.Forms.Button ButtonQ;
        private System.Windows.Forms.Button ButtonJ;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label CardsLabel;
        private System.Windows.Forms.TextBox CardsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ClearButton;
    }
}