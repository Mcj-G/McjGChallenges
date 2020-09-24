namespace ChallengesUI
{
    partial class ReverseAndNotView
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
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Location = new System.Drawing.Point(388, 320);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(150, 60);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // ReverseAndNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 448);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "ReverseAndNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReverseAndNot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
    }
}