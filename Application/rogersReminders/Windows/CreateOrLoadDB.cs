using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersReminders.Windows
{
    public partial class CreateOrLoadDB : Form
    {
        public CreateOrLoadDB()
        {
            InitializeComponent();
        }

        private void CreateOrLoadDB_Load(object sender, EventArgs e)
        {
            string[] Databases = Directory.GetFiles(@"./databases/", "*.sqlite"); // Create an array of all files ending in .sqlite within the databases folder
            foreach (string DataBaseName in Databases) // For every result
            {
                String TempName = DataBaseName.Replace("./databases/", string.Empty); // Remove the folder from the name
                TempName = TempName.Replace(".sqlite", string.Empty); // Remove the file extension from the name
                comboBoxLoadDatabase.Items.Add(TempName); // Add the result to the comboBox
                comboBoxLoadDatabase.SelectedIndex = 0; // Select the first index of the comboBox (Cant be done out of the for loop due to exception if no results are returned)
            }
            if (comboBoxLoadDatabase.SelectedIndex == -1) // If the SelectedIndex is -1 (no results added) Disable loading databases as there are none created
            {
                labelDBNotFound.Visible = true;
                comboBoxLoadDatabase.Enabled = false;
                textBoxLoadPassword.Enabled = false;
                buttonLoadDatabase.Enabled = false;
            }
        }

        private void buttonLoadDatabase_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("./databases/.sqlite");

        }
    }
}
