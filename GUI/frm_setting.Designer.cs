namespace GUI
{
    partial class frm_setting
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
            this.linkLabel_about = new System.Windows.Forms.LinkLabel();
            this.comboBox_noti = new System.Windows.Forms.ComboBox();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_remember = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel_about);
            this.groupBox1.Controls.Add(this.comboBox_noti);
            this.groupBox1.Controls.Add(this.comboBox_language);
            this.groupBox1.Controls.Add(this.button_back);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(68, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // linkLabel_about
            // 
            this.linkLabel_about.AutoSize = true;
            this.linkLabel_about.LinkVisited = true;
            this.linkLabel_about.Location = new System.Drawing.Point(126, 287);
            this.linkLabel_about.Name = "linkLabel_about";
            this.linkLabel_about.Size = new System.Drawing.Size(116, 27);
            this.linkLabel_about.TabIndex = 4;
            this.linkLabel_about.TabStop = true;
            this.linkLabel_about.Text = "About us";
            this.linkLabel_about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox_noti
            // 
            this.comboBox_noti.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_noti.FormattingEnabled = true;
            this.comboBox_noti.Items.AddRange(new object[] {
            "Yes",
            ""});
            this.comboBox_noti.Location = new System.Drawing.Point(221, 145);
            this.comboBox_noti.Name = "comboBox_noti";
            this.comboBox_noti.Size = new System.Drawing.Size(137, 28);
            this.comboBox_noti.TabIndex = 2;
            this.comboBox_noti.Text = "Yes";
            this.comboBox_noti.SelectedValueChanged += new System.EventHandler(this.comboBox_noti_SelectedValueChanged);
            // 
            // comboBox_language
            // 
            this.comboBox_language.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            "English"});
            this.comboBox_language.Location = new System.Drawing.Point(221, 96);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(137, 28);
            this.comboBox_language.TabIndex = 2;
            this.comboBox_language.Text = "English";
            this.comboBox_language.SelectedValueChanged += new System.EventHandler(this.comboBox_language_SelectedValueChanged);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.MintCream;
            this.button_back.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_back.Location = new System.Drawing.Point(33, 350);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(109, 35);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Aqua;
            this.button_save.Enabled = false;
            this.button_save.ForeColor = System.Drawing.SystemColors.Window;
            this.button_save.Location = new System.Drawing.Point(249, 350);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(109, 35);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(29, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_remember);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security";
            // 
            // comboBox_remember
            // 
            this.comboBox_remember.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_remember.FormattingEnabled = true;
            this.comboBox_remember.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_remember.Location = new System.Drawing.Point(200, 44);
            this.comboBox_remember.Name = "comboBox_remember";
            this.comboBox_remember.Size = new System.Drawing.Size(137, 28);
            this.comboBox_remember.TabIndex = 2;
            this.comboBox_remember.Text = "No";
            this.comboBox_remember.SelectedValueChanged += new System.EventHandler(this.comboBox_remember_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Remember me";
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 573);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MinimizeBox = false;
            this.Name = "frm_setting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_noti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_remember;
        private System.Windows.Forms.LinkLabel linkLabel_about;
        private System.Windows.Forms.Button button_back;
    }
}