using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DLL;

namespace GUI
{
    public partial class frm_home : Form
    {
        private  account account;
        private  product[] products;
        private  product[] current_products;
        private customer customer;
        private bool isStaff;


        public frm_home(account current_account)
        {
            account = current_account;
            products = BUS_home.ReturnAllProduct();
            InitializeComponent();
            LoadProducts(products);
            btn_profile_label.Text = current_account.username;
            this.customer = BUS_customer.ReturnOneCustomer(account.username);
            
            btn_profile.Image = new Bitmap((customer.image == "") ? Resources.guest_ : customer.image);
            //ToolStripOverflowButton  
            isStaff = (current_account.role == "True") ? false : true;
            button_staff.Enabled = isStaff;
            button_staff.Visible = isStaff;
            

          
        }

        private void LoadProducts(product[] products)
        {
            flp_product_show.Controls.Clear();
            Panel pn_category_name = new Panel();
            flp_product_show.Controls.Add(pn_category_name);
            pn_category_name.Location = new Point(2, 2);
            pn_category_name.Size = new Size(713, 31);

            Label lb_category_name = new Label();
            pn_category_name.Controls.Add(lb_category_name);
            lb_category_name.Text = "Lovecrush Shop";
            lb_category_name.Size = new Size(300, 22);
            lb_category_name.Location = new Point(275, 8);
            lb_category_name.Font = new Font("Consolas", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            foreach (product pro in products)
            {
                if(pro.product_status == "False")
                {
                    continue;
                }
                Add_product(pro.name, pro.main_image, pro.product_id);
            }
        }

        void Add_product(string productName, string link ,string productid)
        {

            GroupBox groupBox_product = new GroupBox();
            PictureBox picture_product = new PictureBox();
            Button btn_info = new Button();
            Button btn_by_now = new Button();
            Button btn_cart = new Button();
           
            groupBox_product.Text = productName;
            groupBox_product.Name = productid;
            groupBox_product.Size = new Size(139, 203);
            groupBox_product.Controls.Add(picture_product);
            groupBox_product.Controls.Add(btn_info);
            groupBox_product.Controls.Add(btn_cart);
            groupBox_product.Controls.Add(btn_by_now);

            picture_product.Size = new Size(134, 145);
            picture_product.Location = new Point(2, 15);
            picture_product.SizeMode = PictureBoxSizeMode.Zoom;
            if (link == "unknown")
            {
                picture_product.Image = new Bitmap(Resources.image);

            }
            else
            {
                picture_product.Image = new Bitmap(@link);

            }

            btn_info.Size = new Size(43, 41);
            btn_info.Location = new Point(2, 159);
            btn_info.Name = productid;
            btn_info.BackColor = Color.Cyan;
            //btn_info.ForeColor = Color.White;

            btn_cart.Size = new Size(44, 41);
            btn_cart.Location = new Point(45, 159);
            btn_cart.Name = productid;
            btn_cart.ForeColor = Color.White;
            btn_cart.BackColor = Color.HotPink;

            btn_by_now.Size = new   Size(47, 41);
            btn_by_now.Location = new Point(89, 159);
            btn_by_now.Name = productid;
            btn_by_now.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_by_now.BackColor = System.Drawing.Color.Tomato;
            btn_by_now.ForeColor = System.Drawing.SystemColors.ControlLightLight;


            btn_info.Text = "Info";
            btn_by_now.Text = "Buy Now";
            btn_cart.Text = "Cart";

            flp_product_show.Controls.Add(groupBox_product);
            btn_info.Click += Btn_info_Click;
            btn_by_now.Click += Btn_by_now_Click;
            btn_cart.Click += Btn_cart_Click;
        }

        void Show_product_info(product pro)
        {

            string[] linkes = pro.main_image.Split('#');
            int i = 1;
           
            Panel pn_category_name = new Panel();
            Panel pn_product_info = new Panel();
            flp_product_show.Controls.Add(pn_category_name);
            pn_category_name.Location = new Point(2,2);
            pn_category_name.Size = new Size(713,31);

            Label lb_category_name = new Label();
            pn_category_name.Controls.Add(lb_category_name);
            lb_category_name.Text = pro.product_type;
            lb_category_name.Size = new Size(300,22);
            lb_category_name.Location = new Point(306,9);
            lb_category_name.Font = new  Font("Consolas", 12.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label1.Size = new System.Drawing.Size(103, 27);


            flp_product_show.Controls.Add(pn_product_info);
            pn_product_info.Size = new Size(713,642);
            pn_product_info.Location = new Point(2,37);

            GroupBox groupBox_picture_show = new GroupBox();
            pn_product_info.Controls.Add(groupBox_picture_show);
            groupBox_picture_show.Location = new Point(3,2);
            groupBox_picture_show.Size = new Size(194,600);
            groupBox_picture_show.Text = "Images";

            PictureBox pic_main = new PictureBox();
            PictureBox pic_1 = new PictureBox();
            PictureBox pic_2 = new PictureBox();
            PictureBox pic_3 = new PictureBox();
            PictureBox pic_4 = new PictureBox();

            groupBox_picture_show.Controls.Add(pic_main);
            groupBox_picture_show.Controls.Add(pic_1);
            groupBox_picture_show.Controls.Add(pic_2);
            groupBox_picture_show.Controls.Add(pic_3);
            groupBox_picture_show.Controls.Add(pic_4);

            pic_main.Location = new Point(7,20);
            pic_main.Size = new Size(180,190);
            pic_main.BorderStyle = BorderStyle.FixedSingle;
            pic_main.SizeMode = PictureBoxSizeMode.Zoom;
            pic_main.Name = "pic_main";
            pic_main.Image = new Bitmap(@linkes[i]);


            pic_1.Location = new Point(12,219);
            pic_1.Size = new Size(40,42);
            //pic_1.Name = "pic_1";
            pic_1.Image = new Bitmap(@linkes[i]);
            pic_1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_1.BorderStyle = BorderStyle.FixedSingle;
            pic_1.Click += Pic_1_Click;
            pic_1.SizeMode = PictureBoxSizeMode.Zoom;

            pic_2.Location = new Point(56,219);
            //pic_1.Name = "pic_2";

            pic_2.Image = new Bitmap((++i <= linkes.Length - 1)? @linkes[i] : Resources.image);
            pic_2.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_2.Size = new Size(40,42);
            pic_2.BorderStyle = BorderStyle.FixedSingle;
            pic_2.Click += Pic_1_Click;
            pic_2.SizeMode = PictureBoxSizeMode.Zoom;

            pic_3.Location = new Point(100,219);
            pic_3.Size = new Size(40,42);
            pic_3.Image = new Bitmap((++i <= linkes.Length - 1) ? @linkes[i] : Resources.image);
            pic_3.BorderStyle = BorderStyle.FixedSingle;
            pic_3.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_3.Click += Pic_1_Click;
            pic_3.SizeMode = PictureBoxSizeMode.Zoom;

            pic_4.Location = new Point(144,219);
            pic_4.Image = new Bitmap((++i <= linkes.Length - 1) ? @linkes[i] : Resources.image);
            pic_4.Size = new Size(40, 42);
            pic_4.BorderStyle = BorderStyle.FixedSingle;
            pic_4.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_4.Click += Pic_1_Click;
            pic_4.SizeMode = PictureBoxSizeMode.Zoom;


            shop shop = BUS_shop.ReturnOneShop(pro.shop_id);
            Label lb_outstanding = new Label();
            groupBox_picture_show.Controls.Add(lb_outstanding);
            lb_outstanding.Size = new Size(168,300);
            lb_outstanding.Location = new Point(4,295);
            lb_outstanding.Font = new System.Drawing.Font("Consolas", 11.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic ))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_outstanding.ForeColor = System.Drawing.SystemColors.ControlText;
            lb_outstanding.Text = $" <Product shop info>\n\n" + $"• Shop : {shop.name}\n" + $"• Address : {shop.address}\n" + $"• Contact : {shop.phone}\n" + $"• Description : {shop.description}\n";


            GroupBox groupBox_product_name = new GroupBox();
            pn_product_info.Controls.Add(groupBox_product_name);             
            groupBox_product_name.Location = new Point(201,2);
            groupBox_product_name.Size = new Size(333,184);
            groupBox_product_name.Text = "Product info";

            Label lb_product_name = new Label();
            groupBox_product_name.Controls.Add(lb_product_name);
            //lb_product_name.Size = new Size(300,44);
            lb_product_name.Location = new Point(5,18);
            lb_product_name.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_product_name.Text = pro.name;
            lb_product_name.Size =  new System.Drawing.Size(300, 54);
            lb_product_name.ForeColor = System.Drawing.Color.Black;
            //lb_product_name.BorderStyle = BorderStyle.FixedSingle;


            Label lb_product_price = new Label();
            groupBox_product_name.Controls.Add(lb_product_price);
            lb_product_price.Location = new Point(5,75);
            lb_product_price.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_product_price.ForeColor = System.Drawing.SystemColors.Desktop;
            lb_product_price.Size = new System.Drawing.Size(170, 27);
            lb_product_price.Text = BUS_home.ConvertPrice(pro.price);
            lb_product_price.Name = "lb_product_price";

            GroupBox groupBox_temp = new GroupBox();
            pn_product_info.Controls.Add(groupBox_temp);
            groupBox_temp.Location = new Point(538,2);
            groupBox_temp.Size = new Size(172,261);
            groupBox_temp.Name = pro.product_id;

            Label lbl_quantity = new Label();
            groupBox_temp .Controls.Add(lbl_quantity);
            lbl_quantity.Size = new Size();
            lbl_quantity.Text = "Quantity";
            lbl_quantity.Location = new Point(16,35);
            lbl_quantity.Size = new System.Drawing.Size(81, 20);
            lbl_quantity.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_quantity.ForeColor = System.Drawing.SystemColors.ControlText;

            Label lbl_provision = new Label();
            groupBox_temp.Controls.Add(lbl_provision);
            lbl_provision.Size = new Size(96,17);
            lbl_provision.Location = new Point(14,105);
            lbl_provision.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_provision.ForeColor = System.Drawing.SystemColors.ControlText;
            //lbl_provision.Size = new System.Drawing.Size(108, 20);
            lbl_provision.Text = "Provisional";

            Label lbl_provision_price = new Label();
            groupBox_temp.Controls.Add(lbl_provision_price);
            lbl_provision_price.Size = new Size(150,22);
            lbl_provision_price.Location = new Point(16,128);
            lbl_provision_price.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_provision_price.ForeColor = System.Drawing.Color.Red;
            lbl_provision_price.Text = pro.price + " Vnd";
            lbl_provision_price.Name = "lbl_provision_price";



            Button btn_quantity = new Button();
            groupBox_temp.Controls.Add(btn_quantity );
            btn_quantity.Location = new Point(44,54);
            btn_quantity.Size= new Size(44,28);
            btn_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_quantity.Text = "1";
            btn_quantity.Name = "btn_quantity";
            btn_quantity.ForeColor = System.Drawing.SystemColors.Desktop;

            Button btn_sub = new Button();
            groupBox_temp.Controls .Add(btn_sub);
            btn_sub.Location = new Point(13,54);
            btn_sub.Size = new Size(26,28);
            btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_sub.ForeColor = System.Drawing.SystemColors.Desktop;
            btn_sub.Text = "-";
            btn_sub.Name = pro.quantity;
            btn_sub.Click += btn_sub_CLick;
            btn_sub.Click += provisional_calculator;


            Button btn_plus = new Button();
            groupBox_temp.Controls.Add(btn_plus);
            btn_plus.Location = new Point(92,54);
            btn_plus.Size = new Size(26,28);
            btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_plus.ForeColor = System.Drawing.SystemColors.Desktop;
            btn_plus.Text = "+";
            btn_plus.Name = pro.quantity;
            btn_plus.Click += new EventHandler( btn_plus_CLick);
            btn_plus.Click += provisional_calculator;

            

            Button btn_buy_now = new Button();
            groupBox_temp.Controls.Add(btn_buy_now);
            btn_buy_now.Location = new Point(19,170);
            btn_buy_now.Size = new Size(137,28);
            btn_buy_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_buy_now.BackColor = System.Drawing.Color.Red;
            btn_buy_now.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btn_buy_now.Text = "Buy now";
            btn_buy_now.Click += Btn_buy_now_Click;
            btn_buy_now.UseVisualStyleBackColor = false;

            Button btn_add_to_cart = new Button();
            groupBox_temp.Controls.Add(btn_add_to_cart);
            btn_add_to_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_add_to_cart.Text = "Add to Cart";
            btn_add_to_cart.Location = new Point(20,204);
            btn_add_to_cart.Size = new Size(137,28);
            btn_add_to_cart.Click += Btn_add_to_cart_Click;

            GroupBox groupBox_product_detail = new GroupBox();
            pn_product_info.Controls.Add(groupBox_product_detail);
            groupBox_product_detail.Location = new Point(201,192);
            groupBox_product_detail.Size = new Size(333,488);
            groupBox_product_detail.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //groupBox_product_detail.Size = new System.Drawing.Size(444, 551);
            groupBox_product_detail.Text = "Product Description";

            Label lbl_detail = new Label();
            groupBox_product_detail.Controls.Add(lbl_detail);
            lbl_detail.Location = new Point(2,18);
            lbl_detail.Size = new Size(288,119);
            lbl_detail.Dock = System.Windows.Forms.DockStyle.Top;
            lbl_detail.Font = new System.Drawing.Font("Consolas", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_detail.ForeColor = System.Drawing.Color.Black;
            lbl_detail.AutoSize = true;


            string description = $"Name        : {pro.name}" +
                             $"\r\nId          : {pro.product_id}" +
                             $"\r\nPrice       : {pro.price} Vnd" +
                             $"\r\nQuantity    : {pro.quantity}" +
                             $"\r\nCategory    : {BUS_home.ReturnCategoryName(pro.category_id)}" +
                             $"\r\nShop        : {BUS_home.ReturnShopName(pro.shop_id)}" +
                             $"\r\nDate        : {pro.product_date}";
                             //$"\r\nDescription :>\n {pro.description}";
            lbl_detail.Text = description;
        }

        private void Btn_add_to_cart_Click(object sender, EventArgs e)
        {
            Button add = (Button)sender;
            string product_id = add.Parent.Name;
            if(BUS_shop.CheckCart(cus_id: customer.id.ToString(), pro_id: product_id))
            {
                MessageBox.Show("You already have this product in your cart.","Info to you !",MessageBoxButtons.OK);
                add.Enabled = false;
                return;
            }
            BUS_shop.AddToCart(cus_id: customer.id.ToString(), pro_id: product_id);
            add.Enabled = false;

        }

        private void Btn_buy_now_Click(object sender, EventArgs e)
        {

            Button add = (Button)sender;
            GroupBox parent = add.Parent as GroupBox;
            string quantity = parent.Controls.Find("btn_quantity",true)[0].Text;          
            frm_buy_now frm_Buy_Now = new frm_buy_now(customer, BUS_product.InfoOneProduct(parent.Name),quantity);
            frm_Buy_Now.ShowDialog();

            if (frm_Buy_Now.accept)
            {
                // insert Buy now
            }
        }

        private void Btn_by_now_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            //MessageBox.Show(button.Name.ToString());
            frm_buy_now frm_Buy_Now = new frm_buy_now(customer,BUS_product.InfoOneProduct(button.Name),"1");

            frm_Buy_Now.ShowDialog();
        }

        private void Btn_info_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            flp_product_show.Controls.Clear();
            foreach(product pro in products)
            {
                if (pro.product_id == button.Name)
                {
                    Show_product_info(BUS_home.InfoOneProduct(pro)); break;
                }
            }

        }

        private void Btn_cart_Click(object sender, EventArgs e)
        {
            Button button_add_to_cart = sender as Button;
            if (BUS_shop.CheckCart(cus_id: customer.id.ToString(), pro_id: button_add_to_cart.Name))
            {
                MessageBox.Show("You already have this product in your cart.", "Info to you !", MessageBoxButtons.OK);
                //button_add_to_cart.Enabled = false;
                return;
            }
            MessageBox.Show("This product added to your cart !", "Info to you !", MessageBoxButtons.OK);
            BUS_shop.AddToCart(cus_id: customer.id.ToString(), pro_id: button_add_to_cart.Name);
            //button_add_to_cart.Enabled = false;


        }

        private void Pic_1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            PictureBox pic_1 = sender as PictureBox;
            PictureBox pic_main = Controls.Find("pic_main", true)[0] as PictureBox;
            pic_main.Image = pic_1.Image;
            pic_main.SizeMode = PictureBoxSizeMode.Zoom;
        }

        void provisional_calculator(object sender, EventArgs e) 
        {
            string product_price = Controls.Find("lb_product_price", true)[0].Text.ToString();
            string temp = "";
            foreach(char number in product_price)
            {
                if (!(number == 'V' || number == 'N' || number == 'D' || number == '.'))
                {
                    temp += number;
                }
            }
            int product_price_int = int.Parse(temp);
            int quantity = int.Parse(Controls.Find("btn_quantity", true)[0].Text.ToString());
            var provision_price = Controls.Find("lbl_provision_price", true)[0];
            provision_price.Text = (quantity * product_price_int).ToString() + " Vnd";

        }

        void btn_sub_CLick(object sender, EventArgs e)
        {
            var btn_quantity = Controls.Find("btn_quantity", true)[0] as Button;
            Button button = sender as Button;
            btn_quantity.Text = (BUS_home.quantity_checking(int.Parse(button.Name),int.Parse(btn_quantity.Text.ToString()) - 1,false)).ToString();

            
        }
        void btn_plus_CLick(object sender, EventArgs e)
        {
            var btn_quantity = Controls.Find("btn_quantity", true)[0] as Button;
            Button button = sender as Button;
            btn_quantity.Text = (BUS_home.quantity_checking(int.Parse(button.Name), int.Parse(btn_quantity.Text.ToString()) + 1, true)).ToString();

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            frm_profile frm = new frm_profile(customer.name);
            frm.ShowDialog();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            frm_setting frm_Setting = new frm_setting(account.username);
            frm_Setting.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            BUS_home.StartNewProcess(this,account);
        }

        private void btn_message_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            frm_shopping_cart frm_Shopping_Cart = new frm_shopping_cart(customer);
            frm_Shopping_Cart.ShowDialog();
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            // check here first;
            if (BUS_shop.ReturnShopWithShopOwnerID(cus_id: customer.id.ToString()).name == null)
            {
                if (MessageBox.Show("You don't have any shop here\nDo you want to start a shop now !", "Shop not found !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    frm_shop_register frm_Shop_Register = new frm_shop_register(customer);
                    frm_Shop_Register.ShowDialog();
                    return;
                }
                else
                {
                    return;
                }
            }


            frm_my_shop frm_My_Shop = new frm_my_shop(customer);
            frm_My_Shop.ShowDialog();
        }

        private void btn_friend_Click(object sender, EventArgs e)
        {
            frm_friends frm_Friends = new frm_friends(customer);
            frm_Friends.ShowDialog();
        }

        private void btn_voucher_Click(object sender, EventArgs e)
        {
            frm_voucher frm_voucher = new frm_voucher(customer);
            frm_voucher.ShowDialog();
        }

        private void btn_statistic_Click_1(object sender, EventArgs e)
        {
            frm_statistic frm_Statistic = new frm_statistic(customer:customer);
            frm_Statistic.ShowDialog();

        }

        private void btn_notification_Click(object sender, EventArgs e)
        {
            frm_notification frm_Notification= new frm_notification();
            frm_Notification.ShowDialog();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            frm_filter frm_Filter = new frm_filter();
            frm_Filter.ShowDialog();
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            current_products = BUS_home.CategoryFilter(products, listBox_category.SelectedItem.ToString());
            LoadProducts(current_products);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //if(textBox_search.Text ==)
            current_products = BUS_home.ProductNameFilter(products, textBox_search.Text);
            LoadProducts(current_products);
        }






        private void frm_home_FormClosed(object sender, FormClosedEventArgs e)
        {
            BUS_login.SetLoginStatus(account.username, "0");
        }

        private void frm_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //BUS_login.SetLoginStatus(account.username, "0");

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(current_products == null)
            {
                return;
            }
            LoadProducts(current_products);
        }

        private void button_change_reset_password_Click(object sender, EventArgs e)
        {
            frm_reset_password frm_Reset_Password = new frm_reset_password(account);
            frm_Reset_Password.ShowDialog();
        }

        private void btn_message_Click_1(object sender, EventArgs e)
        {
            // Feedback;

        }

        private void button_information_Click(object sender, EventArgs e)
        {
            //manual instruction
        }
    }
}
