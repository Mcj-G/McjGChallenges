namespace ChallengesUI
{
    partial class GenericBinaryTreeView
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.InsertDataLabel = new System.Windows.Forms.Label();
            this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DTLabel = new System.Windows.Forms.Label();
            this.AddLabel = new System.Windows.Forms.Label();
            this.addDataTextBox = new System.Windows.Forms.TextBox();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.InsertDataListTextBox = new System.Windows.Forms.TextBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.OrderingComboBox = new System.Windows.Forms.ComboBox();
            this.SDLabel = new System.Windows.Forms.Label();
            this.ShowDataButton = new System.Windows.Forms.Button();
            this.ShowDataTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShowTreeButton = new System.Windows.Forms.Button();
            this.TOSLabel = new System.Windows.Forms.Label();
            this.OrderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackToAllButton
            // 
            this.BackToAllButton.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.BackToAllButton.Location = new System.Drawing.Point(12, 498);
            this.BackToAllButton.Name = "BackToAllButton";
            this.BackToAllButton.Size = new System.Drawing.Size(149, 44);
            this.BackToAllButton.TabIndex = 0;
            this.BackToAllButton.Text = "Back to all";
            this.BackToAllButton.UseVisualStyleBackColor = true;
            this.BackToAllButton.Click += new System.EventHandler(this.BackToAllButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderLabel.Location = new System.Drawing.Point(370, 22);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(228, 32);
            this.HeaderLabel.TabIndex = 6;
            this.HeaderLabel.Text = "Generic Binary Tree";
            // 
            // InsertDataLabel
            // 
            this.InsertDataLabel.AutoSize = true;
            this.InsertDataLabel.Location = new System.Drawing.Point(137, 78);
            this.InsertDataLabel.Name = "InsertDataLabel";
            this.InsertDataLabel.Size = new System.Drawing.Size(138, 35);
            this.InsertDataLabel.TabIndex = 7;
            this.InsertDataLabel.Text = "Insert data:";
            // 
            // DataTypeComboBox
            // 
            this.DataTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DataTypeComboBox.FormattingEnabled = true;
            this.DataTypeComboBox.Location = new System.Drawing.Point(171, 132);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.Size = new System.Drawing.Size(163, 33);
            this.DataTypeComboBox.TabIndex = 8;
            this.DataTypeComboBox.SelectedValueChanged += new System.EventHandler(this.DataTypeComboBox_SelectedValueChanged);
            // 
            // DTLabel
            // 
            this.DTLabel.AutoSize = true;
            this.DTLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DTLabel.Location = new System.Drawing.Point(69, 135);
            this.DTLabel.Name = "DTLabel";
            this.DTLabel.Size = new System.Drawing.Size(96, 25);
            this.DTLabel.TabIndex = 9;
            this.DTLabel.Text = "Data type:";
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.AddLabel.Location = new System.Drawing.Point(69, 187);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(50, 25);
            this.AddLabel.TabIndex = 10;
            this.AddLabel.Text = "Add:";
            // 
            // addDataTextBox
            // 
            this.addDataTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.addDataTextBox.Location = new System.Drawing.Point(171, 184);
            this.addDataTextBox.Name = "addDataTextBox";
            this.addDataTextBox.Size = new System.Drawing.Size(163, 33);
            this.addDataTextBox.TabIndex = 11;
            // 
            // AddDataButton
            // 
            this.AddDataButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.AddDataButton.Location = new System.Drawing.Point(171, 226);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(163, 37);
            this.AddDataButton.TabIndex = 12;
            this.AddDataButton.Text = "Add data";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // InsertDataListTextBox
            // 
            this.InsertDataListTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.InsertDataListTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.InsertDataListTextBox.Location = new System.Drawing.Point(39, 333);
            this.InsertDataListTextBox.Multiline = true;
            this.InsertDataListTextBox.Name = "InsertDataListTextBox";
            this.InsertDataListTextBox.ReadOnly = true;
            this.InsertDataListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InsertDataListTextBox.Size = new System.Drawing.Size(333, 154);
            this.InsertDataListTextBox.TabIndex = 13;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.OrderLabel.Location = new System.Drawing.Point(623, 135);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(65, 25);
            this.OrderLabel.TabIndex = 16;
            this.OrderLabel.Text = "Order:";
            // 
            // OrderingComboBox
            // 
            this.OrderingComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.OrderingComboBox.FormattingEnabled = true;
            this.OrderingComboBox.Location = new System.Drawing.Point(694, 132);
            this.OrderingComboBox.Name = "OrderingComboBox";
            this.OrderingComboBox.Size = new System.Drawing.Size(163, 33);
            this.OrderingComboBox.TabIndex = 15;
            // 
            // SDLabel
            // 
            this.SDLabel.AutoSize = true;
            this.SDLabel.Location = new System.Drawing.Point(660, 78);
            this.SDLabel.Name = "SDLabel";
            this.SDLabel.Size = new System.Drawing.Size(136, 35);
            this.SDLabel.TabIndex = 14;
            this.SDLabel.Text = "Show data:";
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ShowDataButton.Location = new System.Drawing.Point(694, 269);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(163, 37);
            this.ShowDataButton.TabIndex = 17;
            this.ShowDataButton.Text = "Show data";
            this.ShowDataButton.UseVisualStyleBackColor = true;
            this.ShowDataButton.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // ShowDataTextBox
            // 
            this.ShowDataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShowDataTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ShowDataTextBox.Location = new System.Drawing.Point(594, 333);
            this.ShowDataTextBox.Multiline = true;
            this.ShowDataTextBox.Name = "ShowDataTextBox";
            this.ShowDataTextBox.ReadOnly = true;
            this.ShowDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowDataTextBox.Size = new System.Drawing.Size(333, 154);
            this.ShowDataTextBox.TabIndex = 18;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ClearButton.Location = new System.Drawing.Point(422, 498);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 37);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShowTreeButton
            // 
            this.ShowTreeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ShowTreeButton.Location = new System.Drawing.Point(694, 226);
            this.ShowTreeButton.Name = "ShowTreeButton";
            this.ShowTreeButton.Size = new System.Drawing.Size(163, 37);
            this.ShowTreeButton.TabIndex = 20;
            this.ShowTreeButton.Text = "Show tree";
            this.ShowTreeButton.UseVisualStyleBackColor = true;
            this.ShowTreeButton.Click += new System.EventHandler(this.ShowTreeButton_Click);
            // 
            // TOSLabel
            // 
            this.TOSLabel.AutoSize = true;
            this.TOSLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TOSLabel.Location = new System.Drawing.Point(558, 187);
            this.TOSLabel.Name = "TOSLabel";
            this.TOSLabel.Size = new System.Drawing.Size(130, 25);
            this.TOSLabel.TabIndex = 22;
            this.TOSLabel.Text = "Type of sortig:";
            this.TOSLabel.Visible = false;
            // 
            // OrderTypeComboBox
            // 
            this.OrderTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.OrderTypeComboBox.FormattingEnabled = true;
            this.OrderTypeComboBox.Location = new System.Drawing.Point(694, 184);
            this.OrderTypeComboBox.Name = "OrderTypeComboBox";
            this.OrderTypeComboBox.Size = new System.Drawing.Size(163, 33);
            this.OrderTypeComboBox.TabIndex = 21;
            this.OrderTypeComboBox.Visible = false;
            // 
            // GenericBinaryTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 554);
            this.Controls.Add(this.TOSLabel);
            this.Controls.Add(this.OrderTypeComboBox);
            this.Controls.Add(this.ShowTreeButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowDataTextBox);
            this.Controls.Add(this.ShowDataButton);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.OrderingComboBox);
            this.Controls.Add(this.SDLabel);
            this.Controls.Add(this.InsertDataListTextBox);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.addDataTextBox);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.DTLabel);
            this.Controls.Add(this.DataTypeComboBox);
            this.Controls.Add(this.InsertDataLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.BackToAllButton);
            this.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "GenericBinaryTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Binary Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToAllButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label InsertDataLabel;
        private System.Windows.Forms.ComboBox DataTypeComboBox;
        private System.Windows.Forms.Label DTLabel;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox addDataTextBox;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.TextBox InsertDataListTextBox;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.ComboBox OrderingComboBox;
        private System.Windows.Forms.Label SDLabel;
        private System.Windows.Forms.Button ShowDataButton;
        private System.Windows.Forms.TextBox ShowDataTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ShowTreeButton;
        private System.Windows.Forms.Label TOSLabel;
        private System.Windows.Forms.ComboBox OrderTypeComboBox;
    }
}