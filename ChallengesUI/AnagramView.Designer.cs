namespace ChallengesUI
{
    partial class AnagramView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnagramView));
            this.BackToAllButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.FalseLabel = new System.Windows.Forms.Label();
            this.TrueLabel = new System.Windows.Forms.Label();
            this.FalseTexBox = new System.Windows.Forms.TextBox();
            this.TrueTextBox = new System.Windows.Forms.TextBox();
            this.HaystackLabel = new System.Windows.Forms.Label();
            this.NeedleLabel = new System.Windows.Forms.Label();
            this.haystackTextBox = new System.Windows.Forms.TextBox();
            this.needleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 410);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(160, 43);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.CheckButton.Location = new System.Drawing.Point(504, 280);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(108, 45);
            this.CheckButton.TabIndex = 28;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // FalseLabel
            // 
            this.FalseLabel.AutoSize = true;
            this.FalseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FalseLabel.Location = new System.Drawing.Point(685, 308);
            this.FalseLabel.Name = "FalseLabel";
            this.FalseLabel.Size = new System.Drawing.Size(76, 31);
            this.FalseLabel.TabIndex = 27;
            this.FalseLabel.Text = "FALSE";
            // 
            // TrueLabel
            // 
            this.TrueLabel.AutoSize = true;
            this.TrueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrueLabel.Location = new System.Drawing.Point(685, 266);
            this.TrueLabel.Name = "TrueLabel";
            this.TrueLabel.Size = new System.Drawing.Size(69, 31);
            this.TrueLabel.TabIndex = 26;
            this.TrueLabel.Text = "TRUE";
            // 
            // FalseTexBox
            // 
            this.FalseTexBox.BackColor = System.Drawing.Color.Gray;
            this.FalseTexBox.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.FalseTexBox.Location = new System.Drawing.Point(644, 306);
            this.FalseTexBox.Name = "FalseTexBox";
            this.FalseTexBox.ReadOnly = true;
            this.FalseTexBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FalseTexBox.Size = new System.Drawing.Size(35, 36);
            this.FalseTexBox.TabIndex = 25;
            this.FalseTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrueTextBox
            // 
            this.TrueTextBox.BackColor = System.Drawing.Color.Gray;
            this.TrueTextBox.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.TrueTextBox.Location = new System.Drawing.Point(644, 264);
            this.TrueTextBox.Name = "TrueTextBox";
            this.TrueTextBox.ReadOnly = true;
            this.TrueTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrueTextBox.Size = new System.Drawing.Size(35, 36);
            this.TrueTextBox.TabIndex = 24;
            this.TrueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HaystackLabel
            // 
            this.HaystackLabel.AutoSize = true;
            this.HaystackLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.HaystackLabel.Location = new System.Drawing.Point(45, 317);
            this.HaystackLabel.Name = "HaystackLabel";
            this.HaystackLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HaystackLabel.Size = new System.Drawing.Size(119, 35);
            this.HaystackLabel.TabIndex = 23;
            this.HaystackLabel.Text = "Haystack:";
            // 
            // NeedleLabel
            // 
            this.NeedleLabel.AutoSize = true;
            this.NeedleLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.NeedleLabel.Location = new System.Drawing.Point(65, 247);
            this.NeedleLabel.Name = "NeedleLabel";
            this.NeedleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NeedleLabel.Size = new System.Drawing.Size(99, 35);
            this.NeedleLabel.TabIndex = 22;
            this.NeedleLabel.Text = "Needle:";
            // 
            // haystackTextBox
            // 
            this.haystackTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.haystackTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.haystackTextBox.Location = new System.Drawing.Point(170, 317);
            this.haystackTextBox.Name = "haystackTextBox";
            this.haystackTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.haystackTextBox.Size = new System.Drawing.Size(291, 40);
            this.haystackTextBox.TabIndex = 19;
            this.haystackTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.haystackTextBox_KeyDown);
            // 
            // needleTextBox
            // 
            this.needleTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.needleTextBox.Location = new System.Drawing.Point(170, 244);
            this.needleTextBox.Name = "needleTextBox";
            this.needleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.needleTextBox.Size = new System.Drawing.Size(291, 40);
            this.needleTextBox.TabIndex = 18;
            this.needleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.needleTextBox_KeyDown);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.Location = new System.Drawing.Point(349, 20);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(133, 32);
            this.DescriptionLabel.TabIndex = 21;
            this.DescriptionLabel.Text = "Desription:";
            // 
            // DescriptionTexBox
            // 
            this.DescriptionTexBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionTexBox.Location = new System.Drawing.Point(26, 66);
            this.DescriptionTexBox.Multiline = true;
            this.DescriptionTexBox.Name = "DescriptionTexBox";
            this.DescriptionTexBox.ReadOnly = true;
            this.DescriptionTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTexBox.Size = new System.Drawing.Size(779, 130);
            this.DescriptionTexBox.TabIndex = 20;
            this.DescriptionTexBox.Text = resources.GetString("DescriptionTexBox.Text");
            // 
            // AnagramView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 465);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.FalseLabel);
            this.Controls.Add(this.TrueLabel);
            this.Controls.Add(this.FalseTexBox);
            this.Controls.Add(this.TrueTextBox);
            this.Controls.Add(this.HaystackLabel);
            this.Controls.Add(this.NeedleLabel);
            this.Controls.Add(this.haystackTextBox);
            this.Controls.Add(this.needleTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTexBox);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "AnagramView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anagram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label FalseLabel;
        private System.Windows.Forms.Label TrueLabel;
        private System.Windows.Forms.TextBox FalseTexBox;
        private System.Windows.Forms.TextBox TrueTextBox;
        private System.Windows.Forms.Label HaystackLabel;
        private System.Windows.Forms.Label NeedleLabel;
        private System.Windows.Forms.TextBox haystackTextBox;
        private System.Windows.Forms.TextBox needleTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTexBox;
    }
}