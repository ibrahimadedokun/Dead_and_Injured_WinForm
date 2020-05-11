namespace Dead_and_Injured
{
    partial class GameplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameplayForm));
            this.PlayerOneGroupbox = new System.Windows.Forms.GroupBox();
            this.PlayerOneDisplayTextbox = new System.Windows.Forms.TextBox();
            this.PlayerOneNumCompareTextbox = new System.Windows.Forms.TextBox();
            this.PlayerOneCompareButton = new System.Windows.Forms.Button();
            this.PlayerTwoGroupbox = new System.Windows.Forms.GroupBox();
            this.PlayerTwoDisplayTextbox = new System.Windows.Forms.TextBox();
            this.PlayerTwoNumCompareTextbox = new System.Windows.Forms.TextBox();
            this.PlayerTwoCompareButton = new System.Windows.Forms.Button();
            this.PlayerOneGroupbox.SuspendLayout();
            this.PlayerTwoGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerOneGroupbox
            // 
            this.PlayerOneGroupbox.Controls.Add(this.PlayerOneDisplayTextbox);
            this.PlayerOneGroupbox.Controls.Add(this.PlayerOneNumCompareTextbox);
            this.PlayerOneGroupbox.Controls.Add(this.PlayerOneCompareButton);
            this.PlayerOneGroupbox.Location = new System.Drawing.Point(27, 20);
            this.PlayerOneGroupbox.Name = "PlayerOneGroupbox";
            this.PlayerOneGroupbox.Size = new System.Drawing.Size(300, 500);
            this.PlayerOneGroupbox.TabIndex = 1;
            this.PlayerOneGroupbox.TabStop = false;
            this.PlayerOneGroupbox.Text = "Player 1";
            // 
            // PlayerOneDisplayTextbox
            // 
            this.PlayerOneDisplayTextbox.Location = new System.Drawing.Point(16, 40);
            this.PlayerOneDisplayTextbox.Multiline = true;
            this.PlayerOneDisplayTextbox.Name = "PlayerOneDisplayTextbox";
            this.PlayerOneDisplayTextbox.ReadOnly = true;
            this.PlayerOneDisplayTextbox.Size = new System.Drawing.Size(270, 340);
            this.PlayerOneDisplayTextbox.TabIndex = 2;
            // 
            // PlayerOneNumCompareTextbox
            // 
            this.PlayerOneNumCompareTextbox.Location = new System.Drawing.Point(81, 413);
            this.PlayerOneNumCompareTextbox.Name = "PlayerOneNumCompareTextbox";
            this.PlayerOneNumCompareTextbox.Size = new System.Drawing.Size(135, 30);
            this.PlayerOneNumCompareTextbox.TabIndex = 1;
            // 
            // PlayerOneCompareButton
            // 
            this.PlayerOneCompareButton.Location = new System.Drawing.Point(81, 454);
            this.PlayerOneCompareButton.Name = "PlayerOneCompareButton";
            this.PlayerOneCompareButton.Size = new System.Drawing.Size(135, 35);
            this.PlayerOneCompareButton.TabIndex = 0;
            this.PlayerOneCompareButton.Text = "COMPARE";
            this.PlayerOneCompareButton.UseVisualStyleBackColor = true;
            this.PlayerOneCompareButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerTwoGroupbox
            // 
            this.PlayerTwoGroupbox.Controls.Add(this.PlayerTwoDisplayTextbox);
            this.PlayerTwoGroupbox.Controls.Add(this.PlayerTwoNumCompareTextbox);
            this.PlayerTwoGroupbox.Controls.Add(this.PlayerTwoCompareButton);
            this.PlayerTwoGroupbox.Enabled = false;
            this.PlayerTwoGroupbox.Location = new System.Drawing.Point(349, 20);
            this.PlayerTwoGroupbox.Name = "PlayerTwoGroupbox";
            this.PlayerTwoGroupbox.Size = new System.Drawing.Size(300, 500);
            this.PlayerTwoGroupbox.TabIndex = 2;
            this.PlayerTwoGroupbox.TabStop = false;
            this.PlayerTwoGroupbox.Text = "Player 2";
            // 
            // PlayerTwoDisplayTextbox
            // 
            this.PlayerTwoDisplayTextbox.Location = new System.Drawing.Point(20, 40);
            this.PlayerTwoDisplayTextbox.Multiline = true;
            this.PlayerTwoDisplayTextbox.Name = "PlayerTwoDisplayTextbox";
            this.PlayerTwoDisplayTextbox.ReadOnly = true;
            this.PlayerTwoDisplayTextbox.Size = new System.Drawing.Size(270, 340);
            this.PlayerTwoDisplayTextbox.TabIndex = 2;
            // 
            // PlayerTwoNumCompareTextbox
            // 
            this.PlayerTwoNumCompareTextbox.Location = new System.Drawing.Point(90, 413);
            this.PlayerTwoNumCompareTextbox.Name = "PlayerTwoNumCompareTextbox";
            this.PlayerTwoNumCompareTextbox.Size = new System.Drawing.Size(135, 30);
            this.PlayerTwoNumCompareTextbox.TabIndex = 1;
            // 
            // PlayerTwoCompareButton
            // 
            this.PlayerTwoCompareButton.Location = new System.Drawing.Point(90, 454);
            this.PlayerTwoCompareButton.Name = "PlayerTwoCompareButton";
            this.PlayerTwoCompareButton.Size = new System.Drawing.Size(135, 35);
            this.PlayerTwoCompareButton.TabIndex = 0;
            this.PlayerTwoCompareButton.Text = "COMPARE";
            this.PlayerTwoCompareButton.UseVisualStyleBackColor = true;
            this.PlayerTwoCompareButton.Click += new System.EventHandler(this.PlayerTwoCompareButton_Click);
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(678, 549);
            this.Controls.Add(this.PlayerTwoGroupbox);
            this.Controls.Add(this.PlayerOneGroupbox);
            this.Font = new System.Drawing.Font("Square721 BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameplayForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.GameplayForm_Load);
            this.PlayerOneGroupbox.ResumeLayout(false);
            this.PlayerOneGroupbox.PerformLayout();
            this.PlayerTwoGroupbox.ResumeLayout(false);
            this.PlayerTwoGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox PlayerOneGroupbox;
        public System.Windows.Forms.GroupBox PlayerTwoGroupbox;
        private System.Windows.Forms.Button PlayerOneCompareButton;
        private System.Windows.Forms.Button PlayerTwoCompareButton;
        private System.Windows.Forms.TextBox PlayerOneNumCompareTextbox;
        private System.Windows.Forms.TextBox PlayerTwoNumCompareTextbox;
        private System.Windows.Forms.TextBox PlayerOneDisplayTextbox;
        private System.Windows.Forms.TextBox PlayerTwoDisplayTextbox;
    }
}