namespace GUI
{
    partial class frm_shop_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_shop_register));
            this.groupBox_register = new System.Windows.Forms.GroupBox();
            this.checkBox_terms = new System.Windows.Forms.CheckBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_shop_address = new System.Windows.Forms.TextBox();
            this.textBox_shop_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_register
            // 
            this.groupBox_register.Controls.Add(this.checkBox_terms);
            this.groupBox_register.Controls.Add(this.textBox_desc);
            this.groupBox_register.Controls.Add(this.button1);
            this.groupBox_register.Controls.Add(this.button_register);
            this.groupBox_register.Controls.Add(this.textBox_phone);
            this.groupBox_register.Controls.Add(this.textBox_shop_address);
            this.groupBox_register.Controls.Add(this.textBox_shop_name);
            this.groupBox_register.Controls.Add(this.label4);
            this.groupBox_register.Controls.Add(this.label3);
            this.groupBox_register.Controls.Add(this.label2);
            this.groupBox_register.Controls.Add(this.label1);
            this.groupBox_register.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_register.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox_register.Location = new System.Drawing.Point(408, 28);
            this.groupBox_register.Name = "groupBox_register";
            this.groupBox_register.Size = new System.Drawing.Size(389, 491);
            this.groupBox_register.TabIndex = 0;
            this.groupBox_register.TabStop = false;
            this.groupBox_register.Text = "Welcome to Shop registration";
            // 
            // checkBox_terms
            // 
            this.checkBox_terms.AutoSize = true;
            this.checkBox_terms.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_terms.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox_terms.Location = new System.Drawing.Point(61, 374);
            this.checkBox_terms.Name = "checkBox_terms";
            this.checkBox_terms.Size = new System.Drawing.Size(312, 48);
            this.checkBox_terms.TabIndex = 3;
            this.checkBox_terms.Text = "I have read accept with the \r\nTerms and privacy";
            this.checkBox_terms.UseVisualStyleBackColor = true;
            this.checkBox_terms.CheckedChanged += new System.EventHandler(this.checkBox_terms_CheckedChanged);
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(161, 210);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(212, 131);
            this.textBox_desc.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(27, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Cyan;
            this.button_register.Enabled = false;
            this.button_register.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.ForeColor = System.Drawing.Color.LightCyan;
            this.button_register.Location = new System.Drawing.Point(252, 428);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(121, 44);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(161, 168);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(212, 31);
            this.textBox_phone.TabIndex = 2;
            // 
            // textBox_shop_address
            // 
            this.textBox_shop_address.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_shop_address.Location = new System.Drawing.Point(161, 127);
            this.textBox_shop_address.Name = "textBox_shop_address";
            this.textBox_shop_address.Size = new System.Drawing.Size(212, 31);
            this.textBox_shop_address.TabIndex = 2;
            // 
            // textBox_shop_name
            // 
            this.textBox_shop_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_shop_name.Location = new System.Drawing.Point(161, 83);
            this.textBox_shop_name.Name = "textBox_shop_name";
            this.textBox_shop_name.Size = new System.Drawing.Size(212, 31);
            this.textBox_shop_name.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(18, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shop address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 69);
            this.label5.TabIndex = 2;
            this.label5.Text = "         Join us\r\nand receive fantastic deals \r\n      register now !\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(73, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "* Special Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(73, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "* Free gift";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(73, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "* Shopping offers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(73, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "* Member exclusive privileges";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(73, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "* Free shipping deals";
            // 
            // frm_shop_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_register);
            this.Name = "frm_shop_register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Register";
            this.groupBox_register.ResumeLayout(false);
            this.groupBox_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_register;
        private System.Windows.Forms.TextBox textBox_shop_name;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_shop_address;
        private System.Windows.Forms.CheckBox checkBox_terms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}