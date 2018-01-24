﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RogersReminders
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Changed to show the CreateOrLoadDB form rather than the MainWindow form
            var main_form = new Windows.OfflineOrOnline();
            main_form.Show();
            Application.Run();

            // Ensure there is a folder for local SQL databases
            System.IO.Directory.CreateDirectory("./databases");

        }
    }
}
