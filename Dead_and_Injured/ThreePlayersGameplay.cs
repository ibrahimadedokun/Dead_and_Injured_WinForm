using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dead_and_Injured
{
    public partial class ThreePlayersGameplayForm : Form
    {
        Player Player1;
        Player Player2;
        Player Player3;

        public ThreePlayersGameplayForm()
        {
            InitializeComponent();
        }

        public ThreePlayersGameplayForm(string [,] PDetails)
        {
            InitializeComponent();
            Player1 = new Player(PDetails[1, 0], int.Parse(PDetails[1, 1]));
            Player2 = new Player(PDetails[2, 0], int.Parse(PDetails[2, 1]));
            Player3 = new Player(PDetails[3, 0], int.Parse(PDetails[3, 1]));
        }

        private void ThreePlayersGameplayForm_Load(object sender, EventArgs e)
        {
            PlayerOneGroupbox.Text = PlayerTwoSelectPlayer1Radio.Text = PlayerThreeSelectPlayer1Radio.Text = Player1.Name;
            PlayerTwoGroupbox.Text = PlayerOneSelectPlayer2Radio.Text = PlayerThreeSelectPlayer2Radio.Text = Player2.Name;
            PlayerThreeGroupbox.Text = PlayerOneSelectPlayer3Radio.Text = PlayerTwoSelectPlayer3Radio.Text = Player3.Name;
        }

        private void PlayerOneCompareButton_Click(object sender, EventArgs e)
        {
            ThreePlayersGameplayCompare(
                PlayerOneSelectPlayer2Radio, PlayerOneSelectPlayer3Radio,
                Player1, Player2, Player3,
                PlayerOneNumCompareTextbox, PlayerOneDisplayTextbox, PlayerTwoDisplayTextbox, PlayerThreeDisplayTextbox,
                PlayerOneGroupbox, PlayerTwoGroupbox, PlayerThreeGroupbox);
        }

        private void PlayerTwoCompareButton_Click(object sender, EventArgs e)
        {
            ThreePlayersGameplayCompare(
                PlayerTwoSelectPlayer3Radio, PlayerTwoSelectPlayer1Radio,
                Player2, Player3, Player1,
                PlayerTwoNumCompareTextbox, PlayerTwoDisplayTextbox, PlayerThreeDisplayTextbox, PlayerOneDisplayTextbox,
                PlayerTwoGroupbox, PlayerThreeGroupbox, PlayerOneGroupbox);
        }

        private void PlayerThreeCompareButton_Click(object sender, EventArgs e)
        {
            ThreePlayersGameplayCompare(
                PlayerThreeSelectPlayer1Radio, PlayerThreeSelectPlayer2Radio,
                Player3, Player1, Player2,
                PlayerThreeNumCompareTextbox, PlayerThreeDisplayTextbox, PlayerOneDisplayTextbox, PlayerTwoDisplayTextbox,
                PlayerThreeGroupbox, PlayerOneGroupbox, PlayerTwoGroupbox);
        }

        private void ThreePlayersGameplayCompare(
            RadioButton opp1Radio, RadioButton opp2Radio,
            Player activePlayer, Player opp1, Player opp2, 
            TextBox activeNums, TextBox activeDisp, TextBox oppDisp, TextBox otherOppDisp,
            GroupBox activeGrp, GroupBox opp1Grp, GroupBox opp2Grp)
        {
            string response = null, display = null;
            if (opp1Radio.Checked && opp1.IsActive) { response = activePlayer.Compare(activeNums, opp1); }
            else if (opp2Radio.Checked && opp2.IsActive) { response = activePlayer.Compare(activeNums, opp2); }
            else { MessageBox.Show("Choose an opponent in the game", "Notification"); return; }
            var opponent = (opp1Radio.Checked) ? opp1 : opp2;
            var otherOpponent = (opp1Radio.Checked) ? otherOppDisp : oppDisp;
            if (response == null) { MessageBox.Show("Invalid Entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            display = activeNums.Text + " - " + response + $" ({opponent.Name})";
            activeDisp.Text += display + "\r\n";
            otherOpponent.Text += display + "\r\n";
            activeNums.ResetText();            

            if (response == Operation.WinWord)
            {
                MessageBox.Show($"{opponent.Name} is out of the game");
                activeGrp.Enabled = false;
                opponent.IsActive = false; //---------------//
                if (opp1.IsActive) { opp1Grp.Enabled = true; }
                else if (opp2.IsActive) { opp2Grp.Enabled = true; }
                else { MessageBox.Show($"{activePlayer.Name} has won", "Congratulations", MessageBoxButtons.OK); }
                return;
            }
            activeGrp.Enabled = false;
            if (opp1.IsActive) { opp1Grp.Enabled = true; }
            else if (opp2.IsActive) { opp2Grp.Enabled = true; }
        }        
    }
}
