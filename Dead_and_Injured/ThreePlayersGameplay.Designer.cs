namespace Dead_and_Injured
{
    partial class ThreePlayersGameplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreePlayersGameplayForm));
            this.PlayerOneGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PlayerOneSelectPlayer2Radio = new System.Windows.Forms.RadioButton();
            this.PlayerOneSelectPlayer3Radio = new System.Windows.Forms.RadioButton();
            this.PlayerOneNumCompareTextbox = new System.Windows.Forms.TextBox();
            this.PlayerOneCompareButton = new System.Windows.Forms.Button();
            this.PlayerOneDisplayTextbox = new System.Windows.Forms.TextBox();
            this.PlayerTwoGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PlayerTwoSelectPlayer1Radio = new System.Windows.Forms.RadioButton();
            this.PlayerTwoSelectPlayer3Radio = new System.Windows.Forms.RadioButton();
            this.PlayerTwoNumCompareTextbox = new System.Windows.Forms.TextBox();
            this.PlayerTwoCompareButton = new System.Windows.Forms.Button();
            this.PlayerTwoDisplayTextbox = new System.Windows.Forms.TextBox();
            this.PlayerThreeGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PlayerThreeSelectPlayer1Radio = new System.Windows.Forms.RadioButton();
            this.PlayerThreeSelectPlayer2Radio = new System.Windows.Forms.RadioButton();
            this.PlayerThreeNumCompareTextbox = new System.Windows.Forms.TextBox();
            this.PlayerThreeCompareButton = new System.Windows.Forms.Button();
            this.PlayerThreeDisplayTextbox = new System.Windows.Forms.TextBox();
            this.PlayerOneGroupbox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PlayerTwoGroupbox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.PlayerThreeGroupbox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerOneGroupbox
            // 
            this.PlayerOneGroupbox.Controls.Add(this.groupBox4);
            this.PlayerOneGroupbox.Controls.Add(this.PlayerOneNumCompareTextbox);
            this.PlayerOneGroupbox.Controls.Add(this.PlayerOneCompareButton);
            this.PlayerOneGroupbox.Controls.Add(this.PlayerOneDisplayTextbox);
            this.PlayerOneGroupbox.Location = new System.Drawing.Point(27, 24);
            this.PlayerOneGroupbox.Name = "PlayerOneGroupbox";
            this.PlayerOneGroupbox.Size = new System.Drawing.Size(300, 550);
            this.PlayerOneGroupbox.TabIndex = 1;
            this.PlayerOneGroupbox.TabStop = false;
            this.PlayerOneGroupbox.Text = "Player 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PlayerOneSelectPlayer2Radio);
            this.groupBox4.Controls.Add(this.PlayerOneSelectPlayer3Radio);
            this.groupBox4.Location = new System.Drawing.Point(16, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 90);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose Opponent";
            // 
            // PlayerOneSelectPlayer2Radio
            // 
            this.PlayerOneSelectPlayer2Radio.AutoSize = true;
            this.PlayerOneSelectPlayer2Radio.Location = new System.Drawing.Point(6, 29);
            this.PlayerOneSelectPlayer2Radio.Name = "PlayerOneSelectPlayer2Radio";
            this.PlayerOneSelectPlayer2Radio.Size = new System.Drawing.Size(106, 27);
            this.PlayerOneSelectPlayer2Radio.TabIndex = 3;
            this.PlayerOneSelectPlayer2Radio.Text = "Player 2";
            this.PlayerOneSelectPlayer2Radio.UseVisualStyleBackColor = true;
            // 
            // PlayerOneSelectPlayer3Radio
            // 
            this.PlayerOneSelectPlayer3Radio.AutoSize = true;
            this.PlayerOneSelectPlayer3Radio.Location = new System.Drawing.Point(6, 59);
            this.PlayerOneSelectPlayer3Radio.Name = "PlayerOneSelectPlayer3Radio";
            this.PlayerOneSelectPlayer3Radio.Size = new System.Drawing.Size(106, 27);
            this.PlayerOneSelectPlayer3Radio.TabIndex = 4;
            this.PlayerOneSelectPlayer3Radio.Text = "Player 3";
            this.PlayerOneSelectPlayer3Radio.UseVisualStyleBackColor = true;
            // 
            // PlayerOneNumCompareTextbox
            // 
            this.PlayerOneNumCompareTextbox.Location = new System.Drawing.Point(77, 473);
            this.PlayerOneNumCompareTextbox.Name = "PlayerOneNumCompareTextbox";
            this.PlayerOneNumCompareTextbox.Size = new System.Drawing.Size(135, 30);
            this.PlayerOneNumCompareTextbox.TabIndex = 2;
            // 
            // PlayerOneCompareButton
            // 
            this.PlayerOneCompareButton.Location = new System.Drawing.Point(77, 509);
            this.PlayerOneCompareButton.Name = "PlayerOneCompareButton";
            this.PlayerOneCompareButton.Size = new System.Drawing.Size(135, 35);
            this.PlayerOneCompareButton.TabIndex = 1;
            this.PlayerOneCompareButton.Text = "COMPARE";
            this.PlayerOneCompareButton.UseVisualStyleBackColor = true;
            this.PlayerOneCompareButton.Click += new System.EventHandler(this.PlayerOneCompareButton_Click);
            // 
            // PlayerOneDisplayTextbox
            // 
            this.PlayerOneDisplayTextbox.Location = new System.Drawing.Point(16, 30);
            this.PlayerOneDisplayTextbox.Multiline = true;
            this.PlayerOneDisplayTextbox.Name = "PlayerOneDisplayTextbox";
            this.PlayerOneDisplayTextbox.ReadOnly = true;
            this.PlayerOneDisplayTextbox.Size = new System.Drawing.Size(270, 340);
            this.PlayerOneDisplayTextbox.TabIndex = 0;
            // 
            // PlayerTwoGroupbox
            // 
            this.PlayerTwoGroupbox.Controls.Add(this.groupBox5);
            this.PlayerTwoGroupbox.Controls.Add(this.PlayerTwoNumCompareTextbox);
            this.PlayerTwoGroupbox.Controls.Add(this.PlayerTwoCompareButton);
            this.PlayerTwoGroupbox.Controls.Add(this.PlayerTwoDisplayTextbox);
            this.PlayerTwoGroupbox.Enabled = false;
            this.PlayerTwoGroupbox.Location = new System.Drawing.Point(344, 24);
            this.PlayerTwoGroupbox.Name = "PlayerTwoGroupbox";
            this.PlayerTwoGroupbox.Size = new System.Drawing.Size(300, 550);
            this.PlayerTwoGroupbox.TabIndex = 2;
            this.PlayerTwoGroupbox.TabStop = false;
            this.PlayerTwoGroupbox.Text = "Player 2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PlayerTwoSelectPlayer1Radio);
            this.groupBox5.Controls.Add(this.PlayerTwoSelectPlayer3Radio);
            this.groupBox5.Location = new System.Drawing.Point(15, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 90);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose Opponent";
            // 
            // PlayerTwoSelectPlayer1Radio
            // 
            this.PlayerTwoSelectPlayer1Radio.AutoSize = true;
            this.PlayerTwoSelectPlayer1Radio.Location = new System.Drawing.Point(6, 29);
            this.PlayerTwoSelectPlayer1Radio.Name = "PlayerTwoSelectPlayer1Radio";
            this.PlayerTwoSelectPlayer1Radio.Size = new System.Drawing.Size(106, 27);
            this.PlayerTwoSelectPlayer1Radio.TabIndex = 3;
            this.PlayerTwoSelectPlayer1Radio.Text = "Player 1";
            this.PlayerTwoSelectPlayer1Radio.UseVisualStyleBackColor = true;
            // 
            // PlayerTwoSelectPlayer3Radio
            // 
            this.PlayerTwoSelectPlayer3Radio.AutoSize = true;
            this.PlayerTwoSelectPlayer3Radio.Location = new System.Drawing.Point(6, 57);
            this.PlayerTwoSelectPlayer3Radio.Name = "PlayerTwoSelectPlayer3Radio";
            this.PlayerTwoSelectPlayer3Radio.Size = new System.Drawing.Size(106, 27);
            this.PlayerTwoSelectPlayer3Radio.TabIndex = 4;
            this.PlayerTwoSelectPlayer3Radio.Text = "Player 3";
            this.PlayerTwoSelectPlayer3Radio.UseVisualStyleBackColor = true;
            // 
            // PlayerTwoNumCompareTextbox
            // 
            this.PlayerTwoNumCompareTextbox.Location = new System.Drawing.Point(84, 473);
            this.PlayerTwoNumCompareTextbox.Name = "PlayerTwoNumCompareTextbox";
            this.PlayerTwoNumCompareTextbox.Size = new System.Drawing.Size(135, 30);
            this.PlayerTwoNumCompareTextbox.TabIndex = 2;
            // 
            // PlayerTwoCompareButton
            // 
            this.PlayerTwoCompareButton.Location = new System.Drawing.Point(84, 509);
            this.PlayerTwoCompareButton.Name = "PlayerTwoCompareButton";
            this.PlayerTwoCompareButton.Size = new System.Drawing.Size(135, 35);
            this.PlayerTwoCompareButton.TabIndex = 1;
            this.PlayerTwoCompareButton.Text = "COMPARE";
            this.PlayerTwoCompareButton.UseVisualStyleBackColor = true;
            this.PlayerTwoCompareButton.Click += new System.EventHandler(this.PlayerTwoCompareButton_Click);
            // 
            // PlayerTwoDisplayTextbox
            // 
            this.PlayerTwoDisplayTextbox.Location = new System.Drawing.Point(15, 30);
            this.PlayerTwoDisplayTextbox.Multiline = true;
            this.PlayerTwoDisplayTextbox.Name = "PlayerTwoDisplayTextbox";
            this.PlayerTwoDisplayTextbox.ReadOnly = true;
            this.PlayerTwoDisplayTextbox.Size = new System.Drawing.Size(270, 340);
            this.PlayerTwoDisplayTextbox.TabIndex = 0;
            // 
            // PlayerThreeGroupbox
            // 
            this.PlayerThreeGroupbox.Controls.Add(this.groupBox6);
            this.PlayerThreeGroupbox.Controls.Add(this.PlayerThreeNumCompareTextbox);
            this.PlayerThreeGroupbox.Controls.Add(this.PlayerThreeCompareButton);
            this.PlayerThreeGroupbox.Controls.Add(this.PlayerThreeDisplayTextbox);
            this.PlayerThreeGroupbox.Enabled = false;
            this.PlayerThreeGroupbox.Location = new System.Drawing.Point(661, 24);
            this.PlayerThreeGroupbox.Name = "PlayerThreeGroupbox";
            this.PlayerThreeGroupbox.Size = new System.Drawing.Size(300, 550);
            this.PlayerThreeGroupbox.TabIndex = 3;
            this.PlayerThreeGroupbox.TabStop = false;
            this.PlayerThreeGroupbox.Text = "Player 3";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PlayerThreeSelectPlayer1Radio);
            this.groupBox6.Controls.Add(this.PlayerThreeSelectPlayer2Radio);
            this.groupBox6.Location = new System.Drawing.Point(17, 376);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 90);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Choose Opponent";
            // 
            // PlayerThreeSelectPlayer1Radio
            // 
            this.PlayerThreeSelectPlayer1Radio.AutoSize = true;
            this.PlayerThreeSelectPlayer1Radio.Location = new System.Drawing.Point(6, 29);
            this.PlayerThreeSelectPlayer1Radio.Name = "PlayerThreeSelectPlayer1Radio";
            this.PlayerThreeSelectPlayer1Radio.Size = new System.Drawing.Size(106, 27);
            this.PlayerThreeSelectPlayer1Radio.TabIndex = 3;
            this.PlayerThreeSelectPlayer1Radio.Text = "Player 1";
            this.PlayerThreeSelectPlayer1Radio.UseVisualStyleBackColor = true;
            // 
            // PlayerThreeSelectPlayer2Radio
            // 
            this.PlayerThreeSelectPlayer2Radio.AutoSize = true;
            this.PlayerThreeSelectPlayer2Radio.Location = new System.Drawing.Point(6, 57);
            this.PlayerThreeSelectPlayer2Radio.Name = "PlayerThreeSelectPlayer2Radio";
            this.PlayerThreeSelectPlayer2Radio.Size = new System.Drawing.Size(106, 27);
            this.PlayerThreeSelectPlayer2Radio.TabIndex = 4;
            this.PlayerThreeSelectPlayer2Radio.Text = "Player 2";
            this.PlayerThreeSelectPlayer2Radio.UseVisualStyleBackColor = true;
            // 
            // PlayerThreeNumCompareTextbox
            // 
            this.PlayerThreeNumCompareTextbox.Location = new System.Drawing.Point(95, 473);
            this.PlayerThreeNumCompareTextbox.Name = "PlayerThreeNumCompareTextbox";
            this.PlayerThreeNumCompareTextbox.Size = new System.Drawing.Size(135, 30);
            this.PlayerThreeNumCompareTextbox.TabIndex = 2;
            // 
            // PlayerThreeCompareButton
            // 
            this.PlayerThreeCompareButton.Location = new System.Drawing.Point(95, 509);
            this.PlayerThreeCompareButton.Name = "PlayerThreeCompareButton";
            this.PlayerThreeCompareButton.Size = new System.Drawing.Size(135, 35);
            this.PlayerThreeCompareButton.TabIndex = 1;
            this.PlayerThreeCompareButton.Text = "COMPARE";
            this.PlayerThreeCompareButton.UseVisualStyleBackColor = true;
            this.PlayerThreeCompareButton.Click += new System.EventHandler(this.PlayerThreeCompareButton_Click);
            // 
            // PlayerThreeDisplayTextbox
            // 
            this.PlayerThreeDisplayTextbox.Location = new System.Drawing.Point(17, 30);
            this.PlayerThreeDisplayTextbox.Multiline = true;
            this.PlayerThreeDisplayTextbox.Name = "PlayerThreeDisplayTextbox";
            this.PlayerThreeDisplayTextbox.ReadOnly = true;
            this.PlayerThreeDisplayTextbox.Size = new System.Drawing.Size(270, 340);
            this.PlayerThreeDisplayTextbox.TabIndex = 0;
            // 
            // ThreePlayersGameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(988, 599);
            this.Controls.Add(this.PlayerThreeGroupbox);
            this.Controls.Add(this.PlayerTwoGroupbox);
            this.Controls.Add(this.PlayerOneGroupbox);
            this.Font = new System.Drawing.Font("Square721 BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThreePlayersGameplayForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.ThreePlayersGameplayForm_Load);
            this.PlayerOneGroupbox.ResumeLayout(false);
            this.PlayerOneGroupbox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PlayerTwoGroupbox.ResumeLayout(false);
            this.PlayerTwoGroupbox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.PlayerThreeGroupbox.ResumeLayout(false);
            this.PlayerThreeGroupbox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayerOneGroupbox;
        private System.Windows.Forms.GroupBox PlayerTwoGroupbox;
        private System.Windows.Forms.GroupBox PlayerThreeGroupbox;
        private System.Windows.Forms.TextBox PlayerOneDisplayTextbox;
        private System.Windows.Forms.TextBox PlayerTwoDisplayTextbox;
        private System.Windows.Forms.TextBox PlayerThreeDisplayTextbox;
        private System.Windows.Forms.Button PlayerOneCompareButton;
        private System.Windows.Forms.Button PlayerTwoCompareButton;
        private System.Windows.Forms.Button PlayerThreeCompareButton;
        private System.Windows.Forms.TextBox PlayerOneNumCompareTextbox;
        private System.Windows.Forms.TextBox PlayerTwoNumCompareTextbox;
        private System.Windows.Forms.TextBox PlayerThreeNumCompareTextbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton PlayerOneSelectPlayer2Radio;
        private System.Windows.Forms.RadioButton PlayerOneSelectPlayer3Radio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton PlayerTwoSelectPlayer1Radio;
        private System.Windows.Forms.RadioButton PlayerTwoSelectPlayer3Radio;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton PlayerThreeSelectPlayer1Radio;
        private System.Windows.Forms.RadioButton PlayerThreeSelectPlayer2Radio;
    }
}