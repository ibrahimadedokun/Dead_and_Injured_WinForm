using MyClassLibrary;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
            Stream stream = null;
            BinaryFormatter bf = null;
            try
            {
                stream = File.Open(Operation.Saved, FileMode.Open);
                bf = new BinaryFormatter();
                Player newPlayer1 = (Player)bf.Deserialize(stream);
                Player newPlayer2 = (Player)bf.Deserialize(stream);
                stream.Close();
                MessageBox.Show("Loaded");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No saved game found");
            }
        }
    }
}
