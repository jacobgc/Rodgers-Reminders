using RogersRemindersFrontend;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

using System.Windows.Forms;


namespace RogersReminders.Windows
{
    public partial class CreateOrLoadDB : Form
    {
        public CreateOrLoadDB()
        {
            InitializeComponent();
        }

        private void lookForDatabases() // Add to method so it can be called when a database is created
        {
            comboBoxLoadDatabase.Items.Clear(); // Remove any existing items
            string[] Databases = Directory.GetFiles(@"./databases/", "*.sqlite*"); // Create an array of all files ending in .sqlite within the databases folder
            foreach (string DataBaseName in Databases) // For every result
            {
                String TempName = DataBaseName.Replace("./databases/", string.Empty); // Remove the folder from the name
                TempName = TempName.Replace(".sqlite", string.Empty); // Remove the file extension from the name
                TempName = TempName.Replace(".aes", " (Encrypted)"); // Remove the file extension from the name
                comboBoxLoadDatabase.Items.Add(TempName); // Add the result to the comboBox
                comboBoxLoadDatabase.SelectedIndex = 0; // Select the first index of the comboBox (Cant be done out of the for loop due to exception if no results are returned)
            }
            if (comboBoxLoadDatabase.SelectedIndex == -1) // If the SelectedIndex is -1 (no results added) Disable loading databases as there are none created
            {
                labelDBNotFound.Visible = true;
                comboBoxLoadDatabase.Enabled = false;
                textBoxLoadPassword.Enabled = false;
                buttonLoadDatabase.Enabled = false;
            }
            else
            {
                labelDBNotFound.Visible = false;
                comboBoxLoadDatabase.Enabled = true;
                textBoxLoadPassword.Enabled = true;
                buttonLoadDatabase.Enabled = true;
            }
        }

        private void CreateOrLoadDB_Load(object sender, EventArgs e)
        {
            lookForDatabases();
        }

        private void buttonLoadDatabase_Click(object sender, EventArgs e)
        {
            string selectedDatabase = comboBoxLoadDatabase.Text;
            try
            {
                if (textBoxLoadPassword.Text != string.Empty)
                {
                    try
                    {
                        string tempName = comboBoxLoadDatabase.Text.Replace(" (Encrypted)", string.Empty);
                        Helpers.AESDecrypt("./databases/" + tempName + ".sqlite.aes", textBoxLoadPassword.Text);
                        Globals.DatabasePassword = textBoxLoadPassword.Text;
                        Globals.DatabaseName = tempName;
                        Globals.DatabaseEncryption = true;
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Password incorrect or database missing.");
                    }
                    // If password provided attempt to decrypt the database
                    File.Delete("./databases/" + textBoxCreateName.Text + ".sqlite");
                }
                else
                {
                    // No password provided so don't attempt to decrypt.
                    Globals.DatabaseName = comboBoxLoadDatabase.Text;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Hide();

                }
            }
            catch (Exception thrown)
            {
                Console.WriteLine(thrown.InnerException);
                throw;
            }
        }

        private void buttonCreateDatabase_Click(object sender, EventArgs e)
        {
            char[] CharacterArrayOfDatabaseName = textBoxCreateName.Text.ToCharArray(); // Create an array of characters from the provided string
            CharacterArrayOfDatabaseName = Array.FindAll<char>(CharacterArrayOfDatabaseName, (c => (char.IsLetterOrDigit(c) // Loop through the array looking for anything but letters, white space or a dash
                                              || char.IsWhiteSpace(c)
                                              || c == '-')));
            textBoxCreateName.Text = new string(CharacterArrayOfDatabaseName); // Output the character array as a new string


            Boolean canCreate = true; // Create a variable to allow creation of the database
            string[] Databases = Directory.GetFiles(@"./databases/", textBoxCreateName.Text + ".sqlite"); // Create an array of all files ending in .sqlite within the databases folder
            foreach (string DataBaseName in Databases) // For every result
            {
                canCreate = false; // If a database exists with that name, disalow its creation
            }
            if(canCreate == false) // If the database can't be created, explain why.
            {
                labelErrorCreation.Visible = true; // Show error that the database already exists
                labelErrorCreation.ForeColor = Color.Red;
                labelErrorCreation.Text = "Error: A database with that name\r\nalready exists.";
            }
            else
            {
                SQLiteConnection.CreateFile("./databases/" + textBoxCreateName.Text + ".sqlite"); // Use the SQLiteConnection to create the sqlite file

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=./databases/"+textBoxCreateName.Text+".sqlite;Version=3;");
                m_dbConnection.Open();

                string sql = "create table reminders (name varchar(255), date varchar(255), time varchar(255))";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                m_dbConnection.Close();

                labelErrorCreation.ForeColor = Color.Green; // Show success message
                labelErrorCreation.Visible = true;
                labelErrorCreation.Text = "successfully created database: " + textBoxCreateName.Text;

                if (textBoxCreatePassword.Text != "")
                {
                    Helpers.AESEncrypt("./databases/" + textBoxCreateName.Text + ".sqlite", textBoxCreatePassword.Text);
                    labelErrorCreation.Text = "successfully created and\r\nencrypted database: " + textBoxCreateName.Text;
                    File.Delete("./databases/" + textBoxCreateName.Text + ".sqlite");
                }

                lookForDatabases();

            }

        }

        private void CreateOrLoadDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
