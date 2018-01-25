namespace RogersReminders.Windows
{
    partial class OfflineOrOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineOrOnline));
            this.tabControlOnlineOrOffline = new System.Windows.Forms.TabControl();
            this.tabPageOnline = new System.Windows.Forms.TabPage();
            this.buttonLoadOnline = new System.Windows.Forms.Button();
            this.tabPageOffline = new System.Windows.Forms.TabPage();
            this.labelErrorCreation = new System.Windows.Forms.Label();
            this.buttonOfflineLoad = new System.Windows.Forms.Button();
            this.tabControlOnlineOrOffline.SuspendLayout();
            this.tabPageOnline.SuspendLayout();
            this.tabPageOffline.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOnlineOrOffline
            // 
            this.tabControlOnlineOrOffline.Controls.Add(this.tabPageOnline);
            this.tabControlOnlineOrOffline.Controls.Add(this.tabPageOffline);
            this.tabControlOnlineOrOffline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOnlineOrOffline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlOnlineOrOffline.Location = new System.Drawing.Point(0, 0);
            this.tabControlOnlineOrOffline.Name = "tabControlOnlineOrOffline";
            this.tabControlOnlineOrOffline.SelectedIndex = 0;
            this.tabControlOnlineOrOffline.Size = new System.Drawing.Size(284, 181);
            this.tabControlOnlineOrOffline.TabIndex = 1;
            // 
            // tabPageOnline
            // 
            this.tabPageOnline.Controls.Add(this.buttonLoadOnline);
            this.tabPageOnline.Location = new System.Drawing.Point(4, 22);
            this.tabPageOnline.Name = "tabPageOnline";
            this.tabPageOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOnline.Size = new System.Drawing.Size(276, 155);
            this.tabPageOnline.TabIndex = 0;
            this.tabPageOnline.Text = "Online";
            this.tabPageOnline.UseVisualStyleBackColor = true;
            // 
            // buttonLoadOnline
            // 
            this.buttonLoadOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadOnline.Location = new System.Drawing.Point(3, 3);
            this.buttonLoadOnline.Name = "buttonLoadOnline";
            this.buttonLoadOnline.Size = new System.Drawing.Size(270, 149);
            this.buttonLoadOnline.TabIndex = 3;
            this.buttonLoadOnline.Text = "Load ONLINE Client";
            this.buttonLoadOnline.UseVisualStyleBackColor = true;
            this.buttonLoadOnline.Click += new System.EventHandler(this.buttonLoadOnline_Click);
            // 
            // tabPageOffline
            // 
            this.tabPageOffline.Controls.Add(this.labelErrorCreation);
            this.tabPageOffline.Controls.Add(this.buttonOfflineLoad);
            this.tabPageOffline.Location = new System.Drawing.Point(4, 22);
            this.tabPageOffline.Name = "tabPageOffline";
            this.tabPageOffline.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffline.Size = new System.Drawing.Size(276, 155);
            this.tabPageOffline.TabIndex = 1;
            this.tabPageOffline.Text = "Offline";
            this.tabPageOffline.UseVisualStyleBackColor = true;
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
            // buttonOfflineLoad
            // 
            this.buttonOfflineLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOfflineLoad.Location = new System.Drawing.Point(3, 3);
            this.buttonOfflineLoad.Name = "buttonOfflineLoad";
            this.buttonOfflineLoad.Size = new System.Drawing.Size(270, 149);
            this.buttonOfflineLoad.TabIndex = 6;
            this.buttonOfflineLoad.Text = "Load OFFLINE Client";
            this.buttonOfflineLoad.UseVisualStyleBackColor = true;
            this.buttonOfflineLoad.Click += new System.EventHandler(this.buttonOfflineLoad_Click);
            // 
            // OfflineOrOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.tabControlOnlineOrOffline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OfflineOrOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfflineOrOnline";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OfflineOrOnline_FormClosed);
            this.tabControlOnlineOrOffline.ResumeLayout(false);
            this.tabPageOnline.ResumeLayout(false);
            this.tabPageOffline.ResumeLayout(false);
            this.tabPageOffline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOnlineOrOffline;
        private System.Windows.Forms.TabPage tabPageOnline;
        private System.Windows.Forms.Button buttonLoadOnline;
        private System.Windows.Forms.TabPage tabPageOffline;
        private System.Windows.Forms.Label labelErrorCreation;
        private System.Windows.Forms.Button buttonOfflineLoad;
    }
}