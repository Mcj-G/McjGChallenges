namespace ChallengesUI
{
    partial class AlmostPalindromeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlmostPalindromeView));
            this.BackToAllButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTexBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.inputTexBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 413);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(205, 45);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.Location = new System.Drawing.Point(376, 18);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(133, 32);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Desription:";
            // 
            // DescriptionTexBox
            // 
            this.DescriptionTexBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionTexBox.Location = new System.Drawing.Point(28, 67);
            this.DescriptionTexBox.Multiline = true;
            this.DescriptionTexBox.Name = "DescriptionTexBox";
            this.DescriptionTexBox.ReadOnly = true;
            this.DescriptionTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTexBox.Size = new System.Drawing.Size(829, 99);
            this.DescriptionTexBox.TabIndex = 4;
            this.DescriptionTexBox.Text = resources.GetString("DescriptionTexBox.Text");
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.OutputLabel.Location = new System.Drawing.Point(181, 317);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(124, 35);
            this.OutputLabel.TabIndex = 15;
            this.OutputLabel.Text = "Output = ";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.outputTextBox.Location = new System.Drawing.Point(311, 314);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(126, 40);
            this.outputTextBox.TabIndex = 14;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.CheckButton.Location = new System.Drawing.Point(498, 247);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(205, 49);
            this.CheckButton.TabIndex = 16;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // inputTexBox
            // 
            this.inputTexBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.inputTexBox.Location = new System.Drawing.Point(280, 252);
            this.inputTexBox.Name = "inputTexBox";
            this.inputTexBox.Size = new System.Drawing.Size(197, 40);
            this.inputTexBox.TabIndex = 17;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.InputLabel.Location = new System.Drawing.Point(181, 255);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(78, 35);
            this.InputLabel.TabIndex = 18;
            this.InputLabel.Text = "Input:";
            // 
            // AlmostPalindromeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 470);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.inputTexBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTexBox);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "AlmostPalindromeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almost Palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTexBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox inputTexBox;
        private System.Windows.Forms.Label InputLabel;
    }
}