namespace GUI
{
    partial class frm_buy_now
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
            this.groupBox_product = new System.Windows.Forms.GroupBox();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_product_name = new System.Windows.Forms.Label();
            this.comboBox_adderss = new System.Windows.Forms.ComboBox();
            this.comboBox_delivery = new System.Windows.Forms.ComboBox();
            this.comboBox_payment = new System.Windows.Forms.ComboBox();
            this.comboBox_voucher = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label_total_amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_provisional = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_product.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(214, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy Now";
            // 
            // groupBox_product
            // 
            this.groupBox_product.Controls.Add(this.label_price);
            this.groupBox_product.Controls.Add(this.label_quantity);
            this.groupBox_product.Controls.Add(this.label_product_name);
            this.groupBox_product.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_product.Location = new System.Drawing.Point(17, 69);
            this.groupBox_product.Name = "groupBox_product";
            this.groupBox_product.Size = new System.Drawing.Size(473, 90);
            this.groupBox_product.TabIndex = 1;
            this.groupBox_product.TabStop = false;
            this.groupBox_product.Text = "Product";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(366, 42);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(0, 22);
            this.label_price.TabIndex = 0;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(261, 42);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(20, 22);
            this.label_quantity.TabIndex = 0;
            this.label_quantity.Text = "x";
            // 
            // label_product_name
            // 
            this.label_product_name.AutoSize = true;
            this.label_product_name.Location = new System.Drawing.Point(7, 42);
            this.label_product_name.Name = "label_product_name";
            this.label_product_name.Size = new System.Drawing.Size(0, 22);
            this.label_product_name.TabIndex = 0;
            // 
            // comboBox_adderss
            // 
            this.comboBox_adderss.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_adderss.FormattingEnabled = true;
            this.comboBox_adderss.Items.AddRange(new object[] {
            "Your curent location."});
            this.comboBox_adderss.Location = new System.Drawing.Point(164, 299);
            this.comboBox_adderss.Name = "comboBox_adderss";
            this.comboBox_adderss.Size = new System.Drawing.Size(229, 31);
            this.comboBox_adderss.TabIndex = 13;
            // 
            // comboBox_delivery
            // 
            this.comboBox_delivery.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_delivery.FormattingEnabled = true;
            this.comboBox_delivery.Location = new System.Drawing.Point(164, 260);
            this.comboBox_delivery.Name = "comboBox_delivery";
            this.comboBox_delivery.Size = new System.Drawing.Size(229, 31);
            this.comboBox_delivery.TabIndex = 14;
            // 
            // comboBox_payment
            // 
            this.comboBox_payment.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_payment.FormattingEnabled = true;
            this.comboBox_payment.Location = new System.Drawing.Point(164, 217);
            this.comboBox_payment.Name = "comboBox_payment";
            this.comboBox_payment.Size = new System.Drawing.Size(229, 31);
            this.comboBox_payment.TabIndex = 15;
            // 
            // comboBox_voucher
            // 
            this.comboBox_voucher.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_voucher.FormattingEnabled = true;
            this.comboBox_voucher.Items.AddRange(new object[] {
            "NO voucher ~32"});
            this.comboBox_voucher.Location = new System.Drawing.Point(164, 177);
            this.comboBox_voucher.Name = "comboBox_voucher";
            this.comboBox_voucher.Size = new System.Drawing.Size(229, 31);
            this.comboBox_voucher.TabIndex = 16;
            this.comboBox_voucher.SelectedIndexChanged += new System.EventHandler(this.comboBox_voucher_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(50, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(50, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 22);
            this.label19.TabIndex = 10;
            this.label19.Text = "Delivery";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(50, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 22);
            this.label18.TabIndex = 11;
            this.label18.Text = "Payment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(50, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 22);
            this.label17.TabIndex = 12;
            this.label17.Text = "Voucher";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(123, 439);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(168, 27);
            this.label23.TabIndex = 18;
            this.label23.Text = "Total Amount";
            // 
            // label_total_amount
            // 
            this.label_total_amount.AutoSize = true;
            this.label_total_amount.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_amount.ForeColor = System.Drawing.Color.Red;
            this.label_total_amount.Location = new System.Drawing.Point(309, 439);
            this.label_total_amount.Name = "label_total_amount";
            this.label_total_amount.Size = new System.Drawing.Size(168, 27);
            this.label_total_amount.TabIndex = 19;
            this.label_total_amount.Text = "78000000 VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(167, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Discount";
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_discount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_discount.Location = new System.Drawing.Point(339, 394);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(180, 22);
            this.label_discount.TabIndex = 21;
            this.label_discount.Text = "0 VND            ";
            this.label_discount.TextChanged += new System.EventHandler(this.label_discount_TextChanged);
            // 
            // label_provisional
            // 
            this.label_provisional.AutoSize = true;
            this.label_provisional.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_provisional.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_provisional.Location = new System.Drawing.Point(339, 358);
            this.label_provisional.Name = "label_provisional";
            this.label_provisional.Size = new System.Drawing.Size(180, 22);
            this.label_provisional.TabIndex = 22;
            this.label_provisional.Text = "0 VND            ";
            this.label_provisional.TextChanged += new System.EventHandler(this.label_provisional_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(167, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Provisional";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(300, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buy Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_buy_now
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 538);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label_total_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.label_provisional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_adderss);
            this.Controls.Add(this.comboBox_delivery);
            this.Controls.Add(this.comboBox_payment);
            this.Controls.Add(this.comboBox_voucher);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox_product);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_buy_now";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy now ";
            this.Load += new System.EventHandler(this.frm_buy_now_Load);
            this.groupBox_product.ResumeLayout(false);
            this.groupBox_product.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_product;
        private System.Windows.Forms.Label label_product_name;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.ComboBox comboBox_adderss;
        private System.Windows.Forms.ComboBox comboBox_delivery;
        private System.Windows.Forms.ComboBox comboBox_payment;
        private System.Windows.Forms.ComboBox comboBox_voucher;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_total_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label_provisional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}