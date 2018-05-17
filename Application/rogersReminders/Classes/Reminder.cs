using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogersReminders
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


    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String DateOfBirth { get; set; }

    }

    class Student : Person
    {
        public Int32 StudentNumber { get; set; }
        public String StudentEmail { get; set; }
        public Int32 YearOfEnrolment { get; set; }

    }
    
}
