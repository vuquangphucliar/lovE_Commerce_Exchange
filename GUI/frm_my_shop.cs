using BUS;
using DLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_my_shop : Form
    {
        private product[] products;
        private shop my_shop;
        private customer onwer;
        private int number_of_checked = 0;
        private order_confirm[] order_Confirms;
        private customer[] customers;
        //private private 
        public frm_my_shop(customer customer)
        {
            onwer = customer;
            my_shop = BUS_shop.ReturnShopWithShopOwnerID(cus_id: onwer.id.ToString());
            products = BUS_shop.ReturnAllShopProducts(my_shop.id);
            order_Confirms = BUS_shop.ReturnOrderConfirm(my_shop.id);
            customers = BUS_customer.ReturnAllCustomer();
            InitializeComponent();
            label_shop_name.Text = my_shop.name;
        }



        private void frm_my_shop_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadOrderConfirm();

        }
        private void LoadProduct()
        {
            if (products.Length == 0)
            {
                NotHaveProduct();
            }
            else
            {
                foreach (var product in products)
                {
                    Addproduct(product);
                }

            }

        }
        private void LoadOrderConfirm()
        {

            for (int i = order_Confirms.Length - 1; i > 0; i--)
            {
                AddOrderProduct(order_Confirms[i]);

            }
            foreach (order_confirm order in order_Confirms)
            {
                if (order.order_status == "False")
                {
                    return;

                }
            }
            NotHaveOrder();

        }

        private void NotHaveProduct()
        {
            GroupBox groupBox_product = new GroupBox();
            flowLayoutPanel_show_all_product.Controls.Add(groupBox_product);
            groupBox_product.Location = new Point(2, 2);
            groupBox_product.Size = new Size(624, 71);

            Label label_order_cutomer = new Label();
            groupBox_product.Controls.Add(label_order_cutomer);
            label_order_cutomer.Location = new Point(205, 28);
            //label_order_cutomer.Size = new Size(90, 19);
            label_order_cutomer.AutoSize = true;
            label_order_cutomer.Text = "There's no product here !";
            //label_order_cutomer.Name = "customer~";

        }
        private void NotHaveOrder()
        {
            GroupBox groupBox_product = new GroupBox();
            flowLayoutPanel_show_orders.Controls.Add(groupBox_product);
            groupBox_product.Location = new Point(2, 2);
            groupBox_product.Size = new Size(624, 71);

            Label label_order_cutomer = new Label();
            groupBox_product.Controls.Add(label_order_cutomer);
            label_order_cutomer.Location = new Point(210, 28);
            //label_order_cutomer.Size = new Size(90, 19);
            label_order_cutomer.AutoSize = true;
            label_order_cutomer.Text = "Not have any Order here !";
            //label_order_cutomer.Name = "customer~";

        }

        private void Addproduct(product product)
        {
            GroupBox groupBox_product = new GroupBox();
            flowLayoutPanel_show_all_product.Controls.Add(groupBox_product);
            groupBox_product.Location = new Point(2, 2);
            groupBox_product.Size = new Size(624, 71);
            //groupBox_product.Text = product.name;
            groupBox_product.Name = product.product_id;

            CheckBox checkBox_product = new CheckBox();
            groupBox_product.Controls.Add(checkBox_product);
            checkBox_product.Size = new Size(163, 22);
            checkBox_product.Location = new Point(4, 28);
            checkBox_product.Text = product.name;
            checkBox_product.Name = "checkBox_product";
            checkBox_product.CheckedChanged += CheckBox_product_CheckedChanged;

            Label label_quantity = new Label();
            groupBox_product.Controls.Add(label_quantity);
            label_quantity.Location = new Point(338, 30);
            label_quantity.Size = new Size(32, 17);
            label_quantity.Text = product.quantity;

            Label label_confirm = new Label();
            groupBox_product.Controls.Add(label_confirm);
            label_confirm.Location = new Point(528, 32);
            label_confirm.Size = new Size(80, 17);
            label_confirm.Name = "status";
            if (product.product_status == "True")
            {
                label_confirm.Text = "confirm";
                label_confirm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            }
            else
            {
                label_confirm.Text = "Waiting...";
                label_confirm.ForeColor = Color.Brown;

            }
            label_confirm.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //label_confirm.Image = new Bitap(@"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Hopstarter-Sleek-Xp-Basic-Ok.32.png");

            Label label_price = new Label();
            groupBox_product.Controls.Add(label_price);
            label_price.Location = new Point(431, 32);
            label_price.Size = new Size(80, 17);
            label_price.Text = product.price;
            label_price.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_price.ForeColor = System.Drawing.Color.Red;
        }
        private void AddOrderProduct(order_confirm order_Confirm)
        {
            GroupBox groupBox_order_product = new GroupBox();
            flowLayoutPanel_show_orders.Controls.Add(groupBox_order_product);
            groupBox_order_product.Location = new Point(2, 2);
            groupBox_order_product.Size = new Size(622, 62);
            //groupBox_order_product.Name = order_Confirm.order_id;

            Label label_order_product_name = new Label();
            groupBox_order_product.Controls.Add(label_order_product_name);
            label_order_product_name.Location = new Point(14, 28);
            label_order_product_name.AutoSize = true;
            label_order_product_name.Text = order_Confirm.name;
            label_order_product_name.Name = "name~";

            Label label_order_cutomer = new Label();
            groupBox_order_product.Controls.Add(label_order_cutomer);
            label_order_cutomer.Location = new Point(230, 28);
            //label_order_cutomer.Size = new Size(80, 19);
            label_order_cutomer.AutoSize = true;
            label_order_cutomer.Text = ReturnCustomerName(order_Confirm.customer_id) + " ~" + order_Confirm.customer_id;
            label_order_cutomer.Name = "customer~";

            Label label_order_quantity = new Label();
            groupBox_order_product.Controls.Add(label_order_quantity);
            label_order_quantity.Location = new Point(390, 28);
            label_order_quantity.AutoSize = true;
            label_order_quantity.Text = order_Confirm.quantity;
            label_order_quantity.Name = "quantity";

            Label label_order_price = new Label();
            groupBox_order_product.Controls.Add(label_order_price);
            label_order_price.Location = new Point(450, 28);
            label_order_price.AutoSize = true;
            label_order_price.Text = order_Confirm.price;
            label_order_price.ForeColor = Color.Red;
            label_order_price.Name = order_Confirm.price;

            Button button_confirm_oder = new Button();
            groupBox_order_product.Controls.Add(button_confirm_oder);
            button_confirm_oder.Location = new Point(539, 15);
            button_confirm_oder.Size = new Size(38, 41);
            button_confirm_oder.Image = new Bitmap(@"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Hopstarter-Sleek-Xp-Basic-Ok.32.png");
            button_confirm_oder.Click += Button_confirm_oder_Click;
            button_confirm_oder.Name = order_Confirm.order_id + '~' + order_Confirm.order_detail_id;


            Button button_cancel_oder = new Button();
            groupBox_order_product.Controls.Add(button_cancel_oder);
            button_cancel_oder.Location = new Point(578, 15);
            button_cancel_oder.Size = new Size(38, 41);
            button_cancel_oder.Image = new Bitmap(@"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Hopstarter-Button-Button-Close.32.png");
            button_cancel_oder.Click += Button_cancel_oder_Click;
            button_cancel_oder.Name = order_Confirm.order_id + '~' + order_Confirm.order_detail_id;



        }


        private void CheckBox_product_CheckedChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                number_of_checked++;
            }
            else
            {
                number_of_checked--;
            }
        }
        private void checkBox_all_products_CheckedChanged(object sender, EventArgs e)
        {
            bool check;
            if (checkBox_all_products.Checked)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            foreach (Control control in flowLayoutPanel_show_all_product.Controls)
            {
                CheckBox checkBox = control.Controls.Find("checkBox_product", true)[0] as CheckBox;
                checkBox.Checked = check;
            }
        }
        private string ReturnCustomerName(string id)
        {
            foreach (customer customer in customers)
            {
                if (customer.id.ToString() == id)
                {
                    return customer.name;
                }
            }
            return "unknown";

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Show form add product
            frm_add_product frm_Add_Product = new frm_add_product("add",my_shop);
            frm_Add_Product.ShowDialog();
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (number_of_checked == 0 || number_of_checked > 1)
            {
                MessageBox.Show("Please, Choose a product to edit information !", "Product editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Control control in flowLayoutPanel_show_all_product.Controls)
            {
                CheckBox checkBox = control.Controls.Find("checkBox_product", true)[0] as CheckBox;

                if (checkBox.Checked)
                {
                    //BUS_product.DeleteProduct(checkBox.Text);
                    frm_add_product frm_Add_Product = new frm_add_product("edit",my_shop,checkBox.Parent.Name);
                    frm_Add_Product.ShowDialog();
                    break;
                }
            }

        }                             
        private void button_delete_Click(object sender, EventArgs e)
        {
            // check only one pruduct
            if (number_of_checked == 0)
            {
                MessageBox.Show("Please Choose at least one product to delete !", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // check product under the  waiting review
            foreach (Control control in flowLayoutPanel_show_all_product.Controls)
            {
                CheckBox checkBox = control.Controls.Find("checkBox_product", true)[0] as CheckBox;

                if (checkBox.Checked)
                {
                    if (checkBox.Parent.Controls.Find("status", true)[0].Text != "Waiting...")
                    {
                        MessageBox.Show("You are only allowed to delete products that are currently under review.\nPlease, Try another one", "Invalid product",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            // Delete product;
            if (MessageBox.Show("Are you sure !, \nThis action will delete your product permanently !", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (Control control in flowLayoutPanel_show_all_product.Controls)
                {
                    CheckBox checkBox = control.Controls.Find("checkBox_product", true)[0] as CheckBox;

                    if (checkBox.Checked)
                    {
                        BUS_product.DeleteProduct(checkBox.Parent.Name);
                        break;
                    }
                }
            }
            MessageBox.Show("Your product has been deleted successfully !","Informs to you",MessageBoxButtons.OK);
            Dispose();

        }
        private void button_info_Click(object sender, EventArgs e)
        {
            if (number_of_checked == 0 || number_of_checked > 1)
            {
                MessageBox.Show("Please choose a product in shop to know more information !", "Product information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // show from information;
            MessageBox.Show("product information");

        }

        private void Button_cancel_oder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this order!", "Remove order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // remove order here;
                Button button_confirm = sender as Button;
                BUS_shop.DeleteOrderDetail(order_detail_id: button_confirm.Name.Split('~')[1],
                                                   order_id: button_confirm.Name.Split('~')[0]);
                button_confirm.Parent.Dispose();
            }
        }
        private void Button_confirm_oder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to comfirm this order!", "Confirm order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                
                
                Button button_confirm = sender as Button; ;
                string quantity = button_confirm.Parent.Controls.Find("quantity", true)[0].Text;
                string product_name = button_confirm.Parent.Controls.Find("name~", true)[0].Text;

                if (BUS_product.CheckQuantity(product_name,quantity))
                {
                    BUS_shop.UpdateOrderConfirm(order_detail_id: button_confirm.Name.Split('~')[1],
                                                       order_id: button_confirm.Name.Split('~')[0]);
                    button_confirm.Parent.Dispose();

                    products = BUS_shop.ReturnAllShopProducts(my_shop.id);
                    LoadProduct();

                }
                else
                {
                    MessageBox.Show("Your product dose not have enough quantity to confirm this order, please checking your product information again !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
        



    }
}
