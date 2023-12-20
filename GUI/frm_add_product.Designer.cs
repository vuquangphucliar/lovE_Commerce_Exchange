namespace GUI
{
    partial class frm_add_product
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
            this.groupBox_product_info = new System.Windows.Forms.GroupBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_mode = new System.Windows.Forms.Label();
            this.pictureBox_main_image = new System.Windows.Forms.PictureBox();
            this.pictureBox_image_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_image_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_image_3 = new System.Windows.Forms.PictureBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_product_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_product_info
            // 
            this.groupBox_product_info.Controls.Add(this.comboBox_category);
            this.groupBox_product_info.Controls.Add(this.dateTimePicker_date);
            this.groupBox_product_info.Controls.Add(this.textBox_description);
            this.groupBox_product_info.Controls.Add(this.label6);
            this.groupBox_product_info.Controls.Add(this.label7);
            this.groupBox_product_info.Controls.Add(this.textBox_price);
            this.groupBox_product_info.Controls.Add(this.label1);
            this.groupBox_product_info.Controls.Add(this.textBox_quantity);
            this.groupBox_product_info.Controls.Add(this.label5);
            this.groupBox_product_info.Controls.Add(this.label4);
            this.groupBox_product_info.Controls.Add(this.textBox_name);
            this.groupBox_product_info.Controls.Add(this.label2);
            this.groupBox_product_info.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_product_info.Location = new System.Drawing.Point(34, 72);
            this.groupBox_product_info.Name = "groupBox_product_info";
            this.groupBox_product_info.Size = new System.Drawing.Size(402, 423);
            this.groupBox_product_info.TabIndex = 0;
            this.groupBox_product_info.TabStop = false;
            this.groupBox_product_info.Text = "Product info";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(144, 91);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(240, 28);
            this.comboBox_category.TabIndex = 5;
            this.comboBox_category.Text = "No category";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_date.Enabled = false;
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(144, 193);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(240, 27);
            this.dateTimePicker_date.TabIndex = 4;
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(144, 286);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(240, 122);
            this.textBox_description.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date";
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(144, 237);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(240, 29);
            this.textBox_price.TabIndex = 3;
            this.textBox_price.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(144, 139);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(240, 29);
            this.textBox_quantity.TabIndex = 3;
            this.textBox_quantity.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(144, 41);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(240, 29);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mode.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_mode.Location = new System.Drawing.Point(362, 23);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(207, 27);
            this.label_mode.TabIndex = 1;
            this.label_mode.Text = "Add new product";
            // 
            // pictureBox_main_image
            // 
            this.pictureBox_main_image.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_main_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_main_image.Location = new System.Drawing.Point(568, 113);
            this.pictureBox_main_image.Name = "pictureBox_main_image";
            this.pictureBox_main_image.Size = new System.Drawing.Size(194, 190);
            this.pictureBox_main_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_main_image.TabIndex = 2;
            this.pictureBox_main_image.TabStop = false;
            this.pictureBox_main_image.Click += new System.EventHandler(this.pictureBox_main_image_Click);
            // 
            // pictureBox_image_1
            // 
            this.pictureBox_image_1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_image_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image_1.Location = new System.Drawing.Point(506, 309);
            this.pictureBox_image_1.Name = "pictureBox_image_1";
            this.pictureBox_image_1.Size = new System.Drawing.Size(105, 106);
            this.pictureBox_image_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image_1.TabIndex = 2;
            this.pictureBox_image_1.TabStop = false;
            this.pictureBox_image_1.Click += new System.EventHandler(this.pictureBox_main_image_Click);
            // 
            // pictureBox_image_2
            // 
            this.pictureBox_image_2.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_image_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image_2.Location = new System.Drawing.Point(617, 309);
            this.pictureBox_image_2.Name = "pictureBox_image_2";
            this.pictureBox_image_2.Size = new System.Drawing.Size(105, 106);
            this.pictureBox_image_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image_2.TabIndex = 2;
            this.pictureBox_image_2.TabStop = false;
            this.pictureBox_image_2.Click += new System.EventHandler(this.pictureBox_main_image_Click);
            // 
            // pictureBox_image_3
            // 
            this.pictureBox_image_3.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_image_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image_3.Location = new System.Drawing.Point(728, 309);
            this.pictureBox_image_3.Name = "pictureBox_image_3";
            this.pictureBox_image_3.Size = new System.Drawing.Size(105, 106);
            this.pictureBox_image_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_image_3.TabIndex = 2;
            this.pictureBox_image_3.TabStop = false;
            this.pictureBox_image_3.Click += new System.EventHandler(this.pictureBox_main_image_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Aqua;
            this.button_confirm.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_confirm.Location = new System.Drawing.Point(591, 441);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(153, 39);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Images";
            // 
            // frm_add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.pictureBox_image_3);
            this.Controls.Add(this.pictureBox_image_2);
            this.Controls.Add(this.pictureBox_image_1);
            this.Controls.Add(this.pictureBox_main_image);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.groupBox_product_info);
            this.Name = "frm_add_product";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Product";
            this.Load += new System.EventHandler(this.frm_add_product_Load);
            this.groupBox_product_info.ResumeLayout(false);
            this.groupBox_product_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_product_info;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox_main_image;
        private System.Windows.Forms.PictureBox pictureBox_image_1;
        private System.Windows.Forms.PictureBox pictureBox_image_2;
        private System.Windows.Forms.PictureBox pictureBox_image_3;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label1;
    }
}