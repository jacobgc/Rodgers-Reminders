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
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.tabPageReminders = new System.Windows.Forms.TabPage();
            this.tabPageAddReminder = new System.Windows.Forms.TabPage();
            this.tabControlDifferentReminders = new System.Windows.Forms.TabControl();
            this.tabPageBasicReminder = new System.Windows.Forms.TabPage();
            this.buttonCreateReminder = new System.Windows.Forms.Button();
            this.tabPageTimeBasedReminder = new System.Windows.Forms.TabPage();
            this.dateTimePickerReminder = new System.Windows.Forms.DateTimePicker();
            this.tabPageGoalBasedReminder = new System.Windows.Forms.TabPage();
            this.TextBoxDebug = new System.Windows.Forms.TextBox();
            this.TextBoxReminderDescription = new System.Windows.Forms.TextBox();
            this.TextBoxReminderName = new System.Windows.Forms.TextBox();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlPages.SuspendLayout();
            this.tabPageAddReminder.SuspendLayout();
            this.tabControlDifferentReminders.SuspendLayout();
            this.tabPageBasicReminder.SuspendLayout();
            this.tabPageTimeBasedReminder.SuspendLayout();
            this.tabPageGoalBasedReminder.SuspendLayout();
            this.tabPageCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPages
            // 
            this.tabControlPages.Controls.Add(this.tabPageReminders);
            this.tabControlPages.Controls.Add(this.tabPageAddReminder);
            this.tabControlPages.Controls.Add(this.tabPageCalendar);
            this.tabControlPages.Controls.Add(this.tabPageSettings);
            this.tabControlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPages.Location = new System.Drawing.Point(0, 0);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(925, 485);
            this.tabControlPages.TabIndex = 6;
            // 
            // tabPageReminders
            // 
            this.tabPageReminders.Location = new System.Drawing.Point(4, 22);
            this.tabPageReminders.Name = "tabPageReminders";
            this.tabPageReminders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReminders.Size = new System.Drawing.Size(917, 459);
            this.tabPageReminders.TabIndex = 0;
            this.tabPageReminders.Text = "Reminders";
            this.tabPageReminders.UseVisualStyleBackColor = true;
            // 
            // tabPageAddReminder
            // 
            this.tabPageAddReminder.Controls.Add(this.tabControlDifferentReminders);
            this.tabPageAddReminder.Controls.Add(this.TextBoxDebug);
            this.tabPageAddReminder.Controls.Add(this.TextBoxReminderDescription);
            this.tabPageAddReminder.Controls.Add(this.TextBoxReminderName);
            this.tabPageAddReminder.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddReminder.Name = "tabPageAddReminder";
            this.tabPageAddReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReminder.Size = new System.Drawing.Size(917, 459);
            this.tabPageAddReminder.TabIndex = 1;
            this.tabPageAddReminder.Text = "Add Reminder";
            this.tabPageAddReminder.UseVisualStyleBackColor = true;
            // 
            // tabControlDifferentReminders
            // 
            this.tabControlDifferentReminders.Controls.Add(this.tabPageBasicReminder);
            this.tabControlDifferentReminders.Controls.Add(this.tabPageTimeBasedReminder);
            this.tabControlDifferentReminders.Controls.Add(this.tabPageGoalBasedReminder);
            this.tabControlDifferentReminders.Location = new System.Drawing.Point(6, 58);
            this.tabControlDifferentReminders.Name = "tabControlDifferentReminders";
            this.tabControlDifferentReminders.SelectedIndex = 0;
            this.tabControlDifferentReminders.Size = new System.Drawing.Size(383, 283);
            this.tabControlDifferentReminders.TabIndex = 12;
            // 
            // tabPageBasicReminder
            // 
            this.tabPageBasicReminder.Controls.Add(this.buttonCreateReminder);
            this.tabPageBasicReminder.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasicReminder.Name = "tabPageBasicReminder";
            this.tabPageBasicReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasicReminder.Size = new System.Drawing.Size(375, 257);
            this.tabPageBasicReminder.TabIndex = 0;
            this.tabPageBasicReminder.Text = "Basic Reminder";
            this.tabPageBasicReminder.UseVisualStyleBackColor = true;
            // 
            // buttonCreateReminder
            // 
            this.buttonCreateReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateReminder.Location = new System.Drawing.Point(3, 3);
            this.buttonCreateReminder.Name = "buttonCreateReminder";
            this.buttonCreateReminder.Size = new System.Drawing.Size(369, 251);
            this.buttonCreateReminder.TabIndex = 9;
            this.buttonCreateReminder.Text = "Create Reminder";
            this.buttonCreateReminder.UseVisualStyleBackColor = true;
            // 
            // tabPageTimeBasedReminder
            // 
            this.tabPageTimeBasedReminder.Controls.Add(this.dateTimePickerReminder);
            this.tabPageTimeBasedReminder.Location = new System.Drawing.Point(4, 22);
            this.tabPageTimeBasedReminder.Name = "tabPageTimeBasedReminder";
            this.tabPageTimeBasedReminder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimeBasedReminder.Size = new System.Drawing.Size(375, 257);
            this.tabPageTimeBasedReminder.TabIndex = 1;
            this.tabPageTimeBasedReminder.Text = "Time Based Reminder";
            this.tabPageTimeBasedReminder.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReminder
            // 
            this.dateTimePickerReminder.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerReminder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerReminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReminder.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerReminder.Name = "dateTimePickerReminder";
            this.dateTimePickerReminder.Size = new System.Drawing.Size(369, 20);
            this.dateTimePickerReminder.TabIndex = 9;
            this.dateTimePickerReminder.Value = new System.DateTime(2018, 1, 19, 9, 33, 1, 0);
            // 
            // tabPageGoalBasedReminder
            // 
            this.tabPageGoalBasedReminder.Controls.Add(this.splitContainer1);
            this.tabPageGoalBasedReminder.Location = new System.Drawing.Point(4, 22);
            this.tabPageGoalBasedReminder.Name = "tabPageGoalBasedReminder";
            this.tabPageGoalBasedReminder.Size = new System.Drawing.Size(375, 257);
            this.tabPageGoalBasedReminder.TabIndex = 2;
            this.tabPageGoalBasedReminder.Text = "Goal Based Reminder";
            this.tabPageGoalBasedReminder.UseVisualStyleBackColor = true;
            // 
            // TextBoxDebug
            // 
            this.TextBoxDebug.Enabled = false;
            this.TextBoxDebug.Location = new System.Drawing.Point(6, 347);
            this.TextBoxDebug.Multiline = true;
            this.TextBoxDebug.Name = "TextBoxDebug";
            this.TextBoxDebug.Size = new System.Drawing.Size(903, 106);
            this.TextBoxDebug.TabIndex = 10;
            // 
            // TextBoxReminderDescription
            // 
            this.TextBoxReminderDescription.Location = new System.Drawing.Point(6, 32);
            this.TextBoxReminderDescription.Name = "TextBoxReminderDescription";
            this.TextBoxReminderDescription.Size = new System.Drawing.Size(383, 20);
            this.TextBoxReminderDescription.TabIndex = 7;
            // 
            // TextBoxReminderName
            // 
            this.TextBoxReminderName.Location = new System.Drawing.Point(6, 6);
            this.TextBoxReminderName.Name = "TextBoxReminderName";
            this.TextBoxReminderName.Size = new System.Drawing.Size(383, 20);
            this.TextBoxReminderName.TabIndex = 6;
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Controls.Add(this.monthCalendar1);
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Size = new System.Drawing.Size(917, 459);
            this.tabPageCalendar.TabIndex = 2;
            this.tabPageCalendar.Text = "Calendar";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 3);
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
            this.tabPageSettings.Size = new System.Drawing.Size(917, 459);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Go shopping",
            "Do X",
            "Do Y",
            "Get Petrol"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(375, 214);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(375, 257);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 485);
            this.Controls.Add(this.tabControlPages);
            this.Name = "MainWindow";
            this.Text = "Rogers Reminders";
            this.tabControlPages.ResumeLayout(false);
            this.tabPageAddReminder.ResumeLayout(false);
            this.tabPageAddReminder.PerformLayout();
            this.tabControlDifferentReminders.ResumeLayout(false);
            this.tabPageBasicReminder.ResumeLayout(false);
            this.tabPageTimeBasedReminder.ResumeLayout(false);
            this.tabPageGoalBasedReminder.ResumeLayout(false);
            this.tabPageCalendar.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage tabPageReminders;
        private System.Windows.Forms.TabPage tabPageAddReminder;
        private System.Windows.Forms.Button buttonCreateReminder;
        private System.Windows.Forms.TextBox TextBoxReminderDescription;
        private System.Windows.Forms.TextBox TextBoxReminderName;
        private System.Windows.Forms.TabControl tabControlDifferentReminders;
        private System.Windows.Forms.TabPage tabPageBasicReminder;
        private System.Windows.Forms.TabPage tabPageTimeBasedReminder;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.DateTimePicker dateTimePickerReminder;
        private System.Windows.Forms.TabPage tabPageGoalBasedReminder;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TextBoxDebug;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

