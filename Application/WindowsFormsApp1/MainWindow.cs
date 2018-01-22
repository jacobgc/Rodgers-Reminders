using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


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

        private void button1_Click(object sender, EventArgs e)
        {
                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n Creating instance of StaticReminder";
                StaticReminder NewStaticReminder = new StaticReminder();
                NewStaticReminder.Name = TextBoxReminderName.Text;
                NewStaticReminder.Description = TextBoxReminderDescription.Text;
                NewStaticReminder.TimeCreated = DateTime.Now;

                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewStaticReminder.Name: " + NewStaticReminder.Name;
                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewStaticReminder.Description: " + NewStaticReminder.Description;
                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewStaticReminder.TimeCreated: " + NewStaticReminder.TimeCreated;

                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n Creating instance of TimedReminder";
                TimedReminder NewTimedReminder = new TimedReminder();
                NewTimedReminder.Name = TextBoxReminderName.Text;
                NewTimedReminder.Description = TextBoxReminderDescription.Text;
                NewTimedReminder.RemindTime = dateTimePickerReminder.Value;
                NewTimedReminder.TimeCreated = DateTime.Now;

                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewTimedReminder.Name: " + NewTimedReminder.Name;
                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewTimedReminder.Description: " + NewTimedReminder.Description;
                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewTimedReminder.RemindTime: " + NewTimedReminder.RemindTime;
                TextBoxDebug.Text = TextBoxDebug.Text + "\r\n NewTimedReminder.TimeCreated: " + NewTimedReminder.TimeCreated;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void monthCalendar1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
