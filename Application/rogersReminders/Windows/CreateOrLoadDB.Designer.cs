namespace RogersReminders.Windows
{
    partial class CreateOrLoadDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlCreateOrLoadDB = new System.Windows.Forms.TabControl();
            this.tabPageLoadReminderDatabase = new System.Windows.Forms.TabPage();
            this.labelDBNotFound = new System.Windows.Forms.Label();
            this.labelNewDatabase = new System.Windows.Forms.Label();
            this.labelLoadPassword = new System.Windows.Forms.Label();
            this.textBoxLoadPassword = new System.Windows.Forms.TextBox();
            this.buttonLoadDatabase = new System.Windows.Forms.Button();
            this.comboBoxLoadDatabase = new System.Windows.Forms.ComboBox();
            this.tabPageCreateReminderDatabase = new System.Windows.Forms.TabPage();
            this.labelErrorCreation = new System.Windows.Forms.Label();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.labelCreateName = new System.Windows.Forms.Label();
            this.labelCreatePassword = new System.Windows.Forms.Label();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.buttonCreateDatabase = new System.Windows.Forms.Button();
            this.tabControlCreateOrLoadDB.SuspendLayout();
            this.tabPageLoadReminderDatabase.SuspendLayout();
            this.tabPageCreateReminderDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCreateOrLoadDB
            // 
            this.tabControlCreateOrLoadDB.Controls.Add(this.tabPageLoadReminderDatabase);
            this.tabControlCreateOrLoadDB.Controls.Add(this.tabPageCreateReminderDatabase);
            this.tabControlCreateOrLoadDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCreateOrLoadDB.Location = new System.Drawing.Point(0, 0);
            this.tabControlCreateOrLoadDB.Name = "tabControlCreateOrLoadDB";
            this.tabControlCreateOrLoadDB.SelectedIndex = 0;
            this.tabControlCreateOrLoadDB.Size = new System.Drawing.Size(284, 181);
            this.tabControlCreateOrLoadDB.TabIndex = 0;
            // 
            // tabPageLoadReminderDatabase
            // 
            this.tabPageLoadReminderDatabase.Controls.Add(this.labelDBNotFound);
            this.tabPageLoadReminderDatabase.Controls.Add(this.labelNewDatabase);
            this.tabPageLoadReminderDatabase.Controls.Add(this.labelLoadPassword);
            this.tabPageLoadReminderDatabase.Controls.Add(this.textBoxLoadPassword);
            this.tabPageLoadReminderDatabase.Controls.Add(this.buttonLoadDatabase);
            this.tabPageLoadReminderDatabase.Controls.Add(this.comboBoxLoadDatabase);
            this.tabPageLoadReminderDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoadReminderDatabase.Name = "tabPageLoadReminderDatabase";
            this.tabPageLoadReminderDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoadReminderDatabase.Size = new System.Drawing.Size(276, 155);
            this.tabPageLoadReminderDatabase.TabIndex = 0;
            this.tabPageLoadReminderDatabase.Text = "Load Reminder Database";
            this.tabPageLoadReminderDatabase.UseVisualStyleBackColor = true;
            // 
            // labelDBNotFound
            // 
            this.labelDBNotFound.AutoSize = true;
            this.labelDBNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDBNotFound.ForeColor = System.Drawing.Color.Red;
            this.labelDBNotFound.Location = new System.Drawing.Point(2, 43);
            this.labelDBNotFound.Name = "labelDBNotFound";
            this.labelDBNotFound.Size = new System.Drawing.Size(177, 26);
            this.labelDBNotFound.TabIndex = 14;
            this.labelDBNotFound.Text = "No database files were found.\r\nPlease create a new one.";
            this.labelDBNotFound.Visible = false;
            // 
            // labelNewDatabase
            // 
            this.labelNewDatabase.AutoSize = true;
            this.labelNewDatabase.Location = new System.Drawing.Point(6, 3);
            this.labelNewDatabase.Name = "labelNewDatabase";
            this.labelNewDatabase.Size = new System.Drawing.Size(122, 13);
            this.labelNewDatabase.TabIndex = 13;
            this.labelNewDatabase.Text = "Select database to load:";
            // 
            // labelLoadPassword
            // 
            this.labelLoadPassword.AutoSize = true;
            this.labelLoadPassword.Location = new System.Drawing.Point(2, 87);
            this.labelLoadPassword.Name = "labelLoadPassword";
            this.labelLoadPassword.Size = new System.Drawing.Size(117, 13);
            this.labelLoadPassword.TabIndex = 12;
            this.labelLoadPassword.Text = "Password: (If Required)";
            // 
            // textBoxLoadPassword
            // 
            this.textBoxLoadPassword.Location = new System.Drawing.Point(5, 103);
            this.textBoxLoadPassword.MaxLength = 256;
            this.textBoxLoadPassword.Name = "textBoxLoadPassword";
            this.textBoxLoadPassword.Size = new System.Drawing.Size(268, 20);
            this.textBoxLoadPassword.TabIndex = 2;
            this.textBoxLoadPassword.UseSystemPasswordChar = true;
            // 
            // buttonLoadDatabase
            // 
            this.buttonLoadDatabase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLoadDatabase.Location = new System.Drawing.Point(3, 129);
            this.buttonLoadDatabase.Name = "buttonLoadDatabase";
            this.buttonLoadDatabase.Size = new System.Drawing.Size(270, 23);
            this.buttonLoadDatabase.TabIndex = 3;
            this.buttonLoadDatabase.Text = "Load";
            this.buttonLoadDatabase.UseVisualStyleBackColor = true;
            this.buttonLoadDatabase.Click += new System.EventHandler(this.buttonLoadDatabase_Click);
            // 
            // comboBoxLoadDatabase
            // 
            this.comboBoxLoadDatabase.FormattingEnabled = true;
            this.comboBoxLoadDatabase.Location = new System.Drawing.Point(5, 19);
            this.comboBoxLoadDatabase.Name = "comboBoxLoadDatabase";
            this.comboBoxLoadDatabase.Size = new System.Drawing.Size(268, 21);
            this.comboBoxLoadDatabase.TabIndex = 1;
            // 
            // tabPageCreateReminderDatabase
            // 
            this.tabPageCreateReminderDatabase.Controls.Add(this.labelErrorCreation);
            this.tabPageCreateReminderDatabase.Controls.Add(this.textBoxCreateName);
            this.tabPageCreateReminderDatabase.Controls.Add(this.labelCreateName);
            this.tabPageCreateReminderDatabase.Controls.Add(this.labelCreatePassword);
            this.tabPageCreateReminderDatabase.Controls.Add(this.textBoxCreatePassword);
            this.tabPageCreateReminderDatabase.Controls.Add(this.buttonCreateDatabase);
            this.tabPageCreateReminderDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateReminderDatabase.Name = "tabPageCreateReminderDatabase";
            this.tabPageCreateReminderDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateReminderDatabase.Size = new System.Drawing.Size(276, 155);
            this.tabPageCreateReminderDatabase.TabIndex = 1;
            this.tabPageCreateReminderDatabase.Text = "Create Reminder Database";
            this.tabPageCreateReminderDatabase.UseVisualStyleBackColor = true;
            // 
            // labelErrorCreation
            // 
            this.labelErrorCreation.AutoSize = true;
            this.labelErrorCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCreation.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCreation.Location = new System.Drawing.Point(8, 43);
            this.labelErrorCreation.Name = "labelErrorCreation";
            this.labelErrorCreation.Size = new System.Drawing.Size(0, 13);
            this.labelErrorCreation.TabIndex = 15;
            this.labelErrorCreation.Visible = false;
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.Location = new System.Drawing.Point(5, 19);
            this.textBoxCreateName.MaxLength = 256;
            this.textBoxCreateName.Multiline = true;
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCreateName.Size = new System.Drawing.Size(268, 21);
            this.textBoxCreateName.TabIndex = 4;
            this.textBoxCreateName.Text = "default";
            // 
            // labelCreateName
            // 
            this.labelCreateName.AutoSize = true;
            this.labelCreateName.Location = new System.Drawing.Point(6, 3);
            this.labelCreateName.Name = "labelCreateName";
            this.labelCreateName.Size = new System.Drawing.Size(149, 13);
            this.labelCreateName.TabIndex = 8;
            this.labelCreateName.Text = "Enter name for new database:";
            // 
            // labelCreatePassword
            // 
            this.labelCreatePassword.AutoSize = true;
            this.labelCreatePassword.Location = new System.Drawing.Point(2, 80);
            this.labelCreatePassword.Name = "labelCreatePassword";
            this.labelCreatePassword.Size = new System.Drawing.Size(232, 13);
            this.labelCreatePassword.TabIndex = 7;
            this.labelCreatePassword.Text = "Password: (If you want to encrypt the database)";
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Location = new System.Drawing.Point(3, 96);
            this.textBoxCreatePassword.MaxLength = 256;
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(270, 20);
            this.textBoxCreatePassword.TabIndex = 5;
            this.textBoxCreatePassword.UseSystemPasswordChar = true;
            // 
            // buttonCreateDatabase
            // 
            this.buttonCreateDatabase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreateDatabase.Location = new System.Drawing.Point(3, 129);
            this.buttonCreateDatabase.Name = "buttonCreateDatabase";
            this.buttonCreateDatabase.Size = new System.Drawing.Size(270, 23);
            this.buttonCreateDatabase.TabIndex = 6;
            this.buttonCreateDatabase.Text = "Create";
            this.buttonCreateDatabase.UseVisualStyleBackColor = true;
            this.buttonCreateDatabase.Click += new System.EventHandler(this.buttonCreateDatabase_Click);
            // 
            // CreateOrLoadDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.tabControlCreateOrLoadDB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateOrLoadDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrLoadDB -- Rogers Reminders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrLoadDB_FormClosed);
            this.Load += new System.EventHandler(this.CreateOrLoadDB_Load);
            this.tabControlCreateOrLoadDB.ResumeLayout(false);
            this.tabPageLoadReminderDatabase.ResumeLayout(false);
            this.tabPageLoadReminderDatabase.PerformLayout();
            this.tabPageCreateReminderDatabase.ResumeLayout(false);
            this.tabPageCreateReminderDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCreateOrLoadDB;
        private System.Windows.Forms.TabPage tabPageLoadReminderDatabase;
        private System.Windows.Forms.TabPage tabPageCreateReminderDatabase;
        private System.Windows.Forms.Label labelCreateName;
        private System.Windows.Forms.Label labelCreatePassword;
        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.Button buttonCreateDatabase;
        private System.Windows.Forms.Label labelNewDatabase;
        private System.Windows.Forms.Label labelLoadPassword;
        private System.Windows.Forms.TextBox textBoxLoadPassword;
        private System.Windows.Forms.Button buttonLoadDatabase;
        private System.Windows.Forms.ComboBox comboBoxLoadDatabase;
        private System.Windows.Forms.Label labelDBNotFound;
        private System.Windows.Forms.TextBox textBoxCreateName;
        private System.Windows.Forms.Label labelErrorCreation;
    }
}