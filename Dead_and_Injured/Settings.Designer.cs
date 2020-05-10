namespace Dead_and_Injured
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfPlayersComboBox = new System.Windows.Forms.ComboBox();
            this.numOfDigitsComboBox = new System.Windows.Forms.ComboBox();
            this.settingsOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Digits to Guess: ";
            // 
            // numOfPlayersComboBox
            // 
            this.numOfPlayersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfPlayersComboBox.FormattingEnabled = true;
            this.numOfPlayersComboBox.Items.AddRange(new object[] {
            "2"});
            this.numOfPlayersComboBox.Location = new System.Drawing.Point(388, 23);
            this.numOfPlayersComboBox.Name = "numOfPlayersComboBox";
            this.numOfPlayersComboBox.Size = new System.Drawing.Size(44, 29);
            this.numOfPlayersComboBox.TabIndex = 3;
            // 
            // numOfDigitsComboBox
            // 
            this.numOfDigitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numOfDigitsComboBox.FormattingEnabled = true;
            this.numOfDigitsComboBox.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.numOfDigitsComboBox.Location = new System.Drawing.Point(388, 60);
            this.numOfDigitsComboBox.Name = "numOfDigitsComboBox";
            this.numOfDigitsComboBox.Size = new System.Drawing.Size(44, 29);
            this.numOfDigitsComboBox.TabIndex = 4;
            // 
            // settingsOKButton
            // 
            this.settingsOKButton.Location = new System.Drawing.Point(379, 95);
            this.settingsOKButton.Name = "settingsOKButton";
            this.settingsOKButton.Size = new System.Drawing.Size(62, 36);
            this.settingsOKButton.TabIndex = 5;
            this.settingsOKButton.Text = "OK";
            this.settingsOKButton.UseVisualStyleBackColor = true;
            this.settingsOKButton.Click += new System.EventHandler(this.settingsOKButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 149);
            this.Controls.Add(this.settingsOKButton);
            this.Controls.Add(this.numOfDigitsComboBox);
            this.Controls.Add(this.numOfPlayersComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Square721 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numOfPlayersComboBox;
        private System.Windows.Forms.ComboBox numOfDigitsComboBox;
        private System.Windows.Forms.Button settingsOKButton;
    }
}