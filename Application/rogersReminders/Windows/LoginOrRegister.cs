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
    public partial class LoginOrRegister : Form
    {
        public LoginOrRegister()
        {
            InitializeComponent();
        }

        private void LoginOrRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
