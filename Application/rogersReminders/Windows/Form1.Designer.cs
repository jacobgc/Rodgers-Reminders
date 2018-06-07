namespace RogersReminders
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.tabPageReminders = new System.Windows.Forms.TabPage();
            this.tabPageAddReminder = new System.Windows.Forms.TabPage();
            this.dateTimePickerReminderTime = new System.Windows.Forms.DateTimePicker();
            this.buttonAddReminder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerReminderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxReminderName = new System.Windows.Forms.TextBox();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.listBoxReminders = new System.Windows.Forms.ListBox();
            this.tabControlPages.SuspendLayout();
            this.tabPageReminders.SuspendLayout();
            this.tabPageAddReminder.SuspendLayout();
            this.tabPageCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPages
            // 
            this.tabControlPages.Controls.Add(this.tabPageReminders);
            this.tabControlPages.Controls.Add(this.tabPageAddReminder);
            this.tabControlPages.Controls.Add(this.tabPageCalendar);
            this.tabControlPages.Controls.Add(this.tabPageSettings);
            this.tabControlPages.Location = new System.Drawing.Point(0, 24);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(691, 494);
            this.tabControlPages.TabIndex = 6;
            // 
            // tabPageReminders
            // 
            this.tabPageReminders.Controls.Add(this.listBoxReminders);
            this.tabPageReminders.Location = new System.Drawing.Point(4, 22);
            this.tabPageReminders.Name = "tabPageReminders";
            this.tabPageReminders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReminders.Size = new System.Drawing.Size(683, 468);
            this.tabPageReminders.TabIndex = 0;
            this.tabPageReminders.Text = "Reminders";
            this.tabPageReminders.UseVisualStyleBackColor = true;
            // 
            // tabPageAddReminder
            // 
            this.tabPageAddReminder.Controls.Add(this.dateTimePickerReminderTime);
            this.tabPageAddReminder.Controls.Add(this.buttonAddReminder);
            this.tabPageAddReminder.Controls.Add(this.label2);
            this.tabPageAddReminder.Controls.Add(this.dateTimePickerReminderDate);
            this.tabPageAddReminder.Controls.Add(this.label1);
            this.tabPageAddReminder.Controls.Add(this.TextBoxReminderName);
            this.tabPageAddReminder.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddReminder.Name = "tabPageAddReminder";
            this.tabPageAddReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReminder.Size = new System.Drawing.Size(683, 468);
            this.tabPageAddReminder.TabIndex = 1;
            this.tabPageAddReminder.Text = "Add Reminder";
            this.tabPageAddReminder.UseVisualStyleBackColor = true;
            this.tabPageAddReminder.Click += new System.EventHandler(this.tabPageAddReminder_Click);
            // 
            // dateTimePickerReminderTime
            // 
            this.dateTimePickerReminderTime.CustomFormat = "hh:mm";
            this.dateTimePickerReminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerReminderTime.Location = new System.Drawing.Point(392, 33);
            this.dateTimePickerReminderTime.Name = "dateTimePickerReminderTime";
            this.dateTimePickerReminderTime.ShowUpDown = true;
            this.dateTimePickerReminderTime.Size = new System.Drawing.Size(285, 20);
            this.dateTimePickerReminderTime.TabIndex = 11;
            this.dateTimePickerReminderTime.Value = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            // 
            // buttonAddReminder
            // 
            this.buttonAddReminder.Location = new System.Drawing.Point(6, 59);
            this.buttonAddReminder.Name = "buttonAddReminder";
            this.buttonAddReminder.Size = new System.Drawing.Size(671, 406);
            this.buttonAddReminder.TabIndex = 10;
            this.buttonAddReminder.Text = "Add Reminder!";
            this.buttonAddReminder.UseVisualStyleBackColor = true;
            this.buttonAddReminder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date to remind:";
            // 
            // dateTimePickerReminderDate
            // 
            this.dateTimePickerReminderDate.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerReminderDate.Location = new System.Drawing.Point(125, 33);
            this.dateTimePickerReminderDate.MinDate = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            this.dateTimePickerReminderDate.Name = "dateTimePickerReminderDate";
            this.dateTimePickerReminderDate.Size = new System.Drawing.Size(261, 20);
            this.dateTimePickerReminderDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reminder Name:";
            // 
            // TextBoxReminderName
            // 
            this.TextBoxReminderName.Location = new System.Drawing.Point(125, 6);
            this.TextBoxReminderName.Name = "TextBoxReminderName";
            this.TextBoxReminderName.Size = new System.Drawing.Size(552, 20);
            this.TextBoxReminderName.TabIndex = 6;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Controls.Add(this.monthCalendar1);
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Size = new System.Drawing.Size(683, 468);
            this.tabPageCalendar.TabIndex = 2;
            this.tabPageCalendar.Text = "Calendar";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.VisibleChanged += new System.EventHandler(this.monthCalendar1_VisibleChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(683, 468);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // listBoxReminders
            // 
            this.listBoxReminders.FormattingEnabled = true;
            this.listBoxReminders.Location = new System.Drawing.Point(9, 7);
            this.listBoxReminders.Name = "listBoxReminders";
            this.listBoxReminders.Size = new System.Drawing.Size(668, 446);
            this.listBoxReminders.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 530);
            this.Controls.Add(this.tabControlPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Rogers Reminders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControlPages.ResumeLayout(false);
            this.tabPageReminders.ResumeLayout(false);
            this.tabPageAddReminder.ResumeLayout(false);
            this.tabPageAddReminder.PerformLayout();
            this.tabPageCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage tabPageAddReminder;
        private System.Windows.Forms.TextBox TextBoxReminderName;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPageReminders;
        private System.Windows.Forms.Button buttonAddReminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminderTime;
        private System.Windows.Forms.ListBox listBoxReminders;
    }
}

