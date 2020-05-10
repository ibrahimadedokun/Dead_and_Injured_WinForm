namespace Dead_and_Injured
{
    partial class RegisterPlayerDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPlayerDataForm));
            this.PlayerOneGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerTwoGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerOneUsernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerOneUsernameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneSecretNumTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoUsernameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoSecretNumTextBox = new System.Windows.Forms.TextBox();
            this.PlayerOneSaveDataButton = new System.Windows.Forms.Button();
            this.PlayerTwoDataSaveButton = new System.Windows.Forms.Button();
            this.RegisterPlayersProceedButton = new System.Windows.Forms.Button();
            this.PlayerOneGroupBox.SuspendLayout();
            this.PlayerTwoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerOneGroupBox
            // 
            this.PlayerOneGroupBox.Controls.Add(this.PlayerOneSaveDataButton);
            this.PlayerOneGroupBox.Controls.Add(this.PlayerOneSecretNumTextBox);
            this.PlayerOneGroupBox.Controls.Add(this.PlayerOneUsernameTextBox);
            this.PlayerOneGroupBox.Controls.Add(this.label2);
            this.PlayerOneGroupBox.Controls.Add(this.PlayerOneUsernameLabel);
            this.PlayerOneGroupBox.Location = new System.Drawing.Point(35, 15);
            this.PlayerOneGroupBox.Name = "PlayerOneGroupBox";
            this.PlayerOneGroupBox.Size = new System.Drawing.Size(400, 150);
            this.PlayerOneGroupBox.TabIndex = 1;
            this.PlayerOneGroupBox.TabStop = false;
            this.PlayerOneGroupBox.Text = "Player One";
            // 
            // PlayerTwoGroupBox
            // 
            this.PlayerTwoGroupBox.Controls.Add(this.PlayerTwoDataSaveButton);
            this.PlayerTwoGroupBox.Controls.Add(this.PlayerTwoSecretNumTextBox);
            this.PlayerTwoGroupBox.Controls.Add(this.PlayerTwoUsernameTextBox);
            this.PlayerTwoGroupBox.Controls.Add(this.label4);
            this.PlayerTwoGroupBox.Controls.Add(this.label3);
            this.PlayerTwoGroupBox.Enabled = false;
            this.PlayerTwoGroupBox.Location = new System.Drawing.Point(35, 177);
            this.PlayerTwoGroupBox.Name = "PlayerTwoGroupBox";
            this.PlayerTwoGroupBox.Size = new System.Drawing.Size(400, 150);
            this.PlayerTwoGroupBox.TabIndex = 2;
            this.PlayerTwoGroupBox.TabStop = false;
            this.PlayerTwoGroupBox.Text = "Player Two";
            // 
            // PlayerOneUsernameLabel
            // 
            this.PlayerOneUsernameLabel.AutoSize = true;
            this.PlayerOneUsernameLabel.Location = new System.Drawing.Point(40, 32);
            this.PlayerOneUsernameLabel.Name = "PlayerOneUsernameLabel";
            this.PlayerOneUsernameLabel.Size = new System.Drawing.Size(102, 21);
            this.PlayerOneUsernameLabel.TabIndex = 0;
            this.PlayerOneUsernameLabel.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secret Numbers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Secret Numbers:";
            // 
            // PlayerOneUsernameTextBox
            // 
            this.PlayerOneUsernameTextBox.Location = new System.Drawing.Point(224, 25);
            this.PlayerOneUsernameTextBox.Name = "PlayerOneUsernameTextBox";
            this.PlayerOneUsernameTextBox.Size = new System.Drawing.Size(154, 28);
            this.PlayerOneUsernameTextBox.TabIndex = 2;
            // 
            // PlayerOneSecretNumTextBox
            // 
            this.PlayerOneSecretNumTextBox.Location = new System.Drawing.Point(224, 61);
            this.PlayerOneSecretNumTextBox.Name = "PlayerOneSecretNumTextBox";
            this.PlayerOneSecretNumTextBox.PasswordChar = '*';
            this.PlayerOneSecretNumTextBox.Size = new System.Drawing.Size(154, 28);
            this.PlayerOneSecretNumTextBox.TabIndex = 3;
            // 
            // PlayerTwoUsernameTextBox
            // 
            this.PlayerTwoUsernameTextBox.Location = new System.Drawing.Point(224, 25);
            this.PlayerTwoUsernameTextBox.Name = "PlayerTwoUsernameTextBox";
            this.PlayerTwoUsernameTextBox.Size = new System.Drawing.Size(154, 28);
            this.PlayerTwoUsernameTextBox.TabIndex = 2;
            // 
            // PlayerTwoSecretNumTextBox
            // 
            this.PlayerTwoSecretNumTextBox.Location = new System.Drawing.Point(224, 61);
            this.PlayerTwoSecretNumTextBox.Name = "PlayerTwoSecretNumTextBox";
            this.PlayerTwoSecretNumTextBox.PasswordChar = '*';
            this.PlayerTwoSecretNumTextBox.Size = new System.Drawing.Size(154, 28);
            this.PlayerTwoSecretNumTextBox.TabIndex = 3;
            // 
            // PlayerOneSaveDataButton
            // 
            this.PlayerOneSaveDataButton.Location = new System.Drawing.Point(288, 105);
            this.PlayerOneSaveDataButton.Name = "PlayerOneSaveDataButton";
            this.PlayerOneSaveDataButton.Size = new System.Drawing.Size(90, 30);
            this.PlayerOneSaveDataButton.TabIndex = 4;
            this.PlayerOneSaveDataButton.Text = "SAVE";
            this.PlayerOneSaveDataButton.UseVisualStyleBackColor = true;
            this.PlayerOneSaveDataButton.Click += new System.EventHandler(this.PlayerOneSaveDataButton_Click);
            // 
            // PlayerTwoDataSaveButton
            // 
            this.PlayerTwoDataSaveButton.Location = new System.Drawing.Point(288, 104);
            this.PlayerTwoDataSaveButton.Name = "PlayerTwoDataSaveButton";
            this.PlayerTwoDataSaveButton.Size = new System.Drawing.Size(90, 30);
            this.PlayerTwoDataSaveButton.TabIndex = 4;
            this.PlayerTwoDataSaveButton.Text = "SAVE";
            this.PlayerTwoDataSaveButton.UseVisualStyleBackColor = true;
            this.PlayerTwoDataSaveButton.Click += new System.EventHandler(this.PlayerTwoDataSaveButton_Click);
            // 
            // RegisterPlayersProceedButton
            // 
            this.RegisterPlayersProceedButton.Enabled = false;
            this.RegisterPlayersProceedButton.Location = new System.Drawing.Point(181, 338);
            this.RegisterPlayersProceedButton.Name = "RegisterPlayersProceedButton";
            this.RegisterPlayersProceedButton.Size = new System.Drawing.Size(115, 40);
            this.RegisterPlayersProceedButton.TabIndex = 3;
            this.RegisterPlayersProceedButton.Text = "PROCEED";
            this.RegisterPlayersProceedButton.UseVisualStyleBackColor = true;
            this.RegisterPlayersProceedButton.Click += new System.EventHandler(this.RegisterPlayersProceedButton_Click);
            // 
            // RegisterPlayerDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 399);
            this.Controls.Add(this.RegisterPlayersProceedButton);
            this.Controls.Add(this.PlayerTwoGroupBox);
            this.Controls.Add(this.PlayerOneGroupBox);
            this.Font = new System.Drawing.Font("Square721 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterPlayerDataForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Players";
            this.PlayerOneGroupBox.ResumeLayout(false);
            this.PlayerOneGroupBox.PerformLayout();
            this.PlayerTwoGroupBox.ResumeLayout(false);
            this.PlayerTwoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayerOneGroupBox;
        private System.Windows.Forms.GroupBox PlayerTwoGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlayerOneUsernameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlayerOneSecretNumTextBox;
        private System.Windows.Forms.TextBox PlayerOneUsernameTextBox;
        private System.Windows.Forms.TextBox PlayerTwoSecretNumTextBox;
        private System.Windows.Forms.TextBox PlayerTwoUsernameTextBox;
        private System.Windows.Forms.Button PlayerOneSaveDataButton;
        private System.Windows.Forms.Button PlayerTwoDataSaveButton;
        private System.Windows.Forms.Button RegisterPlayersProceedButton;
    }
}