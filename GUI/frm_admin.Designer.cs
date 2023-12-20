namespace GUI
{
    partial class frm_admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_discount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_today = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_new = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_expire = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_picture = new System.Windows.Forms.ComboBox();
            this.textBox_staff_phone = new System.Windows.Forms.TextBox();
            this.textBox_staff_email = new System.Windows.Forms.TextBox();
            this.textBox_staff_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_staff_delete = new System.Windows.Forms.Button();
            this.button_staff_insert = new System.Windows.Forms.Button();
            this.button_staff_new = new System.Windows.Forms.Button();
            this.button_staff_load = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView_payment = new System.Windows.Forms.DataGridView();
            this.dataGridView_delivery = new System.Windows.Forms.DataGridView();
            this.textBox_delivery_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_delivery_address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_delivery_price = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_delivery_exit = new System.Windows.Forms.Button();
            this.button_delerery_delete = new System.Windows.Forms.Button();
            this.button_dellivery_insert = new System.Windows.Forms.Button();
            this.button_delivery_laod = new System.Windows.Forms.Button();
            this.button_delivery_load = new System.Windows.Forms.Button();
            this.textBox_payment_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_payment_description = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button_payment_exit = new System.Windows.Forms.Button();
            this.button_payment_delete = new System.Windows.Forms.Button();
            this.button_payment_insert = new System.Windows.Forms.Button();
            this.button_payment_load = new System.Windows.Forms.Button();
            this.button_payment_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(279, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "WelCome back LoveCrush";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(31, 138);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(31, 48);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(202, 29);
            this.textBox_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // textBox_code
            // 
            this.textBox_code.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_code.Location = new System.Drawing.Point(239, 48);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(188, 29);
            this.textBox_code.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code";
            // 
            // textBox_discount
            // 
            this.textBox_discount.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_discount.Location = new System.Drawing.Point(433, 48);
            this.textBox_discount.Name = "textBox_discount";
            this.textBox_discount.Size = new System.Drawing.Size(204, 29);
            this.textBox_discount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discount";
            // 
            // textBox_today
            // 
            this.textBox_today.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_today.Location = new System.Drawing.Point(31, 103);
            this.textBox_today.Name = "textBox_today";
            this.textBox_today.Size = new System.Drawing.Size(202, 29);
            this.textBox_today.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date active";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_quantity.Location = new System.Drawing.Point(433, 103);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(204, 29);
            this.textBox_quantity.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date expire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantity";
            // 
            // button_new
            // 
            this.button_new.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.Location = new System.Drawing.Point(639, 142);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(136, 37);
            this.button_new.TabIndex = 4;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_insert
            // 
            this.button_insert.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insert.Location = new System.Drawing.Point(639, 185);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(136, 37);
            this.button_insert.TabIndex = 4;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(639, 228);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(136, 37);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(639, 271);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(136, 37);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(639, 99);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(136, 37);
            this.button_load.TabIndex = 4;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox_expire
            // 
            this.textBox_expire.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_expire.Location = new System.Drawing.Point(239, 103);
            this.textBox_expire.Mask = "0000/00/00";
            this.textBox_expire.Name = "textBox_expire";
            this.textBox_expire.Size = new System.Drawing.Size(188, 29);
            this.textBox_expire.TabIndex = 5;
            this.textBox_expire.ValidatingType = typeof(System.DateTime);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 478);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_expire);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button_exit);
            this.tabPage1.Controls.Add(this.textBox_name);
            this.tabPage1.Controls.Add(this.textBox_code);
            this.tabPage1.Controls.Add(this.button_delete);
            this.tabPage1.Controls.Add(this.textBox_today);
            this.tabPage1.Controls.Add(this.button_insert);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button_load);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button_new);
            this.tabPage1.Controls.Add(this.textBox_discount);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox_quantity);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Vouchers   ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox_picture);
            this.tabPage2.Controls.Add(this.textBox_staff_phone);
            this.tabPage2.Controls.Add(this.textBox_staff_email);
            this.tabPage2.Controls.Add(this.textBox_staff_name);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button_staff_delete);
            this.tabPage2.Controls.Add(this.button_staff_insert);
            this.tabPage2.Controls.Add(this.button_staff_new);
            this.tabPage2.Controls.Add(this.button_staff_load);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  Staffs   ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_picture
            // 
            this.comboBox_picture.FormattingEnabled = true;
            this.comboBox_picture.Items.AddRange(new object[] {
            "<Browser for more>"});
            this.comboBox_picture.Location = new System.Drawing.Point(447, 66);
            this.comboBox_picture.Name = "comboBox_picture";
            this.comboBox_picture.Size = new System.Drawing.Size(182, 30);
            this.comboBox_picture.TabIndex = 4;
            this.comboBox_picture.SelectedIndexChanged += new System.EventHandler(this.comboBox_picture_SelectedIndexChanged);
            // 
            // textBox_staff_phone
            // 
            this.textBox_staff_phone.Location = new System.Drawing.Point(319, 66);
            this.textBox_staff_phone.Name = "textBox_staff_phone";
            this.textBox_staff_phone.Size = new System.Drawing.Size(122, 29);
            this.textBox_staff_phone.TabIndex = 3;
            // 
            // textBox_staff_email
            // 
            this.textBox_staff_email.Location = new System.Drawing.Point(191, 66);
            this.textBox_staff_email.Name = "textBox_staff_email";
            this.textBox_staff_email.Size = new System.Drawing.Size(122, 29);
            this.textBox_staff_email.TabIndex = 3;
            // 
            // textBox_staff_name
            // 
            this.textBox_staff_name.Location = new System.Drawing.Point(63, 66);
            this.textBox_staff_name.Name = "textBox_staff_name";
            this.textBox_staff_name.Size = new System.Drawing.Size(122, 29);
            this.textBox_staff_name.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Picture";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(635, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_staff_delete
            // 
            this.button_staff_delete.Location = new System.Drawing.Point(635, 239);
            this.button_staff_delete.Name = "button_staff_delete";
            this.button_staff_delete.Size = new System.Drawing.Size(108, 40);
            this.button_staff_delete.TabIndex = 1;
            this.button_staff_delete.Text = "Delete";
            this.button_staff_delete.UseVisualStyleBackColor = true;
            this.button_staff_delete.Click += new System.EventHandler(this.button_staff_delete_Click);
            // 
            // button_staff_insert
            // 
            this.button_staff_insert.Location = new System.Drawing.Point(635, 193);
            this.button_staff_insert.Name = "button_staff_insert";
            this.button_staff_insert.Size = new System.Drawing.Size(108, 40);
            this.button_staff_insert.TabIndex = 1;
            this.button_staff_insert.Text = "Insert";
            this.button_staff_insert.UseVisualStyleBackColor = true;
            this.button_staff_insert.Click += new System.EventHandler(this.button_staff_insert_Click);
            // 
            // button_staff_new
            // 
            this.button_staff_new.Location = new System.Drawing.Point(635, 147);
            this.button_staff_new.Name = "button_staff_new";
            this.button_staff_new.Size = new System.Drawing.Size(108, 40);
            this.button_staff_new.TabIndex = 1;
            this.button_staff_new.Text = "New";
            this.button_staff_new.UseVisualStyleBackColor = true;
            this.button_staff_new.Click += new System.EventHandler(this.button_staff_new_Click);
            // 
            // button_staff_load
            // 
            this.button_staff_load.Location = new System.Drawing.Point(635, 101);
            this.button_staff_load.Name = "button_staff_load";
            this.button_staff_load.Size = new System.Drawing.Size(108, 40);
            this.button_staff_load.TabIndex = 1;
            this.button_staff_load.Text = "Load";
            this.button_staff_load.UseVisualStyleBackColor = true;
            this.button_staff_load.Click += new System.EventHandler(this.button_staff_load_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(63, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(566, 316);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_payment_exit);
            this.tabPage3.Controls.Add(this.button_payment_delete);
            this.tabPage3.Controls.Add(this.button_payment_insert);
            this.tabPage3.Controls.Add(this.button_payment_load);
            this.tabPage3.Controls.Add(this.button_payment_new);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.textBox_payment_description);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.textBox_payment_name);
            this.tabPage3.Controls.Add(this.dataGridView_payment);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(810, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "   Payment   ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_delivery_exit);
            this.tabPage4.Controls.Add(this.button_delerery_delete);
            this.tabPage4.Controls.Add(this.button_dellivery_insert);
            this.tabPage4.Controls.Add(this.button_delivery_laod);
            this.tabPage4.Controls.Add(this.button_delivery_load);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.textBox_description);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.textBox_delivery_price);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.textBox_delivery_address);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.textBox_delivery_name);
            this.tabPage4.Controls.Add(this.dataGridView_delivery);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(810, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "   Delivery  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataGridView_payment
            // 
            this.dataGridView_payment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payment.Location = new System.Drawing.Point(44, 97);
            this.dataGridView_payment.MultiSelect = false;
            this.dataGridView_payment.Name = "dataGridView_payment";
            this.dataGridView_payment.ReadOnly = true;
            this.dataGridView_payment.RowHeadersWidth = 51;
            this.dataGridView_payment.RowTemplate.Height = 24;
            this.dataGridView_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_payment.Size = new System.Drawing.Size(546, 317);
            this.dataGridView_payment.TabIndex = 0;
            // 
            // dataGridView_delivery
            // 
            this.dataGridView_delivery.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_delivery.Location = new System.Drawing.Point(66, 89);
            this.dataGridView_delivery.MultiSelect = false;
            this.dataGridView_delivery.Name = "dataGridView_delivery";
            this.dataGridView_delivery.ReadOnly = true;
            this.dataGridView_delivery.RowHeadersWidth = 51;
            this.dataGridView_delivery.RowTemplate.Height = 24;
            this.dataGridView_delivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_delivery.Size = new System.Drawing.Size(543, 326);
            this.dataGridView_delivery.TabIndex = 0;
            // 
            // textBox_delivery_name
            // 
            this.textBox_delivery_name.Location = new System.Drawing.Point(66, 54);
            this.textBox_delivery_name.Name = "textBox_delivery_name";
            this.textBox_delivery_name.Size = new System.Drawing.Size(116, 29);
            this.textBox_delivery_name.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "Name";
            // 
            // textBox_delivery_address
            // 
            this.textBox_delivery_address.Location = new System.Drawing.Point(188, 54);
            this.textBox_delivery_address.Name = "textBox_delivery_address";
            this.textBox_delivery_address.Size = new System.Drawing.Size(118, 29);
            this.textBox_delivery_address.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "Address";
            // 
            // textBox_delivery_price
            // 
            this.textBox_delivery_price.Location = new System.Drawing.Point(312, 54);
            this.textBox_delivery_price.Name = "textBox_delivery_price";
            this.textBox_delivery_price.Size = new System.Drawing.Size(114, 29);
            this.textBox_delivery_price.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Price";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(432, 54);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(177, 29);
            this.textBox_description.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(428, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Description";
            // 
            // button_delivery_exit
            // 
            this.button_delivery_exit.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delivery_exit.Location = new System.Drawing.Point(615, 261);
            this.button_delivery_exit.Name = "button_delivery_exit";
            this.button_delivery_exit.Size = new System.Drawing.Size(136, 37);
            this.button_delivery_exit.TabIndex = 5;
            this.button_delivery_exit.Text = "Exit";
            this.button_delivery_exit.UseVisualStyleBackColor = true;
            this.button_delivery_exit.Click += new System.EventHandler(this.button_delivery_exit_Click);
            // 
            // button_delerery_delete
            // 
            this.button_delerery_delete.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delerery_delete.Location = new System.Drawing.Point(615, 218);
            this.button_delerery_delete.Name = "button_delerery_delete";
            this.button_delerery_delete.Size = new System.Drawing.Size(136, 37);
            this.button_delerery_delete.TabIndex = 6;
            this.button_delerery_delete.Text = "Delete";
            this.button_delerery_delete.UseVisualStyleBackColor = true;
            this.button_delerery_delete.Click += new System.EventHandler(this.button_delerery_delete_Click);
            // 
            // button_dellivery_insert
            // 
            this.button_dellivery_insert.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dellivery_insert.Location = new System.Drawing.Point(615, 175);
            this.button_dellivery_insert.Name = "button_dellivery_insert";
            this.button_dellivery_insert.Size = new System.Drawing.Size(136, 37);
            this.button_dellivery_insert.TabIndex = 7;
            this.button_dellivery_insert.Text = "Insert";
            this.button_dellivery_insert.UseVisualStyleBackColor = true;
            this.button_dellivery_insert.Click += new System.EventHandler(this.button_dellivery_insert_Click);
            // 
            // button_delivery_laod
            // 
            this.button_delivery_laod.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delivery_laod.Location = new System.Drawing.Point(615, 89);
            this.button_delivery_laod.Name = "button_delivery_laod";
            this.button_delivery_laod.Size = new System.Drawing.Size(136, 37);
            this.button_delivery_laod.TabIndex = 8;
            this.button_delivery_laod.Text = "Load";
            this.button_delivery_laod.UseVisualStyleBackColor = true;
            this.button_delivery_laod.Click += new System.EventHandler(this.button_delivery_laod_Click);
            // 
            // button_delivery_load
            // 
            this.button_delivery_load.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delivery_load.Location = new System.Drawing.Point(615, 132);
            this.button_delivery_load.Name = "button_delivery_load";
            this.button_delivery_load.Size = new System.Drawing.Size(136, 37);
            this.button_delivery_load.TabIndex = 9;
            this.button_delivery_load.Text = "New";
            this.button_delivery_load.UseVisualStyleBackColor = true;
            this.button_delivery_load.Click += new System.EventHandler(this.button_delivery_load_Click_1);
            // 
            // textBox_payment_name
            // 
            this.textBox_payment_name.Location = new System.Drawing.Point(48, 62);
            this.textBox_payment_name.Name = "textBox_payment_name";
            this.textBox_payment_name.Size = new System.Drawing.Size(175, 29);
            this.textBox_payment_name.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 22);
            this.label16.TabIndex = 2;
            this.label16.Text = "Name";
            // 
            // textBox_payment_description
            // 
            this.textBox_payment_description.Location = new System.Drawing.Point(229, 62);
            this.textBox_payment_description.Name = "textBox_payment_description";
            this.textBox_payment_description.Size = new System.Drawing.Size(211, 29);
            this.textBox_payment_description.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 22);
            this.label17.TabIndex = 2;
            this.label17.Text = "Description";
            // 
            // button_payment_exit
            // 
            this.button_payment_exit.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payment_exit.Location = new System.Drawing.Point(596, 269);
            this.button_payment_exit.Name = "button_payment_exit";
            this.button_payment_exit.Size = new System.Drawing.Size(136, 37);
            this.button_payment_exit.TabIndex = 10;
            this.button_payment_exit.Text = "Exit";
            this.button_payment_exit.UseVisualStyleBackColor = true;
            this.button_payment_exit.Click += new System.EventHandler(this.button_payment_exit_Click);
            // 
            // button_payment_delete
            // 
            this.button_payment_delete.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payment_delete.Location = new System.Drawing.Point(596, 226);
            this.button_payment_delete.Name = "button_payment_delete";
            this.button_payment_delete.Size = new System.Drawing.Size(136, 37);
            this.button_payment_delete.TabIndex = 11;
            this.button_payment_delete.Text = "Delete";
            this.button_payment_delete.UseVisualStyleBackColor = true;
            this.button_payment_delete.Click += new System.EventHandler(this.button_payment_delete_Click);
            // 
            // button_payment_insert
            // 
            this.button_payment_insert.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payment_insert.Location = new System.Drawing.Point(596, 183);
            this.button_payment_insert.Name = "button_payment_insert";
            this.button_payment_insert.Size = new System.Drawing.Size(136, 37);
            this.button_payment_insert.TabIndex = 12;
            this.button_payment_insert.Text = "Insert";
            this.button_payment_insert.UseVisualStyleBackColor = true;
            this.button_payment_insert.Click += new System.EventHandler(this.button_payment_insert_Click);
            // 
            // button_payment_load
            // 
            this.button_payment_load.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payment_load.Location = new System.Drawing.Point(596, 97);
            this.button_payment_load.Name = "button_payment_load";
            this.button_payment_load.Size = new System.Drawing.Size(136, 37);
            this.button_payment_load.TabIndex = 13;
            this.button_payment_load.Text = "Load";
            this.button_payment_load.UseVisualStyleBackColor = true;
            this.button_payment_load.Click += new System.EventHandler(this.button_payment_load_Click);
            // 
            // button_payment_new
            // 
            this.button_payment_new.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_payment_new.Location = new System.Drawing.Point(596, 140);
            this.button_payment_new.Name = "button_payment_new";
            this.button_payment_new.Size = new System.Drawing.Size(136, 37);
            this.button_payment_new.TabIndex = 14;
            this.button_payment_new.Text = "New";
            this.button_payment_new.UseVisualStyleBackColor = true;
            this.button_payment_new.Click += new System.EventHandler(this.button_payment_new_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_delivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_today;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.MaskedTextBox textBox_expire;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_staff_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_staff_delete;
        private System.Windows.Forms.Button button_staff_insert;
        private System.Windows.Forms.Button button_staff_new;
        private System.Windows.Forms.Button button_staff_load;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox_staff_phone;
        private System.Windows.Forms.TextBox textBox_staff_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_picture;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_payment;
        private System.Windows.Forms.DataGridView dataGridView_delivery;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_delivery_price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_delivery_address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_delivery_name;
        private System.Windows.Forms.Button button_delivery_exit;
        private System.Windows.Forms.Button button_delerery_delete;
        private System.Windows.Forms.Button button_dellivery_insert;
        private System.Windows.Forms.Button button_delivery_laod;
        private System.Windows.Forms.Button button_delivery_load;
        private System.Windows.Forms.Button button_payment_exit;
        private System.Windows.Forms.Button button_payment_delete;
        private System.Windows.Forms.Button button_payment_insert;
        private System.Windows.Forms.Button button_payment_load;
        private System.Windows.Forms.Button button_payment_new;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_payment_description;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_payment_name;
    }
}