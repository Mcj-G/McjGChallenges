namespace ChallengesUI
{
    partial class PeopleInALineView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleInALineView));
            this.BackToAllButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTexBox = new System.Windows.Forms.TextBox();
            this.xSpaceUpDown = new System.Windows.Forms.NumericUpDown();
            this.ySpaceUpDown = new System.Windows.Forms.NumericUpDown();
            this.peopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.InputLabel = new System.Windows.Forms.Label();
            this.XSpaceLabel = new System.Windows.Forms.Label();
            this.YSpaceLabel = new System.Windows.Forms.Label();
            this.SpaceLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xSpaceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySpaceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 570);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(165, 45);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.Location = new System.Drawing.Point(442, 20);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(133, 32);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Desription:";
            // 
            // DescriptionTexBox
            // 
            this.DescriptionTexBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionTexBox.Location = new System.Drawing.Point(42, 66);
            this.DescriptionTexBox.Multiline = true;
            this.DescriptionTexBox.Name = "DescriptionTexBox";
            this.DescriptionTexBox.ReadOnly = true;
            this.DescriptionTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTexBox.Size = new System.Drawing.Size(932, 189);
            this.DescriptionTexBox.TabIndex = 7;
            this.DescriptionTexBox.Text = resources.GetString("DescriptionTexBox.Text");
            // 
            // xSpaceUpDown
            // 
            this.xSpaceUpDown.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.xSpaceUpDown.Location = new System.Drawing.Point(147, 363);
            this.xSpaceUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.xSpaceUpDown.Name = "xSpaceUpDown";
            this.xSpaceUpDown.Size = new System.Drawing.Size(63, 40);
            this.xSpaceUpDown.TabIndex = 1;
            this.xSpaceUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xSpaceUpDown_KeyDown);
            // 
            // ySpaceUpDown
            // 
            this.ySpaceUpDown.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.ySpaceUpDown.Location = new System.Drawing.Point(244, 363);
            this.ySpaceUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.ySpaceUpDown.Name = "ySpaceUpDown";
            this.ySpaceUpDown.Size = new System.Drawing.Size(63, 40);
            this.ySpaceUpDown.TabIndex = 2;
            this.ySpaceUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ySpaceUpDown_KeyDown);
            // 
            // peopleUpDown
            // 
            this.peopleUpDown.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.peopleUpDown.Location = new System.Drawing.Point(147, 426);
            this.peopleUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.peopleUpDown.Name = "peopleUpDown";
            this.peopleUpDown.Size = new System.Drawing.Size(63, 40);
            this.peopleUpDown.TabIndex = 3;
            this.peopleUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.peopleUpDown_KeyDown);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.InputLabel.Location = new System.Drawing.Point(54, 283);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(85, 37);
            this.InputLabel.TabIndex = 12;
            this.InputLabel.Text = "Input:";
            // 
            // XSpaceLabel
            // 
            this.XSpaceLabel.AutoSize = true;
            this.XSpaceLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.XSpaceLabel.Location = new System.Drawing.Point(141, 325);
            this.XSpaceLabel.Name = "XSpaceLabel";
            this.XSpaceLabel.Size = new System.Drawing.Size(26, 35);
            this.XSpaceLabel.TabIndex = 13;
            this.XSpaceLabel.Text = "x";
            // 
            // YSpaceLabel
            // 
            this.YSpaceLabel.AutoSize = true;
            this.YSpaceLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.YSpaceLabel.Location = new System.Drawing.Point(238, 325);
            this.YSpaceLabel.Name = "YSpaceLabel";
            this.YSpaceLabel.Size = new System.Drawing.Size(27, 35);
            this.YSpaceLabel.TabIndex = 14;
            this.YSpaceLabel.Text = "y";
            // 
            // SpaceLabel
            // 
            this.SpaceLabel.AutoSize = true;
            this.SpaceLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.SpaceLabel.Location = new System.Drawing.Point(55, 365);
            this.SpaceLabel.Name = "SpaceLabel";
            this.SpaceLabel.Size = new System.Drawing.Size(86, 35);
            this.SpaceLabel.TabIndex = 15;
            this.SpaceLabel.Text = "Space:";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.PeopleLabel.Location = new System.Drawing.Point(46, 428);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(95, 35);
            this.PeopleLabel.TabIndex = 16;
            this.PeopleLabel.Text = "People:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.outputTextBox.Location = new System.Drawing.Point(383, 323);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(589, 292);
            this.outputTextBox.TabIndex = 17;
            this.outputTextBox.WordWrap = false;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.OutputLabel.Location = new System.Drawing.Point(376, 283);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(107, 37);
            this.OutputLabel.TabIndex = 18;
            this.OutputLabel.Text = "Output:";
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.CheckButton.Location = new System.Drawing.Point(147, 483);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(160, 45);
            this.CheckButton.TabIndex = 19;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PeopleInALineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 627);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.SpaceLabel);
            this.Controls.Add(this.YSpaceLabel);
            this.Controls.Add(this.XSpaceLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.peopleUpDown);
            this.Controls.Add(this.ySpaceUpDown);
            this.Controls.Add(this.xSpaceUpDown);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTexBox);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "PeopleInALineView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People In A Line";
            ((System.ComponentModel.ISupportInitialize)(this.xSpaceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySpaceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTexBox;
        private System.Windows.Forms.NumericUpDown xSpaceUpDown;
        private System.Windows.Forms.NumericUpDown ySpaceUpDown;
        private System.Windows.Forms.NumericUpDown peopleUpDown;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label XSpaceLabel;
        private System.Windows.Forms.Label YSpaceLabel;
        private System.Windows.Forms.Label SpaceLabel;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button CheckButton;
    }
}