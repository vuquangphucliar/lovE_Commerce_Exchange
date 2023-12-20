namespace GUI
{
    partial class frm_staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_confirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_backward = new System.Windows.Forms.Label();
            this.label_forward = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_index = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.label_quanity = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_link_3 = new System.Windows.Forms.Label();
            this.label_link_2 = new System.Windows.Forms.Label();
            this.label_link_1 = new System.Windows.Forms.Label();
            this.label_link_main = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_product_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_change_pwd = new System.Windows.Forms.Button();
            this.button_logOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Staff : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(223, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "LoveCrush";
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_products.ColumnHeadersHeight = 29;
            this.dataGridView_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_name,
            this.Column_date,
            this.Column_shop,
            this.Column_confirm});
            this.dataGridView_products.Location = new System.Drawing.Point(12, 102);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowHeadersWidth = 51;
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_products.Size = new System.Drawing.Size(738, 461);
            this.dataGridView_products.TabIndex = 3;
            this.dataGridView_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_products_CellClick);
            // 
            // Column_name
            // 
            this.Column_name.FillWeight = 133.6898F;
            this.Column_name.HeaderText = "Product name";
            this.Column_name.MinimumWidth = 6;
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_name.Width = 150;
            // 
            // Column_date
            // 
            this.Column_date.FillWeight = 67.47238F;
            this.Column_date.HeaderText = "Date";
            this.Column_date.MinimumWidth = 6;
            this.Column_date.Name = "Column_date";
            this.Column_date.ReadOnly = true;
            this.Column_date.Width = 125;
            // 
            // Column_shop
            // 
            this.Column_shop.FillWeight = 67.47238F;
            this.Column_shop.HeaderText = "Shop";
            this.Column_shop.MinimumWidth = 6;
            this.Column_shop.Name = "Column_shop";
            this.Column_shop.ReadOnly = true;
            this.Column_shop.Width = 125;
            // 
            // Column_confirm
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_confirm.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_confirm.FillWeight = 122.8315F;
            this.Column_confirm.HeaderText = "Confirm";
            this.Column_confirm.MinimumWidth = 6;
            this.Column_confirm.Name = "Column_confirm";
            this.Column_confirm.ReadOnly = true;
            this.Column_confirm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_confirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_confirm.Text = "Confirm";
            this.Column_confirm.UseColumnTextForButtonValue = true;
            this.Column_confirm.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_backward);
            this.groupBox1.Controls.Add(this.label_forward);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_index);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_desc);
            this.groupBox1.Controls.Add(this.label_quanity);
            this.groupBox1.Controls.Add(this.label_state);
            this.groupBox1.Controls.Add(this.label_link_3);
            this.groupBox1.Controls.Add(this.label_link_2);
            this.groupBox1.Controls.Add(this.label_link_1);
            this.groupBox1.Controls.Add(this.label_link_main);
            this.groupBox1.Controls.Add(this.label_price);
            this.groupBox1.Controls.Add(this.label_category);
            this.groupBox1.Controls.Add(this.label_product_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox_product);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(756, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 572);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product info";
            // 
            // label_backward
            // 
            this.label_backward.AutoSize = true;
            this.label_backward.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backward.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_backward.Location = new System.Drawing.Point(175, 84);
            this.label_backward.Name = "label_backward";
            this.label_backward.Size = new System.Drawing.Size(31, 36);
            this.label_backward.TabIndex = 8;
            this.label_backward.Text = "<";
            this.label_backward.Click += new System.EventHandler(this.label_backward_Click);
            this.label_backward.MouseLeave += new System.EventHandler(this.label_backward_MouseLeave);
            this.label_backward.MouseHover += new System.EventHandler(this.label_backward_MouseHover);
            // 
            // label_forward
            // 
            this.label_forward.AutoSize = true;
            this.label_forward.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forward.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_forward.Location = new System.Drawing.Point(361, 84);
            this.label_forward.Name = "label_forward";
            this.label_forward.Size = new System.Drawing.Size(31, 36);
            this.label_forward.TabIndex = 8;
            this.label_forward.Text = ">";
            this.label_forward.Click += new System.EventHandler(this.label_forward_Click);
            this.label_forward.MouseLeave += new System.EventHandler(this.label_forward_MouseLeave);
            this.label_forward.MouseHover += new System.EventHandler(this.label_forward_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "State         :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Category      :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price         :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description   :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_index
            // 
            this.label_index.AutoSize = true;
            this.label_index.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_index.Location = new System.Drawing.Point(260, 172);
            this.label_index.Name = "label_index";
            this.label_index.Size = new System.Drawing.Size(18, 20);
            this.label_index.TabIndex = 7;
            this.label_index.Text = "1";
            this.label_index.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "(";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "/ 4 )";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Location = new System.Drawing.Point(227, 427);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(80, 22);
            this.label_desc.TabIndex = 7;
            this.label_desc.Text = "Unknown";
            // 
            // label_quanity
            // 
            this.label_quanity.AutoSize = true;
            this.label_quanity.Location = new System.Drawing.Point(227, 297);
            this.label_quanity.Name = "label_quanity";
            this.label_quanity.Size = new System.Drawing.Size(80, 22);
            this.label_quanity.TabIndex = 7;
            this.label_quanity.Text = "Unknown";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(227, 385);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(80, 22);
            this.label_state.TabIndex = 7;
            this.label_state.Text = "Unknown";
            // 
            // label_link_3
            // 
            this.label_link_3.AutoSize = true;
            this.label_link_3.Enabled = false;
            this.label_link_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_link_3.Location = new System.Drawing.Point(405, 147);
            this.label_link_3.Name = "label_link_3";
            this.label_link_3.Size = new System.Drawing.Size(0, 22);
            this.label_link_3.TabIndex = 7;
            this.label_link_3.Visible = false;
            // 
            // label_link_2
            // 
            this.label_link_2.AutoSize = true;
            this.label_link_2.Enabled = false;
            this.label_link_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_link_2.Location = new System.Drawing.Point(405, 113);
            this.label_link_2.Name = "label_link_2";
            this.label_link_2.Size = new System.Drawing.Size(0, 22);
            this.label_link_2.TabIndex = 7;
            this.label_link_2.Visible = false;
            // 
            // label_link_1
            // 
            this.label_link_1.AutoSize = true;
            this.label_link_1.Enabled = false;
            this.label_link_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_link_1.Location = new System.Drawing.Point(405, 75);
            this.label_link_1.Name = "label_link_1";
            this.label_link_1.Size = new System.Drawing.Size(0, 22);
            this.label_link_1.TabIndex = 7;
            this.label_link_1.Visible = false;
            // 
            // label_link_main
            // 
            this.label_link_main.AutoSize = true;
            this.label_link_main.Enabled = false;
            this.label_link_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_link_main.Location = new System.Drawing.Point(405, 39);
            this.label_link_main.Name = "label_link_main";
            this.label_link_main.Size = new System.Drawing.Size(0, 22);
            this.label_link_main.TabIndex = 7;
            this.label_link_main.Visible = false;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(227, 255);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(80, 22);
            this.label_price.TabIndex = 7;
            this.label_price.Text = "Unknown";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Location = new System.Drawing.Point(227, 344);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(80, 22);
            this.label_category.TabIndex = 7;
            this.label_category.Text = "Unknown";
            // 
            // label_product_name
            // 
            this.label_product_name.AutoSize = true;
            this.label_product_name.Location = new System.Drawing.Point(227, 214);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(80, 22);
            this.label_product_name.TabIndex = 7;
            this.label_product_name.Text = "Unknown";
            this.label_product_name.Click += new System.EventHandler(this.label_product_name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name          :";
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_product.Location = new System.Drawing.Point(217, 28);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(138, 141);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_product.TabIndex = 6;
            this.pictureBox_product.TabStop = false;
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(646, 569);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(104, 44);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_change_pwd
            // 
            this.button_change_pwd.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_pwd.Location = new System.Drawing.Point(497, 569);
            this.button_change_pwd.Name = "button_change_pwd";
            this.button_change_pwd.Size = new System.Drawing.Size(143, 44);
            this.button_change_pwd.TabIndex = 4;
            this.button_change_pwd.Text = "Change Pwd";
            this.button_change_pwd.UseVisualStyleBackColor = true;
            this.button_change_pwd.Click += new System.EventHandler(this.button_change_pwd_Click);
            // 
            // button_logOut
            // 
            this.button_logOut.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logOut.Location = new System.Drawing.Point(387, 569);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(104, 44);
            this.button_logOut.TabIndex = 4;
            this.button_logOut.Text = "Log out";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // frm_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 658);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.button_change_pwd);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_staff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staffs";
            this.Load += new System.EventHandler(this.frm_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_backward;
        private System.Windows.Forms.Label label_forward;
        private System.Windows.Forms.Label label_index;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Label label_quanity;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_product_name;
        private System.Windows.Forms.Button button_change_pwd;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_shop;
        private System.Windows.Forms.DataGridViewButtonColumn Column_confirm;
        private System.Windows.Forms.Label label_link_main;
        private System.Windows.Forms.Label label_link_3;
        private System.Windows.Forms.Label label_link_2;
        private System.Windows.Forms.Label label_link_1;
    }
}