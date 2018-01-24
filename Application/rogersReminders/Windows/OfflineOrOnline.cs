using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersReminders.Windows
{
    public partial class OfflineOrOnline : Form
    {
        public OfflineOrOnline()
        {
            InitializeComponent();
        }

        private void buttonOfflineLoad_Click(object sender, EventArgs e)
        {
            Globals.ONLINE = false; // Set global ONLINE variable to signel to the rest of the application that we run offline
            this.Hide(); // hide the current widnow
            CreateOrLoadDB createOrLoadDB = new CreateOrLoadDB(); // Create a new instance of the CreatOrLoadDB window
            createOrLoadDB.Show();  // Show the window
        }

        private void OfflineOrOnline_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
