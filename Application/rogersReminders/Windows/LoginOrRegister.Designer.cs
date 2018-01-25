namespace RogersReminders.Windows
{
    partial class LoginOrRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOrRegister));
            this.tabControlOnlineOrOffline = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.labelErrorCreation = new System.Windows.Forms.Label();
            this.tabControlOnlineOrOffline.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOnlineOrOffline
            // 
            this.tabControlOnlineOrOffline.Controls.Add(this.tabPageLogin);
            this.tabControlOnlineOrOffline.Controls.Add(this.tabPageRegister);
            this.tabControlOnlineOrOffline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOnlineOrOffline.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlOnlineOrOffline.Location = new System.Drawing.Point(0, 0);
            this.tabControlOnlineOrOffline.Name = "tabControlOnlineOrOffline";
            this.tabControlOnlineOrOffline.SelectedIndex = 0;
            this.tabControlOnlineOrOffline.Size = new System.Drawing.Size(284, 181);
            this.tabControlOnlineOrOffline.TabIndex = 2;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(276, 155);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.Controls.Add(this.labelErrorCreation);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(276, 155);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Register";
            this.tabPageRegister.UseVisualStyleBackColor = true;
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
            // LoginOrRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.tabControlOnlineOrOffline);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginOrRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginOrRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginOrRegister_FormClosed);
            this.tabControlOnlineOrOffline.ResumeLayout(false);
            this.tabPageRegister.ResumeLayout(false);
            this.tabPageRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOnlineOrOffline;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.Label labelErrorCreation;
    }
}