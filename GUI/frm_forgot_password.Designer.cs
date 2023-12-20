namespace GUI
{
    partial class frm_forgot_password
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_send_me_code = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_go_back_login = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.button_send_me_code);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset your password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "to reset your password.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "you a 6-digit code you can use";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your email and we\'ll send ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // textBox_email
            // 
            this.textBox_email.AcceptsTab = true;
            this.textBox_email.Location = new System.Drawing.Point(35, 131);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(293, 27);
            this.textBox_email.TabIndex = 1;
            // 
            // button_send_me_code
            // 
            this.button_send_me_code.Location = new System.Drawing.Point(100, 191);
            this.button_send_me_code.Name = "button_send_me_code";
            this.button_send_me_code.Size = new System.Drawing.Size(172, 44);
            this.button_send_me_code.TabIndex = 0;
            this.button_send_me_code.Text = "Send me code";
            this.button_send_me_code.UseVisualStyleBackColor = true;
            this.button_send_me_code.Click += new System.EventHandler(this.button_send_me_code_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "lovE Commerce v0.0.1";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_go_back_login
            // 
            this.label_go_back_login.AutoSize = true;
            this.label_go_back_login.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_go_back_login.Location = new System.Drawing.Point(174, 389);
            this.label_go_back_login.Name = "label_go_back_login";
            this.label_go_back_login.Size = new System.Drawing.Size(162, 20);
            this.label_go_back_login.TabIndex = 5;
            this.label_go_back_login.Text = "Go back to login.";
            this.label_go_back_login.Click += new System.EventHandler(this.label_go_back_login_Click);
            // 
            // frm_forgot_password
            // 
            this.AcceptButton = this.button_send_me_code;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 573);
            this.ControlBox = false;
            this.Controls.Add(this.label_go_back_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_forgot_password";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forgot password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_send_me_code;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_go_back_login;
    }
}