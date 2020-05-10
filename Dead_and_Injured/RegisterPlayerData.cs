using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace Dead_and_Injured
{
    public partial class RegisterPlayerDataForm : Form
    {
        public RegisterPlayerDataForm()
        {
            InitializeComponent();
        }

        public static string P1name = null;
        public static string P2name = null;
        public static string P1num = null;
        public static string P2num = null;

        public void PlayerOneSaveDataButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerOneUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerOneSecretNumTextBox);
            if (isUsernameValid && isNumberValid)
            {
                P1name = PlayerOneUsernameTextBox.Text;
                P1num = PlayerOneSecretNumTextBox.Text;
                PlayerOneGroupBox.Enabled = false;
                PlayerTwoGroupBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Details Provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void PlayerTwoDataSaveButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerTwoUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerTwoSecretNumTextBox);
            if(isUsernameValid && isNumberValid)
            {
                P2name = PlayerTwoUsernameTextBox.Text;
                P2num = PlayerTwoSecretNumTextBox.Text;
                PlayerTwoGroupBox.Enabled = false;
                RegisterPlayersProceedButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Details Provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RegisterPlayersProceedButton_Click(object sender, EventArgs e)
        {
            GameplayForm StartGame = new GameplayForm(P1name, P1num, P2name, P2num);
            StartGame.Show();
        }
    }
}
