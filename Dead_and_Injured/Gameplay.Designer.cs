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
            this.PlayerTwoGroupbox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // PlayerOneGroupbox
            // 
            this.PlayerOneGroupbox.Location = new System.Drawing.Point(27, 20);
            this.PlayerOneGroupbox.Name = "PlayerOneGroupbox";
            this.PlayerOneGroupbox.Size = new System.Drawing.Size(200, 600);
            this.PlayerOneGroupbox.TabIndex = 1;
            this.PlayerOneGroupbox.TabStop = false;
            this.PlayerOneGroupbox.Text = "groupBox1";
            this.PlayerOneGroupbox.Enter += new System.EventHandler(this.PlayerOneGroupbox_Enter);
            // 
            // PlayerTwoGroupbox
            // 
            this.PlayerTwoGroupbox.Location = new System.Drawing.Point(251, 20);
            this.PlayerTwoGroupbox.Name = "PlayerTwoGroupbox";
            this.PlayerTwoGroupbox.Size = new System.Drawing.Size(200, 600);
            this.PlayerTwoGroupbox.TabIndex = 2;
            this.PlayerTwoGroupbox.TabStop = false;
            this.PlayerTwoGroupbox.Text = "groupBox2";
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 649);
            this.Controls.Add(this.PlayerTwoGroupbox);
            this.Controls.Add(this.PlayerOneGroupbox);
            this.Font = new System.Drawing.Font("Square721 BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameplayForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.GameplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox PlayerOneGroupbox;
        public System.Windows.Forms.GroupBox PlayerTwoGroupbox;
    }
}