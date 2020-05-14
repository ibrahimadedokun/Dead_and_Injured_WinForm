using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dead_and_Injured
{
    public partial class RegisterThreePlayersForm : Form
    {
        public RegisterThreePlayersForm()
        {
            InitializeComponent();
        }

        public RegisterThreePlayersForm(int numOfDigits, int numOfPlayers)
        {
            InitializeComponent();
            NumOfDigits = numOfDigits;
            NumOfPlayers = numOfPlayers;
        }

        public static string[,] PlayerDetails = new string[,]
        {
        //--Username, Number--//
            {null, null },
            {null, null },
            {null, null },
            {null, null }
        };

        public static int NumOfDigits;
        public static int NumOfPlayers;

        private void PlayerOneSaveDataButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerOneUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerOneSecretNumTextBox, NumOfDigits);
            if (isUsernameValid && isNumberValid)
            {
                PlayerDetails[1, 0] = PlayerOneUsernameTextBox.Text;
                PlayerDetails[1, 1] = PlayerOneSecretNumTextBox.Text;
                PlayerOneGroupBox.Enabled = false;
                PlayerTwoGroupBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid details provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void PlayerTwoSaveDataButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerTwoUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerTwoSecretNumTextBox, NumOfDigits);
            if (isUsernameValid && isNumberValid)
            {
                if (PlayerTwoUsernameTextBox.Text == PlayerOneUsernameTextBox.Text)
                {
                    MessageBox.Show("Identical usernames can't be chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PlayerDetails[2, 0] = PlayerTwoUsernameTextBox.Text;
                    PlayerDetails[2, 1] = PlayerTwoSecretNumTextBox.Text;
                    PlayerTwoGroupBox.Enabled = false;
                    PlayerThreeGroupBox.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid details provided", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void PlayerThreeSaveDataButton_Click(object sender, EventArgs e)
        {
            bool isUsernameValid = Operation.TextValidator(PlayerThreeUsernameTextBox);
            bool isNumberValid = Operation.NumberValidator(PlayerThreeSecretNumTextBox, NumOfDigits);
            if (isUsernameValid && isNumberValid)
            {
                if ((PlayerThreeUsernameTextBox.Text == PlayerTwoUsernameTextBox.Text) || (PlayerThreeUsernameTextBox.Text == PlayerOneUsernameTextBox.Text))
                {
                    MessageBox.Show("Identical usernames can't be chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PlayerDetails[3, 0] = PlayerThreeUsernameTextBox.Text;
                    PlayerDetails[3, 1] = PlayerThreeSecretNumTextBox.Text;
                    PlayerThreeGroupBox.Enabled = false;
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
            ThreePlayersGameplayForm Gameplay = new ThreePlayersGameplayForm(PlayerDetails);
            RegisterPlayersProceedButton.Enabled = false;
            Gameplay.ShowDialog();
        }
    }
}
