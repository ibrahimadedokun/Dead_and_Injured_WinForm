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
    public partial class GameplayForm : Form
    {
        Player Player1;
        Player Player2;
        public static string WinWord = "Eureka!"; //This can be found in the Player Class in MyClassLibrary
        public GameplayForm()
        {
            InitializeComponent();
        }

        public GameplayForm(string[,] PDetails)
        {
            InitializeComponent();
            Player1 = new Player(PDetails[1, 0], int.Parse(PDetails[1, 1]));
            Player2 = new Player(PDetails[2, 0], int.Parse(PDetails[2, 1]));
        }

        private void GameplayForm_Load(object sender, EventArgs e)
        {
            PlayerOneGroupbox.Text = Player1.Name;
            PlayerTwoGroupbox.Text = Player2.Name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GamePlayCompare(Player1, Player2, PlayerOneNumCompareTextbox, PlayerOneDisplayTextbox, PlayerOneGroupbox, PlayerTwoGroupbox);
        }

        private void PlayerTwoCompareButton_Click(object sender, EventArgs e)
        {
            GamePlayCompare(Player2, Player1, PlayerTwoNumCompareTextbox, PlayerTwoDisplayTextbox, PlayerTwoGroupbox, PlayerOneGroupbox);
        }

        private void GamePlayCompare(Player activeP, Player passiveP, TextBox T, TextBox dispT, GroupBox activeG, GroupBox passiveG)
        {
            string response = activeP.Compare(T, passiveP);
            if (response == null) { MessageBox.Show("Invalid Entry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string display = T.Text + " - " + response;
            dispT.Text += display + "\r\n";
            T.ResetText();
            if(response == WinWord) 
            { 
                MessageBox.Show($"{activeP.Name} won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                activeG.Enabled = false;
                return;
            }
            passiveG.Enabled = true;
            activeG.Enabled = false;
        }
    }
}
