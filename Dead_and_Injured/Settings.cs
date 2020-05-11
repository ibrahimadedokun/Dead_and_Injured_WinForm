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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsOKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numOfDigitsComboBox.Text) || string.IsNullOrEmpty(numOfPlayersComboBox.Text))
            {
                MessageBox.Show("Selection Required");
                return;
            }

            RegisterPlayerDataForm Register = new RegisterPlayerDataForm(int.Parse(numOfDigitsComboBox.Text));
            Register.Show();
        }
    }
}
