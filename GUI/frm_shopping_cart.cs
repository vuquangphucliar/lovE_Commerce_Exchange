using BUS;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_shopping_cart : Form
    {
        private  customer customer;
        private product[] products;
        private payment[] payments;
        private delivery[] deliveries;
        private voucher[] vouchers;
        public frm_shopping_cart(customer customer)
        {
            this.customer = customer;
            products = BUS_shop.ReturnShoppingCart(cus_id: customer.id.ToString());
            InitializeComponent();
            LoadProduct(products); ;
            //flowLayoutPanel_products.Controls.Clear();
        }

        private void LoadProduct(product[] products)
        {
            foreach(product pro in products)
            {
                Add_product(pro);
            }
        }
        private void Add_product(product pro)
        {

            GroupBox groupBox_product = new GroupBox();
            flowLayoutPanel_products.Controls.Add(groupBox_product);
            groupBox_product.Size = new Size(611,63);
            groupBox_product.Location = new Point(2,2);
            groupBox_product.Name = "groupBox_product";

            Control control = new Control();
            groupBox_product.Controls.Add(control);
            control.Name = "max_quantity";
            control.Text = pro.quantity;
            control.Visible = false;
            control.Enabled = false;

            Label label_product_id = new Label();
            groupBox_product.Controls.Add(label_product_id);
            label_product_id.Enabled = false;
            label_product_id.Visible = false;
            label_product_id.Text = pro.product_id.ToString();
            label_product_id.Name = "product_id";
            

            CheckBox checkBox_product = new CheckBox();             
            groupBox_product.Controls.Add(checkBox_product);
            checkBox_product.Location = new Point(8,24);
            checkBox_product.Size = new Size(163,21);
            checkBox_product.Text = pro.name;
            checkBox_product.AutoSize = true;
            checkBox_product.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            checkBox_product.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            checkBox_product.TabIndex = 2;
            checkBox_product.Name = "checkBox_product";
            checkBox_product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox_product.UseVisualStyleBackColor = true;
            checkBox_product.CheckedChanged += CheckBox_product_Click;
            

            Label label_price = new Label();
            groupBox_product.Controls.Add(label_price);
            label_price.Location = new Point(290,27);
            label_price.Size = new Size(72,17);
            label_price.Text = pro.price;
            label_price.Name = "label_price";
            label_price.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_price.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

            Button button_subtract = new Button();
            groupBox_product.Controls.Add(button_subtract);
            button_subtract.Location = new Point(386,20);
            button_subtract.Size = new Size(26,28);
            button_subtract.Text = "-";
            button_subtract.Name = "-";
            button_subtract.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_subtract.Click += Button_subtract_Click;

            Button button_plus = new Button();
            groupBox_product.Controls.Add(button_plus);
            button_plus.Location = new Point(460,20);
            button_plus.Size = new Size(26,28);
            button_plus.Text = "+";
            button_plus.Name = "+";
            button_plus.Click += Button_plus_Click;
            button_plus.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Button button_quantity = new Button();
            groupBox_product.Controls.Add(button_quantity);
            button_quantity.Location = new Point(414,20);
            button_quantity.Size = new Size(44,28);
            button_quantity.Text = "1";
            button_quantity.Name = "button_quantity_cart";
            //button_quantity.Click += Button_quantity_Click;
            button_quantity.TextChanged += Button_quantity_TextChanged;
            button_quantity.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            Button button_remove = new Button();
            groupBox_product.Controls.Add(button_remove);
            button_remove.Location = new Point(572,20);
            button_remove.Size = new Size(28,30);
            button_remove.Name = "button_remove";
            //button_remove.BackColor = Color.Red; ;
            //button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += Button_remove_Click;
            button_remove.Image = new Bitmap(@"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Graphicloads-100-Flat-Recyclebin.16.png");

            Label label_into_money = new Label();
            groupBox_product.Controls.Add(label_into_money);
            label_into_money.Location = new Point(495,27);
            label_into_money.Size = new Size(72,17);
            label_into_money.Name = "label_into_money_cart";
            label_into_money.Text = pro.price;
            label_into_money.TextChanged += Label_into_money_TextChanged;
            label_into_money.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_into_money.ForeColor = System.Drawing.Color.IndianRed;
        }

        private void Button_remove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to remove this product from your cart?","Info",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                return;
            }
            Button remove = sender as Button;
            string product_id = remove.Parent.Controls.Find("product_id", true)[0].Text;
            remove.Parent.Dispose();
            // Remove cart
            BUS_shop.RemoveProductCart(customer.id.ToString(), product_id);
        }

        private void Label_into_money_TextChanged(object sender, EventArgs e)
        {
            //Label money = sender as Label;
            //GroupBox parent = money.Parent as GroupBox;
            //CheckBox checkBox_product = parent.Controls.Find("checkBox_product",true)[0] as CheckBox;
            //if (checkBox_product.Checked)
            //{

            //}
        }

        private void Button_quantity_TextChanged(object sender, EventArgs e)
        {
            Button quantity = sender as Button;
            int price = int.Parse(quantity.Parent.Controls.Find("label_price", true)[0].Text);
            quantity.Parent.Controls.Find("label_into_money_cart", true)[0].Text = (price * int.Parse(quantity.Text)).ToString();
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            Button button_plus = sender as Button;
            GroupBox groupBox_parent = (GroupBox)button_plus.Parent;
            int old_quantity = int.Parse(groupBox_parent.Controls.Find("button_quantity_cart", true)[0].Text);
            if (old_quantity < 20)
            {

                Button button = groupBox_parent.Controls.Find("button_quantity_cart", true)[0] as Button;
                Control control = groupBox_parent.Controls.Find("max_quantity", true)[0];
                button.Text = (BUS_home.quantity_checking(int.Parse(control.Text),int.Parse(button.Text.ToString()) + 1, true)).ToString();
            }
            else
            {
                return;
            }
        }

        private void Button_subtract_Click(object sender, EventArgs e)
        {
            
            Button button_plus = sender as Button;
            GroupBox groupBox_parent = (GroupBox)button_plus.Parent;
            int old_quantity = int.Parse(groupBox_parent.Controls.Find("button_quantity_cart", true)[0].Text);
            if (old_quantity > 1)
            {
               
                Button button = groupBox_parent.Controls.Find("button_quantity_cart", true)[0] as Button;
                Control control = groupBox_parent.Controls.Find("max_quantity", true)[0];
                button.Text = (BUS_home.quantity_checking(int.Parse(control.Text), int.Parse(button.Text.ToString()) - 1, false)).ToString();
            }
            else
            {
                return;
            }
        }

        private void CheckBox_product_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            GroupBox groupBox = checkBox.Parent as GroupBox;
            int provision_price = int.Parse(label_provision.Text);
            int product_price = int.Parse(groupBox.Controls.Find("label_into_money_cart", true)[0].Text);
            if (checkBox.Checked)
            {
                label_provision.Text = (provision_price + product_price).ToString();
                groupBox.Controls.Find("+", true)[0].Enabled = false;
                groupBox.Controls.Find("-", true)[0].Enabled = false;
            }
            else
            {
                label_provision.Text = (provision_price - product_price).ToString();
                groupBox.Controls.Find("+", true)[0].Enabled = true;
                groupBox.Controls.Find("-", true)[0].Enabled = true;
            }
        }

        private product[] ProductFilter()
        {
            GroupBox groupBox;
            CheckBox checkBox;
            List<product> products_ = new List<product>();
            foreach (Control item in flowLayoutPanel_products.Controls.Find("groupBox_product", true))
            {
                groupBox = item as GroupBox;
                checkBox = groupBox.Controls.Find("checkBox_product", true)[0] as CheckBox;
                if (checkBox.Checked)
                {
                    products_.Add(BUS_product.InfoOneProduct(groupBox.Controls.Find("product_id", true)[0].Text));
                }
            }
            return products_.ToArray();
        }

        private void button_puchase_Click(object sender, EventArgs e)
        {
            

            if(ProductFilter().Length == 0)
            {
                MessageBox.Show("You need to choose at least on product to buy ", "Info to you !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(comboBox_address.Text == "")
            {
                MessageBox.Show("Please check your address","Checking Address again !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(comboBox_delivery.Text == "")
            {
                MessageBox.Show("Please choose your delivery", "Checking Delivery !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }                                                                       if(comboBox_payment.Text == "")
            {
                MessageBox.Show("Please check your payment", "Payment!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(comboBox_voucher.Text == "")
            {
                MessageBox.Show("Please check your voucher again", "Checking voucher again !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("Are you sure to buy these products","Product Purchase Comfirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Buy();
            }
        }

        private void Buy()
        {
            BUS_shop.AddOrder(cus_id: customer.id.ToString(),
                                date: DateTime.Now.ToString("yyyy/MM/dd").Split(' ')[0],
                                total: label_total_amount.Text,
                                voucher_id: comboBox_voucher.Text.Split('~')[1],
                                delivery_id: comboBox_delivery.Text.Split('~')[1],
                                payment: comboBox_payment.Text.Split('~')[1],
                                status: "0"
                                );
            string lastorderid = BUS_shop.ReturnLastOrderID();

            string quantites = "";
            string temp;
            foreach (Control control in flowLayoutPanel_products.Controls)
            {
                CheckBox check = control.Controls.Find("checkBox_product", true)[0] as CheckBox;
                if (check.Checked)
                {
                    temp = control.Controls.Find("button_quantity_cart", true)[0].Text;
                    BUS_shop.AddOrderDetail(order_id: lastorderid,
                                           product_id: control.Controls.Find("product_id", true)[0].Text,
                                           quantity: temp,
                                           state: "0");
                    quantites += '~' + temp;
                }
            }
            Utilities.SendProductBill(customer: customer,
                                        address: comboBox_address.Text,
                                        payment: comboBox_payment.Text.Split('~')[0],
                                        products: Utilities.ConfigureMailProducts(ProductFilter(), quantites),
                                        total_price: label_total_amount.Text);
            frm_bill frm_Bill = new frm_bill(customer, ProductFilter(), quantites, label_provision.Text, label_discount.Text, label_total_amount.Text);
            frm_Bill.ShowDialog();
        }
  
        private void checkBox_choose_all_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            bool check;
            if(checkbox.Checked)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            GroupBox groupBox;
            CheckBox checkBox;
            foreach(Control item  in flowLayoutPanel_products.Controls.Find("groupBox_product", true))
            {
                groupBox = item  as GroupBox;
                checkBox = groupBox.Controls.Find("checkBox_product",true)[0] as CheckBox;
                checkBox.Checked = check;
            }
        
           
        }

        private void label_provision_TextChanged(object sender, EventArgs e)
        {
            int total_amount = int.Parse(label_provision.Text);
            int discount = int.Parse(label_discount.Text);
            label_total_amount.Text = (total_amount - discount).ToString();
        }

        private void frm_shopping_cart_Load(object sender, EventArgs e)
        {
            payments = BUS_payment.ReturnAllPayments();
            vouchers = BUS_voucher.ReturnUserVouchers(cus_id: customer.id.ToString());
            deliveries = BUS_delivery.ReturnAllDelivery();

            foreach (payment item in payments)
            {
                comboBox_payment.Items.Add(item.name+'~'+item.id);
            }
            foreach (delivery item in deliveries)
            {
                comboBox_delivery.Items.Add(item.delivery_name + '~' + item.delivery_id);
            }
            foreach (voucher item in vouchers)
            {
                comboBox_voucher.Items.Add(item.name + '~' + item.id);
            }
        }

        private void CalculateTotalAmount()
        {
            int provision = int.Parse(label_provision.Text.Split(' ')[0]);
            int discount = int.Parse(label_discount.Text.Split(' ')[0]);
            label_total_amount.Text = (provision - discount >= 0) ? (provision - discount).ToString() : "0";
        }

        private void comboBox_voucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_voucher.SelectedIndex == 0)
            {
                label_discount.Text = "0";
            }
            foreach (voucher item in vouchers)
            {
                if (item.name  == comboBox_voucher.SelectedItem.ToString().Split('~')[0])
                {
                    label_discount.Text = item.discount ;
                    break;

                }
            }
            CalculateTotalAmount();
        }

        private void label_provision_Click(object sender, EventArgs e)
        {

        }

        private void label_discount_Click(object sender, EventArgs e)
        {

        }

        private void label_total_amount_Click(object sender, EventArgs e)
        {
            
        }

        private void label_total_amount_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(label_total_amount.Text) <= 0)
            {
                label_total_amount.Text = "0";
            }
        }
    }
}
