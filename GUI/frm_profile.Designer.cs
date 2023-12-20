using System.Drawing;

namespace GUI
{
    partial class frm_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_profile));
            this.groupBox_avt = new System.Windows.Forms.GroupBox();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_user_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.label_user_name = new System.Windows.Forms.Label();
            this.groupBox_avt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.groupBox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_avt
            // 
            this.groupBox_avt.Controls.Add(this.pictureBox_avatar);
            this.groupBox_avt.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_avt.Location = new System.Drawing.Point(15, 81);
            this.groupBox_avt.Name = "groupBox_avt";
            this.groupBox_avt.Size = new System.Drawing.Size(174, 217);
            this.groupBox_avt.TabIndex = 0;
            this.groupBox_avt.TabStop = false;
            this.groupBox_avt.Text = "Avatar";
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_avatar.Image")));
            this.pictureBox_avatar.Location = new System.Drawing.Point(3, 25);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(168, 189);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 0;
            this.pictureBox_avatar.TabStop = false;
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.comboBox_gender);
            this.groupBox_info.Controls.Add(this.textBox_phone_number);
            this.groupBox_info.Controls.Add(this.textBox_email);
            this.groupBox_info.Controls.Add(this.textBox_user_name);
            this.groupBox_info.Controls.Add(this.label4);
            this.groupBox_info.Controls.Add(this.label3);
            this.groupBox_info.Controls.Add(this.label2);
            this.groupBox_info.Controls.Add(this.label1);
            this.groupBox_info.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_info.Location = new System.Drawing.Point(192, 79);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(338, 280);
            this.groupBox_info.TabIndex = 1;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Information";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(142, 204);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(178, 30);
            this.comboBox_gender.TabIndex = 2;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone_number.Location = new System.Drawing.Point(142, 149);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(178, 31);
            this.textBox_phone_number.TabIndex = 1;
            this.textBox_phone_number.TextChanged += new System.EventHandler(this.textBox_phone_number_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(142, 100);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(178, 31);
            this.textBox_email.TabIndex = 1;
            // 
            // textBox_user_name
            // 
            this.textBox_user_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user_name.Location = new System.Drawing.Point(142, 48);
            this.textBox_user_name.Name = "textBox_user_name";
            this.textBox_user_name.ReadOnly = true;
            this.textBox_user_name.Size = new System.Drawing.Size(178, 31);
            this.textBox_user_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.Cyan;
            this.button_change.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_change.Location = new System.Drawing.Point(46, 304);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(99, 33);
            this.button_change.TabIndex = 2;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_name.ForeColor = System.Drawing.Color.Brown;
            this.label_user_name.Location = new System.Drawing.Point(130, 34);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(207, 27);
            this.label_user_name.TabIndex = 3;
            this.label_user_name.Text = "User: Lovecrush";
            // 
            // frm_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 573);
            this.Controls.Add(this.label_user_name);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox_avt);
            this.Name = "frm_profile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_profile_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_profile_FormClosed);
            this.groupBox_avt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_avt;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_user_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.Label label_user_name;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label4;
    }
}