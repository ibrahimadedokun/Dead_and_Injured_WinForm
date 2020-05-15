using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Dead_and_Injured
{
    public class MyTasks
    {
        public static string SaveFile()
        {
            string format = ".dat";
            string _savedFile = Interaction.InputBox("Choose file name (end with .dat)", "Save Game", "game001.dat", -1, -1);
            //Check if file is saved in .dat format
            string savedFileFormat = _savedFile.Substring((_savedFile.Length - 4), 4);
            if (savedFileFormat != format) {MessageBox.Show("Invalid Format"); return null; }
            else return _savedFile;
        }
    }
}
