using MyClassLibrary;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Dead_and_Injured
{
    public partial class GameplayForm : Form
    {
        Player Player1;
        Player Player2;
        private int _ticks;
        private int roundLimit = 65;

        public GameplayForm()
        {
            InitializeComponent();
        }

        public GameplayForm(string[,] PDetails)
        {
            InitializeComponent();
            Player1 = new Player(PDetails[1, 0], PDetails[1, 1]);
            Player2 = new Player(PDetails[2, 0], PDetails[2, 1]);
        }

        private void GameplayForm_Load(object sender, EventArgs e)
        {
            PlayerOneGroupbox.Text = Player1.Name;
            PlayerTwoGroupbox.Text = Player2.Name;

            RoundTimer.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GamePlayCompare(Player1, Player2, PlayerOneNumCompareTextbox, PlayerOneDisplayTextbox, PlayerOneGroupbox, PlayerTwoGroupbox);
            //Reset time countdown
            _ticks = 0;
        }

        private void PlayerTwoCompareButton_Click(object sender, EventArgs e)
        {
            GamePlayCompare(Player2, Player1, PlayerTwoNumCompareTextbox, PlayerTwoDisplayTextbox, PlayerTwoGroupbox, PlayerOneGroupbox);
            //Reset time countdown
            _ticks = 0;
        }

        private void GamePlayCompare(Player activeP, Player passiveP, TextBox T, TextBox dispT, GroupBox activeG, GroupBox passiveG)
        {
            string response = activeP.Compare(T, passiveP);
            if (response == null) { MessageBox.Show("Invalid Entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string display = T.Text + " - " + response;
            dispT.Text += display + "\r\n";
            Operation.ScrollTextBox(dispT);
            T.ResetText();
            if(response == Operation.WinWord) 
            { 
                MessageBox.Show($"{activeP.Name} won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RoundTimer.Stop();
                activeG.Enabled = false;
                return;
            }
            passiveG.Enabled = true;
            activeG.Enabled = false;
        }

        private void RoundTimer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            int myCountdown = roundLimit - _ticks;
            TimeCountLabel.Text = myCountdown.ToString();
            if (_ticks == roundLimit)
            {
                RoundTimer.Stop();

                if(PlayerOneGroupbox.Enabled == true)
                {
                    SwitchPlayer(PlayerOneGroupbox, PlayerTwoGroupbox);
                }
                else if(PlayerTwoGroupbox.Enabled == true)
                {
                    SwitchPlayer(PlayerTwoGroupbox, PlayerOneGroupbox);
                }
                _ticks = 0;
                RoundTimer.Start();
            }
        }

        private void SwitchPlayer(GroupBox G1, GroupBox G2)
        {
            G1.Enabled = false;
            MessageBox.Show("You took forever!", "Timeout");
            G2.Enabled = true;
        }

        //private void SaveButton_Click(object sender, EventArgs e)
        //{
        //    string MySavedFileName = MyTasks.SaveFile();
        //    if(MySavedFileName == null) { return; }
        //    Operation.Saved = MySavedFileName;
        //    Stream stream = File.Open(MySavedFileName, FileMode.Create);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(stream, Player1);
        //    bf.Serialize(stream, Player2);
        //    MessageBox.Show("Game Saved");
        //    stream.Close();
        //    this.Close();
        //}
    }
}
