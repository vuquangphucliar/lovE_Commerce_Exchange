namespace GUI
{
    partial class frm_verify_code
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labe_timer = new System.Windows.Forms.Label();
            this.maskedTextBox_verify_code = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_verify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_back_to_login = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labe_timer);
            this.groupBox1.Controls.Add(this.maskedTextBox_verify_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_verify);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verify Code";
            // 
            // labe_timer
            // 
            this.labe_timer.AutoSize = true;
            this.labe_timer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe_timer.ForeColor = System.Drawing.Color.IndianRed;
            this.labe_timer.Location = new System.Drawing.Point(158, 173);
            this.labe_timer.Name = "labe_timer";
            this.labe_timer.Size = new System.Drawing.Size(24, 18);
            this.labe_timer.TabIndex = 4;
            this.labe_timer.Text = "59";
            // 
            // maskedTextBox_verify_code
            // 
            this.maskedTextBox_verify_code.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_verify_code.Location = new System.Drawing.Point(82, 125);
            this.maskedTextBox_verify_code.Mask = "000000";
            this.maskedTextBox_verify_code.Name = "maskedTextBox_verify_code";
            this.maskedTextBox_verify_code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_verify_code.ShortcutsEnabled = false;
            this.maskedTextBox_verify_code.Size = new System.Drawing.Size(137, 31);
            this.maskedTextBox_verify_code.TabIndex = 3;
            this.maskedTextBox_verify_code.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "your account.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your code to identity";
            // 
            // button_verify
            // 
            this.button_verify.Location = new System.Drawing.Point(96, 208);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(111, 45);
            this.button_verify.TabIndex = 0;
            this.button_verify.Text = "Verify";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(121, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "00 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "lovE Commerce v0.0.1";
            // 
            // label_back_to_login
            // 
            this.label_back_to_login.AutoSize = true;
            this.label_back_to_login.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back_to_login.Location = new System.Drawing.Point(181, 390);
            this.label_back_to_login.Name = "label_back_to_login";
            this.label_back_to_login.Size = new System.Drawing.Size(162, 20);
            this.label_back_to_login.TabIndex = 6;
            this.label_back_to_login.Text = "Go back to login.";
            this.label_back_to_login.Click += new System.EventHandler(this.label_back_to_login_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_verify_code
            // 
            this.AcceptButton = this.button_verify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 573);
            this.Controls.Add(this.label_back_to_login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frm_verify_code";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verify Code";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_verify;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_verify_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_back_to_login;
        private System.Windows.Forms.Label labe_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}