using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Reminder
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime TimeCreated { get; set; }

    }

    class TimedReminder : Reminder
    {
        public DateTime RemindTime { get; set; }
    }

    class StaticReminder : Reminder
    {

    }
}
