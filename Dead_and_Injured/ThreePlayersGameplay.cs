using MyClassLibrary;
using System;
using System.Windows.Forms;

namespace Dead_and_Injured
{
    public partial class ThreePlayersGameplayForm : Form
    {
        Player Player1;
        Player Player2;
        Player Player3;
        private int _ticks;
        private int roundLimit = 65;

        public ThreePlayersGameplayForm()
        {
            InitializeComponent();
        }

        public ThreePlayersGameplayForm(string [,] PDetails)
        {
            InitializeComponent();
            Player1 = new Player(PDetails[1, 0], PDetails[1, 1]);
            Player2 = new Player(PDetails[2, 0], PDetails[2, 1]);
            Player3 = new Player(PDetails[3, 0], PDetails[3, 1]);
        }

        private void ThreePlayersGameplayForm_Load(object sender, EventArgs e)
        {
            PlayerOneGroupbox.Text = PlayerTwoSelectPlayer1Radio.Text = PlayerThreeSelectPlayer1Radio.Text = Player1.Name;
            PlayerTwoGroupbox.Text = PlayerOneSelectPlayer2Radio.Text = PlayerThreeSelectPlayer2Radio.Text = Player2.Name;
            PlayerThreeGroupbox.Text = PlayerOneSelectPlayer3Radio.Text = PlayerTwoSelectPlayer3Radio.Text = Player3.Name;

            RoundTimer.Start();            
        }

        private void PlayerOneCompareButton_Click(object sender, EventArgs e)
        {
            ThreePlayersGameplayCompare(
                PlayerOneSelectPlayer2Radio, PlayerOneSelectPlayer3Radio,
                Player1, Player2, Player3,
                PlayerOneNumCompareTextbox, PlayerOneDisplayTextbox, PlayerTwoDisplayTextbox, PlayerThreeDisplayTextbox,
                PlayerOneGroupbox, PlayerTwoGroupbox, PlayerThreeGroupbox);
            //Reset time countdown
            _ticks = 0;
        }

        private void PlayerTwoCompareButton_Click(object sender, EventArgs e)
        {
            ThreePlayersGameplayCompare(
                PlayerTwoSelectPlayer3Radio, PlayerTwoSelectPlayer1Radio,
                Player2, Player3, Player1,
                PlayerTwoNumCompareTextbox, PlayerTwoDisplayTextbox, PlayerThreeDisplayTextbox, PlayerOneDisplayTextbox,
                PlayerTwoGroupbox, PlayerThreeGroupbox, PlayerOneGroupbox);
            _ticks = 0;
        }

        private void PlayerThreeCompareButton_Click(object sender, EventArgs e)
        {
            ThreePlayersGameplayCompare(
                PlayerThreeSelectPlayer1Radio, PlayerThreeSelectPlayer2Radio,
                Player3, Player1, Player2,
                PlayerThreeNumCompareTextbox, PlayerThreeDisplayTextbox, PlayerOneDisplayTextbox, PlayerTwoDisplayTextbox,
                PlayerThreeGroupbox, PlayerOneGroupbox, PlayerTwoGroupbox);
            _ticks = 0;
        }

        private void ThreePlayersGameplayCompare(
            RadioButton opp1Radio, RadioButton opp2Radio,
            Player activePlayer, Player opp1, Player opp2, 
            TextBox activeNums, TextBox activeDisp, TextBox oppDisp, TextBox otherOppDisp,
            GroupBox activeGrp, GroupBox opp1Grp, GroupBox opp2Grp)
        {
            string response = null, display = null;
            //Check which player is selected for number comparison
            if (opp1Radio.Checked && opp1.IsActive) { response = activePlayer.Compare(activeNums, opp1); }

            else if (opp2Radio.Checked && opp2.IsActive) { response = activePlayer.Compare(activeNums, opp2); }

            else { MessageBox.Show("Choose an opponent in the game", "Notification"); return; }

            //Variable to store which player has been selected
            var opponent = (opp1Radio.Checked) ? opp1 : opp2;
            //Variable to hold other players who should get the result
            var otherOpponent = (opp1Radio.Checked) ? otherOppDisp : oppDisp;
            
            if (response == null) { MessageBox.Show("Invalid Entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            
            display = activeNums.Text + " - " + response + $" ({opponent.Name})";
            //Carriage return plus a new line
            activeDisp.Text += display + "\r\n";
            otherOpponent.Text += display + "\r\n";
            activeNums.ResetText();            

            if (response == Operation.WinWord)
            {
                MessageBox.Show($"{opponent.Name} is out of the game");
                activeGrp.Enabled = false;
                opponent.IsActive = false;
                if (opp1.IsActive) { opp1Grp.Enabled = true; }
                else if (opp2.IsActive) { opp2Grp.Enabled = true; }
                else { MessageBox.Show($"{activePlayer.Name} has won", "Congratulations", MessageBoxButtons.OK); }
                return;
            }
            activeGrp.Enabled = false;
            if (opp1.IsActive) { opp1Grp.Enabled = true; }
            else if (opp2.IsActive) { opp2Grp.Enabled = true; }
        }

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            int myCountdown = roundLimit - _ticks;
            TimerCountTextbox.Text = myCountdown.ToString();
            if(_ticks == roundLimit)
            {
                RoundTimer.Stop();

                if (PlayerOneGroupbox.Enabled == true)
                {
                    TimeOutSwitch(PlayerOneGroupbox, PlayerTwoGroupbox);
                }
                else if (PlayerTwoGroupbox.Enabled == true)
                {
                    TimeOutSwitch(PlayerTwoGroupbox, PlayerThreeGroupbox);
                }
                else if (PlayerThreeGroupbox.Enabled == true)
                {
                    TimeOutSwitch(PlayerThreeGroupbox, PlayerOneGroupbox);
                }
                _ticks = 0;
                RoundTimer.Start();
            }
        }

        private void TimeOutSwitch(GroupBox G1, GroupBox G2)
        {
            G1.Enabled = false;
            MessageBox.Show("You took forever!", "Timeout");
            G2.Enabled = true;
        }
    }
}
