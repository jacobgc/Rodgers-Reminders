using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogersReminders
{
    public class Reminder
    {
        public String Name { get; set; }
        public DateTime TimeCreated { get; set; }

    }

    public class TimedReminder : Reminder
    {
        public TimedReminder(string Name, DateTime Date, DateTime Time)
        {
            this.Name = Name;
            this.RemindDate = Date;
            this.RemindTime = Time;
            this.TimeCreated = new DateTime();
        }

        public DateTime RemindDate { get; set; }
        public DateTime RemindTime { get; set; }

    }
}
