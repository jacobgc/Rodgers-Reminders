using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogersReminders
{
    class Globals
    {
        public static string DatabaseName = "";    // Global variable to set the name of the database to use
        public static bool DatabaseEncryption = false;
        public static string DatabasePassword = ""; // Global password to use to lock the currently open database when the application closes
        public static List<TimedReminder> Reminders = new List<TimedReminder>();

    }
}
