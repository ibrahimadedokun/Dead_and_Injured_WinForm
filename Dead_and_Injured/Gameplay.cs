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
        public GameplayForm()
        {
            InitializeComponent();
        }

        public GameplayForm(string P1name, string P1num, string P2name, string P2num)
        {
            InitializeComponent();
            Player1 = new Player(P1name, int.Parse(P1num));
            Player2 = new Player(P2name, int.Parse(P2num));
        }

        private void GameplayForm_Load(object sender, EventArgs e)
        {
            PlayerOneGroupbox.Text = Player1.Name;
            PlayerTwoGroupbox.Text = Player2.Name;
        }

        private void PlayerOneGroupbox_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
