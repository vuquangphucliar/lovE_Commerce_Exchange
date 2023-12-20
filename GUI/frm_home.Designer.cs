using BUS;
using System.Drawing;

namespace GUI
{
    partial class frm_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.btn_mall = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            this.btn_shop = new System.Windows.Forms.Button();
            this.btn_voucher = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_friend = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_message = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_change_reset_password = new System.Windows.Forms.Button();
            this.button_information = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_profile_label = new System.Windows.Forms.Label();
            this.listBox_category = new System.Windows.Forms.ListBox();
            this.flp_product_show = new System.Windows.Forms.FlowLayoutPanel();
            this.category_name = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_staff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flp_product_show.SuspendLayout();
            this.category_name.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mall
            // 
            this.btn_mall.Enabled = false;
            this.btn_mall.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mall.Image = ((System.Drawing.Image)(resources.GetObject("btn_mall.Image")));
            this.btn_mall.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_mall.Location = new System.Drawing.Point(370, 582);
            this.btn_mall.Name = "btn_mall";
            this.btn_mall.Size = new System.Drawing.Size(125, 51);
            this.btn_mall.TabIndex = 26;
            this.btn_mall.Text = "Mall";
            this.btn_mall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_mall.UseVisualStyleBackColor = true;
            // 
            // btn_cart
            // 
            this.btn_cart.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.Image = ((System.Drawing.Image)(resources.GetObject("btn_cart.Image")));
            this.btn_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.Location = new System.Drawing.Point(1025, 582);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(125, 51);
            this.btn_cart.TabIndex = 23;
            this.btn_cart.Text = "Cart";
            this.btn_cart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cart.UseVisualStyleBackColor = true;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_shop
            // 
            this.btn_shop.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shop.Image = ((System.Drawing.Image)(resources.GetObject("btn_shop.Image")));
            this.btn_shop.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_shop.Location = new System.Drawing.Point(894, 582);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(125, 51);
            this.btn_shop.TabIndex = 24;
            this.btn_shop.Text = " Shop";
            this.btn_shop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_shop.UseVisualStyleBackColor = true;
            this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
            // 
            // btn_voucher
            // 
            this.btn_voucher.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voucher.Image = ((System.Drawing.Image)(resources.GetObject("btn_voucher.Image")));
            this.btn_voucher.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_voucher.Location = new System.Drawing.Point(763, 582);
            this.btn_voucher.Name = "btn_voucher";
            this.btn_voucher.Size = new System.Drawing.Size(125, 51);
            this.btn_voucher.TabIndex = 25;
            this.btn_voucher.Text = " Voucher";
            this.btn_voucher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voucher.UseVisualStyleBackColor = true;
            this.btn_voucher.Click += new System.EventHandler(this.btn_voucher_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistic.Image = ((System.Drawing.Image)(resources.GetObject("btn_statistic.Image")));
            this.btn_statistic.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_statistic.Location = new System.Drawing.Point(501, 582);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(125, 51);
            this.btn_statistic.TabIndex = 27;
            this.btn_statistic.Text = " Statistic";
            this.btn_statistic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click_1);
            // 
            // btn_friend
            // 
            this.btn_friend.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_friend.Image = ((System.Drawing.Image)(resources.GetObject("btn_friend.Image")));
            this.btn_friend.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_friend.Location = new System.Drawing.Point(632, 582);
            this.btn_friend.Name = "btn_friend";
            this.btn_friend.Size = new System.Drawing.Size(125, 51);
            this.btn_friend.TabIndex = 28;
            this.btn_friend.Text = "Friend";
            this.btn_friend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_friend.UseVisualStyleBackColor = true;
            this.btn_friend.Click += new System.EventHandler(this.btn_friend_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_profile.Location = new System.Drawing.Point(0, 0);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(66, 66);
            this.btn_profile.TabIndex = 9;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(681, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 45);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_message
            // 
            this.btn_message.Image = ((System.Drawing.Image)(resources.GetObject("btn_message.Image")));
            this.btn_message.Location = new System.Drawing.Point(920, 13);
            this.btn_message.Name = "btn_message";
            this.btn_message.Size = new System.Drawing.Size(50, 50);
            this.btn_message.TabIndex = 8;
            this.btn_message.UseVisualStyleBackColor = true;
            this.btn_message.Click += new System.EventHandler(this.btn_message_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(23, 573);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(118, 49);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "   Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox_search.Location = new System.Drawing.Point(432, 26);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(243, 31);
            this.textBox_search.TabIndex = 6;
            this.textBox_search.Text = "All products";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button_change_reset_password);
            this.panel1.Controls.Add(this.button_information);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.btn_filter);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_message);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_setting);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.btn_profile_label);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 66);
            this.panel1.TabIndex = 22;
            // 
            // button_change_reset_password
            // 
            this.button_change_reset_password.Image = ((System.Drawing.Image)(resources.GetObject("button_change_reset_password.Image")));
            this.button_change_reset_password.Location = new System.Drawing.Point(864, 13);
            this.button_change_reset_password.Name = "button_change_reset_password";
            this.button_change_reset_password.Size = new System.Drawing.Size(50, 50);
            this.button_change_reset_password.TabIndex = 12;
            this.button_change_reset_password.UseVisualStyleBackColor = true;
            this.button_change_reset_password.Click += new System.EventHandler(this.button_change_reset_password_Click);
            // 
            // button_information
            // 
            this.button_information.Image = ((System.Drawing.Image)(resources.GetObject("button_information.Image")));
            this.button_information.Location = new System.Drawing.Point(976, 13);
            this.button_information.Name = "button_information";
            this.button_information.Size = new System.Drawing.Size(50, 50);
            this.button_information.TabIndex = 11;
            this.button_information.UseVisualStyleBackColor = true;
            this.button_information.Click += new System.EventHandler(this.button_information_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_filter.Enabled = false;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.Location = new System.Drawing.Point(732, 16);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(45, 45);
            this.btn_filter.TabIndex = 8;
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(1032, 13);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(50, 50);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_setting.Location = new System.Drawing.Point(1088, 13);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(50, 50);
            this.btn_setting.TabIndex = 8;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_profile_label
            // 
            this.btn_profile_label.AutoSize = true;
            this.btn_profile_label.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile_label.ForeColor = System.Drawing.Color.Red;
            this.btn_profile_label.Location = new System.Drawing.Point(72, 21);
            this.btn_profile_label.Name = "btn_profile_label";
            this.btn_profile_label.Size = new System.Drawing.Size(77, 27);
            this.btn_profile_label.TabIndex = 5;
            this.btn_profile_label.Text = "admin";
            // 
            // listBox_category
            // 
            this.listBox_category.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_category.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_category.FormattingEnabled = true;
            this.listBox_category.ItemHeight = 23;
            this.listBox_category.Items.AddRange(new object[] {
            "All products",
            "Babies",
            "Beauty",
            "Books Store",
            "Cars",
            "Clothing",
            "Electronics",
            "Fashion",
            "Footwear",
            "Furniture",
            "Home - Life",
            "Jewelry",
            "Laptops",
            "MotorCycles",
            "Shoes",
            "Sports",
            "Toys and Games",
            "Watches"});
            this.listBox_category.Location = new System.Drawing.Point(12, 78);
            this.listBox_category.Margin = new System.Windows.Forms.Padding(10);
            this.listBox_category.Name = "listBox_category";
            this.listBox_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_category.Size = new System.Drawing.Size(155, 506);
            this.listBox_category.Sorted = true;
            this.listBox_category.TabIndex = 21;
            this.listBox_category.SelectedValueChanged += new System.EventHandler(this.listBox_SelectedValueChanged);
            // 
            // flp_product_show
            // 
            this.flp_product_show.AutoScroll = true;
            this.flp_product_show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flp_product_show.Controls.Add(this.category_name);
            this.flp_product_show.ForeColor = System.Drawing.SystemColors.Highlight;
            this.flp_product_show.Location = new System.Drawing.Point(173, 78);
            this.flp_product_show.Margin = new System.Windows.Forms.Padding(10);
            this.flp_product_show.Name = "flp_product_show";
            this.flp_product_show.Size = new System.Drawing.Size(997, 491);
            this.flp_product_show.TabIndex = 20;
            // 
            // category_name
            // 
            this.category_name.Controls.Add(this.label1);
            this.category_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.category_name.Location = new System.Drawing.Point(3, 3);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(951, 46);
            this.category_name.TabIndex = 0;
            this.category_name.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "All products";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 632);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1182, 26);
            this.statusStrip2.TabIndex = 30;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(225, 20);
            this.toolStripStatusLabel1.Text = "lovE Commerce Exchange v 0.0.1";
            // 
            // button_staff
            // 
            this.button_staff.Enabled = false;
            this.button_staff.Font = new System.Drawing.Font("Consolas", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_staff.Image = ((System.Drawing.Image)(resources.GetObject("button_staff.Image")));
            this.button_staff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_staff.Location = new System.Drawing.Point(239, 582);
            this.button_staff.Name = "button_staff";
            this.button_staff.Size = new System.Drawing.Size(125, 51);
            this.button_staff.TabIndex = 26;
            this.button_staff.Text = "Staff";
            this.button_staff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_staff.UseVisualStyleBackColor = true;
            // 
            // frm_home
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.button_staff);
            this.Controls.Add(this.btn_mall);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.btn_shop);
            this.Controls.Add(this.btn_voucher);
            this.Controls.Add(this.btn_statistic);
            this.Controls.Add(this.btn_friend);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_category);
            this.Controls.Add(this.flp_product_show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_home_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flp_product_show.ResumeLayout(false);
            this.category_name.ResumeLayout(false);
            this.category_name.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_mall;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Button btn_voucher;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_friend;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_message;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Label btn_profile_label;
        private System.Windows.Forms.ListBox listBox_category;
        private System.Windows.Forms.FlowLayoutPanel flp_product_show;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.GroupBox category_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_information;
        private System.Windows.Forms.Button button_change_reset_password;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button_staff;
    }
}