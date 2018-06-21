using System;
using System.Data.SQLite;
using System.Windows.Forms;
namespace RogersReminders
{

    public partial class MainWindow : Form
    {
        string DatabaseName = "";

        public MainWindow()
        {
            if (Globals.DatabaseEncryption)
            {
                DatabaseName = Globals.DatabaseName + ".sqlite.aes.decrypted";
            }
            else
            {
                DatabaseName = Globals.DatabaseName + ".sqlite";
            }
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if(TextBoxReminderName.Text != string.empty){
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=./databases/" + DatabaseName + ";Version=3;");
                m_dbConnection.Open();

                string sql = "INSERT INTO reminders (name, date, time) VALUES('"+ TextBoxReminderName.Text +"', '"+ dateTimePickerReminderDate.Value.ToShortDateString() +"', '"+dateTimePickerReminderTime.Value.ToShortTimeString()+"')";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                m_dbConnection.Close();

                tabControlPages.SelectTab(0);
                updateReminders();
            }else{
                MessageBox.Show("Please enter a name for your reminder");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void monthCalendar1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dateTimePickerReminderTime.Value = DateTime.Now.AddHours(1);
            dateTimePickerReminderDate.Value = DateTime.Now;

            updateReminders();

        }

        private void updateReminders()
        {
            Globals.Reminders.Clear();
            listBoxReminders.Items.Clear();

            // Load data from SQLite file specified in the GLOBALS
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=./databases/" + DatabaseName + ";Version=3;");
            m_dbConnection.Open();

            string sql = "SELECT * FROM 'reminders'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
                Globals.Reminders.Add(new TimedReminder(reader["name"].ToString(), DateTime.Parse(reader["date"].ToString()), DateTime.Parse(reader["time"].ToString())));

            m_dbConnection.Close();


            foreach (var Reminder in Globals.Reminders)
            {
                listBoxReminders.Items.Add(Reminder.Name + " : " + Reminder.RemindDate.ToShortDateString() + " : " + Reminder.RemindTime.ToShortTimeString());
            }

        }

        private void tabPageAddReminder_Click(object sender, EventArgs e)
        {

        }
    }
}
