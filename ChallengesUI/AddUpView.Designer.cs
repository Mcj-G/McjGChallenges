namespace ChallengesUI
{
    partial class AddUpView
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
            this.BackToAllButton = new System.Windows.Forms.Button();
            this.DescriptionTexBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NewNumberLabel = new System.Windows.Forms.Label();
            this.newNumberTextBox = new System.Windows.Forms.TextBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.listTextBox = new System.Windows.Forms.TextBox();
            this.KLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.AddNumberButton = new System.Windows.Forms.Button();
            this.TrueLabel = new System.Windows.Forms.Label();
            this.FalseLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 433);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(181, 43);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // DescriptionTexBox
            // 
            this.DescriptionTexBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionTexBox.Location = new System.Drawing.Point(34, 86);
            this.DescriptionTexBox.Multiline = true;
            this.DescriptionTexBox.Name = "DescriptionTexBox";
            this.DescriptionTexBox.ReadOnly = true;
            this.DescriptionTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTexBox.Size = new System.Drawing.Size(782, 100);
            this.DescriptionTexBox.TabIndex = 3;
            this.DescriptionTexBox.Text = "Given a list of numbers and a number \'k\', return whether any two numbers from the" +
    " list add up to \'k\'.\r\nExample: \r\nGiven [10, 15, 3, 7] and \'k\' of 17, return true" +
    " since 10 + 7 is 17.";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionLabel.Location = new System.Drawing.Point(359, 29);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(133, 32);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Desription:";
            // 
            // NewNumberLabel
            // 
            this.NewNumberLabel.AutoSize = true;
            this.NewNumberLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.NewNumberLabel.Location = new System.Drawing.Point(28, 221);
            this.NewNumberLabel.Name = "NewNumberLabel";
            this.NewNumberLabel.Size = new System.Drawing.Size(223, 35);
            this.NewNumberLabel.TabIndex = 7;
            this.NewNumberLabel.Text = "Enter new number:";
            // 
            // newNumberTextBox
            // 
            this.newNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.newNumberTextBox.Location = new System.Drawing.Point(305, 218);
            this.newNumberTextBox.Name = "newNumberTextBox";
            this.newNumberTextBox.Size = new System.Drawing.Size(37, 40);
            this.newNumberTextBox.TabIndex = 6;
            this.newNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newNumberTextBox_KeyDown);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.ListLabel.Location = new System.Drawing.Point(28, 304);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(175, 35);
            this.ListLabel.TabIndex = 8;
            this.ListLabel.Text = "Your numbers:";
            // 
            // listTextBox
            // 
            this.listTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.listTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.listTextBox.Location = new System.Drawing.Point(34, 352);
            this.listTextBox.Name = "listTextBox";
            this.listTextBox.ReadOnly = true;
            this.listTextBox.Size = new System.Drawing.Size(402, 40);
            this.listTextBox.TabIndex = 9;
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.KLabel.Location = new System.Drawing.Point(567, 221);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(32, 35);
            this.KLabel.TabIndex = 11;
            this.KLabel.Text = "k:";
            // 
            // kTextBox
            // 
            this.kTextBox.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.kTextBox.Location = new System.Drawing.Point(605, 218);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(37, 40);
            this.kTextBox.TabIndex = 10;
            this.kTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kTextBox_KeyDown);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.CheckButton.Location = new System.Drawing.Point(532, 299);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(181, 43);
            this.CheckButton.TabIndex = 12;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // AddNumberButton
            // 
            this.AddNumberButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.AddNumberButton.Location = new System.Drawing.Point(367, 216);
            this.AddNumberButton.Name = "AddNumberButton";
            this.AddNumberButton.Size = new System.Drawing.Size(69, 43);
            this.AddNumberButton.TabIndex = 13;
            this.AddNumberButton.Text = "Add";
            this.AddNumberButton.UseVisualStyleBackColor = true;
            this.AddNumberButton.Click += new System.EventHandler(this.AddNumberButton_Click);
            // 
            // TrueLabel
            // 
            this.TrueLabel.AutoSize = true;
            this.TrueLabel.BackColor = System.Drawing.Color.Gray;
            this.TrueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrueLabel.Location = new System.Drawing.Point(536, 355);
            this.TrueLabel.Name = "TrueLabel";
            this.TrueLabel.Size = new System.Drawing.Size(72, 32);
            this.TrueLabel.TabIndex = 14;
            this.TrueLabel.Text = "TRUE";
            // 
            // FalseLabel
            // 
            this.FalseLabel.AutoSize = true;
            this.FalseLabel.BackColor = System.Drawing.Color.Gray;
            this.FalseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FalseLabel.Location = new System.Drawing.Point(634, 355);
            this.FalseLabel.Name = "FalseLabel";
            this.FalseLabel.Size = new System.Drawing.Size(79, 32);
            this.FalseLabel.TabIndex = 15;
            this.FalseLabel.Text = "FALSE";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.ClearButton.Location = new System.Drawing.Point(305, 303);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(131, 37);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 488);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FalseLabel);
            this.Controls.Add(this.TrueLabel);
            this.Controls.Add(this.AddNumberButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.KLabel);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.listTextBox);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.NewNumberLabel);
            this.Controls.Add(this.newNumberTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTexBox);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "AddUpView";
            this.Text = "Add Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.TextBox DescriptionTexBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NewNumberLabel;
        private System.Windows.Forms.TextBox newNumberTextBox;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.TextBox listTextBox;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button AddNumberButton;
        private System.Windows.Forms.Label TrueLabel;
        private System.Windows.Forms.Label FalseLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}