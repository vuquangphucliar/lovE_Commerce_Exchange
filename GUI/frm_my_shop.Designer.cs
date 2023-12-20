using System.Drawing;

namespace GUI
{
    partial class frm_my_shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_my_shop));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_all_products = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.flowLayoutPanel_show_all_product = new System.Windows.Forms.FlowLayoutPanel();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_show_orders = new System.Windows.Forms.FlowLayoutPanel();
            this.label_shop_name = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label_number_checked = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_all_products);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.button_add);
            this.tabPage2.Controls.Add(this.flowLayoutPanel_show_all_product);
            this.tabPage2.Controls.Add(this.button_delete);
            this.tabPage2.Controls.Add(this.button_edit);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "   My product    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_all_products
            // 
            this.checkBox_all_products.AutoSize = true;
            this.checkBox_all_products.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_all_products.Location = new System.Drawing.Point(12, 13);
            this.checkBox_all_products.Name = "checkBox_all_products";
            this.checkBox_all_products.Size = new System.Drawing.Size(62, 26);
            this.checkBox_all_products.TabIndex = 1;
            this.checkBox_all_products.Text = "All";
            this.checkBox_all_products.UseVisualStyleBackColor = true;
            this.checkBox_all_products.CheckedChanged += new System.EventHandler(this.checkBox_all_products_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 35);
            this.panel2.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label21.Location = new System.Drawing.Point(385, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Total Quantity";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label20.Location = new System.Drawing.Point(707, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "Status";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label22.Location = new System.Drawing.Point(587, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 23);
            this.label22.TabIndex = 0;
            this.label22.Text = "Price";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label32.Location = new System.Drawing.Point(16, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 23);
            this.label32.TabIndex = 0;
            this.label32.Text = "Product";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Lime;
            this.button_add.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.Location = new System.Drawing.Point(526, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 36);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // flowLayoutPanel_show_all_product
            // 
            this.flowLayoutPanel_show_all_product.AutoScroll = true;
            this.flowLayoutPanel_show_all_product.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_show_all_product.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel_show_all_product.Name = "flowLayoutPanel_show_all_product";
            this.flowLayoutPanel_show_all_product.Size = new System.Drawing.Size(868, 390);
            this.flowLayoutPanel_show_all_product.TabIndex = 4;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.Location = new System.Drawing.Point(738, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 36);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Cyan;
            this.button_edit.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_edit.Location = new System.Drawing.Point(632, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 36);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel_show_orders);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    Order confirm   ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 35);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(739, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(499, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(622, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(374, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product";
            // 
            // flowLayoutPanel_show_orders
            // 
            this.flowLayoutPanel_show_orders.AutoScroll = true;
            this.flowLayoutPanel_show_orders.Location = new System.Drawing.Point(6, 44);
            this.flowLayoutPanel_show_orders.Name = "flowLayoutPanel_show_orders";
            this.flowLayoutPanel_show_orders.Size = new System.Drawing.Size(860, 426);
            this.flowLayoutPanel_show_orders.TabIndex = 0;
            // 
            // label_shop_name
            // 
            this.label_shop_name.AutoSize = true;
            this.label_shop_name.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shop_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_shop_name.Location = new System.Drawing.Point(420, 9);
            this.label_shop_name.Name = "label_shop_name";
            this.label_shop_name.Size = new System.Drawing.Size(129, 27);
            this.label_shop_name.TabIndex = 1;
            this.label_shop_name.Text = "Shop Name";
            // 
            // button21
            // 
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.Location = new System.Drawing.Point(810, 9);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 3;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(754, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label_number_checked
            // 
            this.label_number_checked.AutoSize = true;
            this.label_number_checked.Enabled = false;
            this.label_number_checked.Location = new System.Drawing.Point(694, 20);
            this.label_number_checked.Name = "label_number_checked";
            this.label_number_checked.Size = new System.Drawing.Size(0, 16);
            this.label_number_checked.TabIndex = 4;
            this.label_number_checked.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shop Name: ";
            // 
            // frm_my_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label_shop_name);
            this.Controls.Add(this.label_number_checked);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_my_shop";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Shop";
            this.Load += new System.EventHandler(this.frm_my_shop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_shop_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_show_orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_show_all_product;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.CheckBox checkBox_all_products;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label_number_checked;
        private System.Windows.Forms.Label label1;
    }
}