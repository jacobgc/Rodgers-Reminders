using RogersRemindersFrontend;
using System;
using System.Collections.Generic;
using System.IO;
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
            // Ensure there is a folder for local SQL databases
            System.IO.Directory.CreateDirectory("./databases"); // Create required folder
            //Changed to show the CreateOrLoadDB form rather than the MainWindow form
            var main_form = new Windows.CreateOrLoadDB();
            main_form.Show();
            Application.Run();

            // Run code here to encrypt database
            if (Globals.DatabaseEncryption)
            {
                Helpers.AESEncrypt("./databases/" + Globals.DatabaseName + ".sqlite.aes.decrypted", Globals.DatabasePassword);
                File.Delete("./databases/" + Globals.DatabaseName + ".sqlite.aes");
                File.Delete("./databases/" + Globals.DatabaseName + ".sqlite.aes.decrypted");
                File.Move("./databases/" + Globals.DatabaseName + ".sqlite.aes.decrypted.aes", "./databases/" + Globals.DatabaseName + ".sqlite.aes");
            }
        }
    }
}
