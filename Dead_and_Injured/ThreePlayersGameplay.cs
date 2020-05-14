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
            PlayerOneGroupbox.Text = Player1.Name;
            PlayerTwoGroupbox.Text = Player2.Name;
            PlayerThreeGroupbox.Text = Player3.Name;
        }

        private void PlayerOneCompareButton_Click(object sender, EventArgs e)
        {
            string response;
            if (PlayerOneSelectPlayer2Radio.Checked == true) { response = Player1.Compare(PlayerOneNumCompareTextbox, Player2); }
            else { response = Player1.Compare(PlayerOneNumCompareTextbox, Player3); }
        }
    }
}
