using System.Drawing;

namespace GUI
{
    partial class frm_shopping_cart
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
            this.label_shopping_cart = new System.Windows.Forms.Label();
            this.button_puchase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_into_money = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_unit_prices = new System.Windows.Forms.Label();
            this.checkBox_choose_all = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_provision = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox_voucher = new System.Windows.Forms.ComboBox();
            this.comboBox_payment = new System.Windows.Forms.ComboBox();
            this.comboBox_delivery = new System.Windows.Forms.ComboBox();
            this.label_total_amount = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_address = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_question = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_shopping_cart
            // 
            this.label_shopping_cart.AutoSize = true;
            this.label_shopping_cart.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shopping_cart.ForeColor = System.Drawing.Color.IndianRed;
            this.label_shopping_cart.Location = new System.Drawing.Point(8, 9);
            this.label_shopping_cart.Name = "label_shopping_cart";
            this.label_shopping_cart.Size = new System.Drawing.Size(220, 27);
            this.label_shopping_cart.TabIndex = 2;
            this.label_shopping_cart.Text = "My Shopping Cart";
            // 
            // button_puchase
            // 
            this.button_puchase.BackColor = System.Drawing.Color.Red;
            this.button_puchase.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_puchase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_puchase.Location = new System.Drawing.Point(556, 502);
            this.button_puchase.Name = "button_puchase";
            this.button_puchase.Size = new System.Drawing.Size(177, 39);
            this.button_puchase.TabIndex = 4;
            this.button_puchase.Text = "Purchase ( 3 )";
            this.button_puchase.UseVisualStyleBackColor = false;
            this.button_puchase.Click += new System.EventHandler(this.button_puchase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_into_money);
            this.panel1.Controls.Add(this.label_quantity);
            this.panel1.Controls.Add(this.label_unit_prices);
            this.panel1.Controls.Add(this.checkBox_choose_all);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 41);
            this.panel1.TabIndex = 6;
            // 
            // label_into_money
            // 
            this.label_into_money.AutoSize = true;
            this.label_into_money.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_into_money.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_into_money.Location = new System.Drawing.Point(660, 10);
            this.label_into_money.Name = "label_into_money";
            this.label_into_money.Size = new System.Drawing.Size(99, 20);
            this.label_into_money.TabIndex = 1;
            this.label_into_money.Text = "Into money";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_quantity.Location = new System.Drawing.Point(533, 10);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(81, 20);
            this.label_quantity.TabIndex = 1;
            this.label_quantity.Text = "Quantity";
            // 
            // label_unit_prices
            // 
            this.label_unit_prices.AutoSize = true;
            this.label_unit_prices.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unit_prices.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_unit_prices.Location = new System.Drawing.Point(373, 10);
            this.label_unit_prices.Name = "label_unit_prices";
            this.label_unit_prices.Size = new System.Drawing.Size(99, 20);
            this.label_unit_prices.TabIndex = 1;
            this.label_unit_prices.Text = "Unit price";
            // 
            // checkBox_choose_all
            // 
            this.checkBox_choose_all.AutoSize = true;
            this.checkBox_choose_all.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_choose_all.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_choose_all.Location = new System.Drawing.Point(13, 10);
            this.checkBox_choose_all.Name = "checkBox_choose_all";
            this.checkBox_choose_all.Size = new System.Drawing.Size(58, 24);
            this.checkBox_choose_all.TabIndex = 0;
            this.checkBox_choose_all.Text = "All";
            this.checkBox_choose_all.UseVisualStyleBackColor = true;
            this.checkBox_choose_all.CheckedChanged += new System.EventHandler(this.checkBox_choose_all_CheckedChanged);
            // 
            // flowLayoutPanel_products
            // 
            this.flowLayoutPanel_products.AutoScroll = true;
            this.flowLayoutPanel_products.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel_products.Location = new System.Drawing.Point(12, 98);
            this.flowLayoutPanel_products.Name = "flowLayoutPanel_products";
            this.flowLayoutPanel_products.Size = new System.Drawing.Size(858, 277);
            this.flowLayoutPanel_products.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(506, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Provisional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(506, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount";
            // 
            // label_provision
            // 
            this.label_provision.AutoSize = true;
            this.label_provision.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_provision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_provision.Location = new System.Drawing.Point(672, 391);
            this.label_provision.Name = "label_provision";
            this.label_provision.Size = new System.Drawing.Size(18, 20);
            this.label_provision.TabIndex = 7;
            this.label_provision.Text = "0";
            this.label_provision.TextChanged += new System.EventHandler(this.label_provision_TextChanged);
            this.label_provision.Click += new System.EventHandler(this.label_provision_Click);
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_discount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_discount.Location = new System.Drawing.Point(672, 423);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(18, 20);
            this.label_discount.TabIndex = 7;
            this.label_discount.Text = "0";
            this.label_discount.Click += new System.EventHandler(this.label_discount_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(91, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 22);
            this.label17.TabIndex = 7;
            this.label17.Text = "Voucher";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(91, 439);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 22);
            this.label18.TabIndex = 7;
            this.label18.Text = "Payment";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(91, 475);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 22);
            this.label19.TabIndex = 7;
            this.label19.Text = "Delivery";
            // 
            // comboBox_voucher
            // 
            this.comboBox_voucher.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_voucher.FormattingEnabled = true;
            this.comboBox_voucher.Items.AddRange(new object[] {
            "No voucher ~32"});
            this.comboBox_voucher.Location = new System.Drawing.Point(201, 400);
            this.comboBox_voucher.Name = "comboBox_voucher";
            this.comboBox_voucher.Size = new System.Drawing.Size(204, 30);
            this.comboBox_voucher.TabIndex = 8;
            this.comboBox_voucher.SelectedIndexChanged += new System.EventHandler(this.comboBox_voucher_SelectedIndexChanged);
            // 
            // comboBox_payment
            // 
            this.comboBox_payment.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_payment.FormattingEnabled = true;
            this.comboBox_payment.Location = new System.Drawing.Point(201, 436);
            this.comboBox_payment.Name = "comboBox_payment";
            this.comboBox_payment.Size = new System.Drawing.Size(204, 30);
            this.comboBox_payment.TabIndex = 8;
            // 
            // comboBox_delivery
            // 
            this.comboBox_delivery.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_delivery.FormattingEnabled = true;
            this.comboBox_delivery.Location = new System.Drawing.Point(201, 472);
            this.comboBox_delivery.Name = "comboBox_delivery";
            this.comboBox_delivery.Size = new System.Drawing.Size(204, 30);
            this.comboBox_delivery.TabIndex = 8;
            // 
            // label_total_amount
            // 
            this.label_total_amount.AutoSize = true;
            this.label_total_amount.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_amount.ForeColor = System.Drawing.Color.Red;
            this.label_total_amount.Location = new System.Drawing.Point(655, 461);
            this.label_total_amount.Name = "label_total_amount";
            this.label_total_amount.Size = new System.Drawing.Size(25, 27);
            this.label_total_amount.TabIndex = 7;
            this.label_total_amount.Text = "0";
            this.label_total_amount.TextChanged += new System.EventHandler(this.label_total_amount_TextChanged);
            this.label_total_amount.Click += new System.EventHandler(this.label_total_amount_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(506, 468);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 22);
            this.label23.TabIndex = 7;
            this.label23.Text = "Total Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(91, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 7;
            this.label15.Text = "Address";
            // 
            // comboBox_address
            // 
            this.comboBox_address.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_address.FormattingEnabled = true;
            this.comboBox_address.Items.AddRange(new object[] {
            "Your current address"});
            this.comboBox_address.Location = new System.Drawing.Point(201, 507);
            this.comboBox_address.Name = "comboBox_address";
            this.comboBox_address.Size = new System.Drawing.Size(204, 30);
            this.comboBox_address.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(793, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "VND";
            // 
            // button_question
            // 
            this.button_question.Image = global::GUI.Properties.Resources.Apps_preferences_desktop_notification_icon;
            this.button_question.Location = new System.Drawing.Point(820, 0);
            this.button_question.Name = "button_question";
            this.button_question.Size = new System.Drawing.Size(50, 50);
            this.button_question.TabIndex = 3;
            this.button_question.UseVisualStyleBackColor = true;
            // 
            // frm_shopping_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_question);
            this.Controls.Add(this.comboBox_address);
            this.Controls.Add(this.comboBox_delivery);
            this.Controls.Add(this.comboBox_payment);
            this.Controls.Add(this.comboBox_voucher);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label_total_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.label_provision);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel_products);
            this.Controls.Add(this.button_puchase);
            this.Controls.Add(this.label_shopping_cart);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frm_shopping_cart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.frm_shopping_cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_shopping_cart;
        private System.Windows.Forms.Button button_puchase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_into_money;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_unit_prices;
        private System.Windows.Forms.CheckBox checkBox_choose_all;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_products;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_provision;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox_voucher;
        private System.Windows.Forms.ComboBox comboBox_payment;
        private System.Windows.Forms.ComboBox comboBox_delivery;
        private System.Windows.Forms.Label label_total_amount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_address;
        private System.Windows.Forms.Button button_question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}