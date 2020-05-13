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
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SettingsForm Settings = new SettingsForm();
            Settings.ShowDialog();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not included in this version");
        }
    }
}
