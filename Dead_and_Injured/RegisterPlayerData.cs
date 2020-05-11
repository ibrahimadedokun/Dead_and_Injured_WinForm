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

        public RegisterPlayerDataForm(int numOfDigits)
        {
            InitializeComponent();
            NumOfDigits = numOfDigits;
        }

        public static string P1name = null;
        public static string P2name = null;
        public static string P1num = null;
        public static string P2num = null;
        public static int NumOfDigits;

        public void PlayerOneSaveDataButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerOneUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerOneSecretNumTextBox, NumOfDigits);
            if (isUsernameValid && isNumberValid)
            {
                P1name = PlayerOneUsernameTextBox.Text;
                P1num = PlayerOneSecretNumTextBox.Text;
                PlayerOneGroupBox.Enabled = false;
                PlayerTwoGroupBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid details provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void PlayerTwoDataSaveButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerTwoUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerTwoSecretNumTextBox, NumOfDigits);
            if(isUsernameValid && isNumberValid)
            {
                if(PlayerTwoUsernameTextBox.Text == PlayerOneUsernameTextBox.Text) 
                {
                    MessageBox.Show("Identical usernames can't be chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    P2name = PlayerTwoUsernameTextBox.Text;
                    P2num = PlayerTwoSecretNumTextBox.Text;
                    PlayerTwoGroupBox.Enabled = false;
                    RegisterPlayersProceedButton.Enabled = true;
                }                
            }
            else
            {
                MessageBox.Show("Invalid details provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RegisterPlayersProceedButton_Click(object sender, EventArgs e)
        {
            GameplayForm StartGame = new GameplayForm(P1name, P1num, P2name, P2num);
            RegisterPlayersProceedButton.Enabled = false;
            StartGame.ShowDialog();
        }
    }
}
