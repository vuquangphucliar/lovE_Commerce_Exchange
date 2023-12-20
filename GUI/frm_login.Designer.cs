namespace GUI
{
    partial class frm_login
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
            this.label_forgot_password = new System.Windows.Forms.Label();
            this.checkBox_remember_me = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label_create_account = new System.Windows.Forms.Label();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.comboBox_username = new System.Windows.Forms.ComboBox();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_forgot_password
            // 
            this.label_forgot_password.AutoSize = true;
            this.label_forgot_password.Location = new System.Drawing.Point(169, 247);
            this.label_forgot_password.Name = "label_forgot_password";
            this.label_forgot_password.Size = new System.Drawing.Size(162, 20);
            this.label_forgot_password.TabIndex = 1;
            this.label_forgot_password.Text = "Forgot password ?";
            this.label_forgot_password.Click += new System.EventHandler(this.label_forgot_password_Click);
            // 
            // checkBox_remember_me
            // 
            this.checkBox_remember_me.AutoSize = true;
            this.checkBox_remember_me.Location = new System.Drawing.Point(70, 207);
            this.checkBox_remember_me.Name = "checkBox_remember_me";
            this.checkBox_remember_me.Size = new System.Drawing.Size(130, 24);
            this.checkBox_remember_me.TabIndex = 3;
            this.checkBox_remember_me.Text = "Remember me";
            this.checkBox_remember_me.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "lovE Commerce v0.0.1";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(70, 148);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(261, 27);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(143, 304);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(109, 39);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_create_account
            // 
            this.label_create_account.AutoSize = true;
            this.label_create_account.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_create_account.Location = new System.Drawing.Point(183, 476);
            this.label_create_account.Name = "label_create_account";
            this.label_create_account.Size = new System.Drawing.Size(171, 20);
            this.label_create_account.TabIndex = 1;
            this.label_create_account.Text = "Create an account.";
            this.label_create_account.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.comboBox_username);
            this.groupBox_login.Controls.Add(this.button_login);
            this.groupBox_login.Controls.Add(this.label_forgot_password);
            this.groupBox_login.Controls.Add(this.label6);
            this.groupBox_login.Controls.Add(this.textBox_password);
            this.groupBox_login.Controls.Add(this.label5);
            this.groupBox_login.Controls.Add(this.checkBox_show_password);
            this.groupBox_login.Controls.Add(this.checkBox_remember_me);
            this.groupBox_login.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_login.ForeColor = System.Drawing.Color.Black;
            this.groupBox_login.Location = new System.Drawing.Point(65, 73);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_login.Size = new System.Drawing.Size(400, 400);
            this.groupBox_login.TabIndex = 5;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Log in";
            // 
            // comboBox_username
            // 
            this.comboBox_username.FormattingEnabled = true;
            this.comboBox_username.Items.AddRange(new object[] {
            "hey there",
            "Hi there"});
            this.comboBox_username.Location = new System.Drawing.Point(71, 87);
            this.comboBox_username.Name = "comboBox_username";
            this.comboBox_username.Size = new System.Drawing.Size(261, 28);
            this.comboBox_username.TabIndex = 5;
            this.comboBox_username.SelectedValueChanged += new System.EventHandler(this.comboBox_username_SelectedValueChanged);
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.Location = new System.Drawing.Point(70, 181);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(139, 24);
            this.checkBox_show_password.TabIndex = 3;
            this.checkBox_show_password.Text = "Show pasword";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // frm_login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(542, 573);
            this.Controls.Add(this.label_create_account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_login);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_forgot_password;
        private System.Windows.Forms.CheckBox checkBox_remember_me;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_create_account;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.CheckBox checkBox_show_password;
        private System.Windows.Forms.ComboBox comboBox_username;
    }
}