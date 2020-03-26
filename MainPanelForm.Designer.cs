namespace DataStructuresFinal
{
    partial class MainPanelForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginEmailLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.exitButton);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginGroupBox);
            this.loginPanel.Controls.Add(this.loginTitleLabel);
            this.loginPanel.Location = new System.Drawing.Point(458, 156);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(391, 356);
            this.loginPanel.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(213, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(68, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Location = new System.Drawing.Point(107, 294);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(62, 36);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginEmailLabel);
            this.loginGroupBox.Controls.Add(this.loginPasswordLabel);
            this.loginGroupBox.Controls.Add(this.loginPasswordTextBox);
            this.loginGroupBox.Controls.Add(this.loginEmailTextBox);
            this.loginGroupBox.Location = new System.Drawing.Point(46, 73);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(290, 203);
            this.loginGroupBox.TabIndex = 6;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // loginEmailLabel
            // 
            this.loginEmailLabel.AutoSize = true;
            this.loginEmailLabel.Location = new System.Drawing.Point(23, 59);
            this.loginEmailLabel.Name = "loginEmailLabel";
            this.loginEmailLabel.Size = new System.Drawing.Size(46, 17);
            this.loginEmailLabel.TabIndex = 5;
            this.loginEmailLabel.Text = "Email:";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(23, 127);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.loginPasswordLabel.TabIndex = 4;
            this.loginPasswordLabel.Text = "Password:";
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(114, 124);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(162, 22);
            this.loginPasswordTextBox.TabIndex = 3;
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Location = new System.Drawing.Point(114, 59);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(162, 22);
            this.loginEmailTextBox.TabIndex = 2;
            // 
            // loginTitleLabel
            // 
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Location = new System.Drawing.Point(141, 43);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(86, 17);
            this.loginTitleLabel.TabIndex = 5;
            this.loginTitleLabel.Text = "Shop Online";
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1315, 710);
            this.contentPanel.TabIndex = 6;
            // 
            // MainPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 710);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.contentPanel);
            this.Name = "MainPanelForm";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.MainPanelForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label loginEmailLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox loginEmailTextBox;
        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.Panel contentPanel;
    }
}

