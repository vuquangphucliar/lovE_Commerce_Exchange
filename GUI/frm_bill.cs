using BUS;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_bill : Form
    {
        private product[] products;
        private string[] quantities;
        private string provisional;
        private string discount;
        private string total;
        private customer customer;
        public frm_bill(customer customer,product[] products,string quantities,string provisional, string discount,string total)
        {
            this.customer = customer;
            this.products = products;
            this.provisional = provisional;
            this.discount = discount;
            this.total = total;
            this.quantities = quantities.Split('~');
            InitializeComponent();              

        }
        public frm_bill() { InitializeComponent(); }



        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Your product's on the way to you soon","Thanks for your time !",MessageBoxButtons.OK,MessageBoxIcon.Information);


            // Set bill
            //MessageBox.Show();
            
            Dispose();
        }
        //private string ReturnVoucherID(string name)
        //{
        //    foreach(var item in vouchers)
        //    {

        //    }
        //}

        private void LoadProduct()
        {
            label_discount.Text = discount + " Vnd";
            label_provision.Text = provisional + " Vnd";
            label_total_amount.Text = total + " Vnd";
            int i = 0;
            foreach (var product in products)
            {
                Addproduct(product_name: product.name, quantities[++i],price:product.price);
            }
        }
        private void frm_bill_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        //private void LoadProductCost()
        //{
        //    GroupBox groupBox;

            
        //    foreach(Control product in flowLayoutPanel_products.Controls)
        //    {
        //        groupBox = product as GroupBox;

                

        //    }

        //}
        private void Addproduct(string product_name,string product_quantities,string price)
        {
            //Gen box
            GroupBox groupBox_product = new GroupBox();
            flowLayoutPanel_products.Controls.Add(groupBox_product);
            //groupBox_product.Location = new Point(2, 2);
            groupBox_product.Size = new Size(332, 44);

            Label label_product_name = new Label();
            groupBox_product.Controls.Add(label_product_name);
            label_product_name.Location = new Point(4, 15);
            label_product_name.Size = new Size(136, 17);
            label_product_name.Text = product_name;
            label_product_name.Name = "label_product_name";
            label_product_name.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic);
            label_product_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            Label label_quntities = new Label();
            groupBox_product.Controls.Add(label_quntities);
            label_quntities.Location = new Point(170, 15);
            label_quntities.Size = new Size(24, 17);
            label_quntities.Text = product_quantities;
            label_quntities.Name = "label_quantities";
            label_quntities.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic);
            label_quntities.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            Label label_price = new Label();
            groupBox_product.Controls.Add(label_price);
            label_price.Location = new Point(230, 15);
            label_price.Size = new Size(80, 17);
            label_price.Text = price;
            label_price.ForeColor = System.Drawing.Color.Red;
            label_price.Name = "label_price";
            label_price.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic);
            label_price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        }
    }
}
