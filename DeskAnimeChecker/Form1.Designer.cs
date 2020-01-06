namespace DeskAnimeChecker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Apps = new System.Windows.Forms.ListBox();
            this.button_GetApps = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Auth = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.textBox_NewApp = new System.Windows.Forms.TextBox();
            this.listBox_AppsTitle = new System.Windows.Forms.ListBox();
            this.listBox_AppsId = new System.Windows.Forms.ListBox();
            this.label_NewApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_Apps
            // 
            this.listBox_Apps.FormattingEnabled = true;
            this.listBox_Apps.ItemHeight = 15;
            this.listBox_Apps.Location = new System.Drawing.Point(238, 23);
            this.listBox_Apps.Name = "listBox_Apps";
            this.listBox_Apps.Size = new System.Drawing.Size(261, 424);
            this.listBox_Apps.TabIndex = 5;
            // 
            // button_GetApps
            // 
            this.button_GetApps.Location = new System.Drawing.Point(113, 231);
            this.button_GetApps.Name = "button_GetApps";
            this.button_GetApps.Size = new System.Drawing.Size(111, 29);
            this.button_GetApps.TabIndex = 6;
            this.button_GetApps.Text = "Get Apps";
            this.button_GetApps.UseVisualStyleBackColor = true;
            this.button_GetApps.Click += new System.EventHandler(this.button_GetApps_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_Login.Location = new System.Drawing.Point(12, 42);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(203, 25);
            this.textBox_Login.TabIndex = 7;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox_Password.Location = new System.Drawing.Point(12, 105);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(203, 25);
            this.textBox_Password.TabIndex = 8;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // label_Login
            // 
            this.label_Login.Location = new System.Drawing.Point(12, 18);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(101, 20);
            this.label_Login.TabIndex = 9;
            this.label_Login.Text = "Login";
            // 
            // label_Password
            // 
            this.label_Password.Location = new System.Drawing.Point(12, 82);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(105, 20);
            this.label_Password.TabIndex = 10;
            this.label_Password.Text = "Password";
            // 
            // button_Auth
            // 
            this.button_Auth.Location = new System.Drawing.Point(58, 168);
            this.button_Auth.Name = "button_Auth";
            this.button_Auth.Size = new System.Drawing.Size(103, 29);
            this.button_Auth.TabIndex = 11;
            this.button_Auth.Text = "Auth";
            this.button_Auth.UseVisualStyleBackColor = true;
            this.button_Auth.Click += new System.EventHandler(this.button_Auth_Click);
            // 
            // label_Error
            // 
            this.label_Error.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_Error.Location = new System.Drawing.Point(28, 143);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(169, 22);
            this.label_Error.TabIndex = 12;
            this.label_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_NewApp
            // 
            this.textBox_NewApp.Location = new System.Drawing.Point(58, 287);
            this.textBox_NewApp.Name = "textBox_NewApp";
            this.textBox_NewApp.Size = new System.Drawing.Size(103, 23);
            this.textBox_NewApp.TabIndex = 13;
            this.textBox_NewApp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_NewApp_KeyDown);
            // 
            // listBox_AppsTitle
            // 
            this.listBox_AppsTitle.FormattingEnabled = true;
            this.listBox_AppsTitle.HorizontalScrollbar = true;
            this.listBox_AppsTitle.ItemHeight = 15;
            this.listBox_AppsTitle.Location = new System.Drawing.Point(10, 313);
            this.listBox_AppsTitle.Name = "listBox_AppsTitle";
            this.listBox_AppsTitle.Size = new System.Drawing.Size(103, 124);
            this.listBox_AppsTitle.TabIndex = 14;
            // 
            // listBox_AppsId
            // 
            this.listBox_AppsId.FormattingEnabled = true;
            this.listBox_AppsId.ItemHeight = 15;
            this.listBox_AppsId.Location = new System.Drawing.Point(121, 313);
            this.listBox_AppsId.Name = "listBox_AppsId";
            this.listBox_AppsId.Size = new System.Drawing.Size(103, 124);
            this.listBox_AppsId.TabIndex = 15;
            // 
            // label_NewApp
            // 
            this.label_NewApp.Location = new System.Drawing.Point(58, 269);
            this.label_NewApp.Name = "label_NewApp";
            this.label_NewApp.Size = new System.Drawing.Size(103, 15);
            this.label_NewApp.TabIndex = 16;
            this.label_NewApp.Text = "Id of new app";
            this.label_NewApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(512, 464);
            this.Controls.Add(this.label_NewApp);
            this.Controls.Add(this.listBox_AppsId);
            this.Controls.Add(this.listBox_AppsTitle);
            this.Controls.Add(this.textBox_NewApp);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.button_Auth);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.button_GetApps);
            this.Controls.Add(this.listBox_Apps);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apps Checker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_GetApps;
        private System.Windows.Forms.ListBox listBox_Apps;
        private System.Windows.Forms.Button button_Auth;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_NewApp;
        private System.Windows.Forms.ListBox listBox_AppsId;
        private System.Windows.Forms.ListBox listBox_AppsTitle;
        private System.Windows.Forms.TextBox textBox_NewApp;
    }
}