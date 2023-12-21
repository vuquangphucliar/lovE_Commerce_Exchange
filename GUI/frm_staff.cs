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
    public partial class frm_staff : Form
    {
        account current_staff;
        product[] products;
        public frm_staff()
        {
            InitializeComponent();
        }
        public frm_staff(account account)
        {
            this.current_staff = account;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS_login.SetLoginStatus(current_staff.username, "0");
            Dispose();
        }

     
        private void LoadData()
        {
            dataGridView_products.Rows.Clear();
            products = BUS_product.ReturnAllProduct();
            foreach (var product in products)
            {
                if(product.product_status == "False")
                {
                    dataGridView_products.Rows.Add(new object[] {
                            product.name,
                            product.product_date,
                            BUS_shop.ReturnShopName(product.shop_id)
                        });

                }
            }

        }
        private void frm_staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }          

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmProduct(int rowindex)
        {
            BUS_product.ConfirmProduct(ReturnProduct(dataGridView_products[0, rowindex].Value).product_id,current_staff.username);

        }
        private void ShowproductInfo(int rowindex)
        {
            product product = ReturnProduct(dataGridView_products[0, rowindex].Value);
            label_product_name.Text = product.name;
            label_price.Text = product.price;
            label_desc.Text = COnvertDesc(product.description);
            label_quanity.Text = product.quantity;
            label_state.Text = product.product_status == "True" ? "Confirmed" : "Waiting...";
            label_category.Text = product.product_type;

            string[] links = product.main_image.Split('#');
            int i = 0;
            label_link_main.Text = links[++i];


            label_link_1.Text =  ++i >= links.Length ? "" : links[i];
            label_link_2.Text =  ++i >= links.Length ? "" : links[i];
            label_link_3.Text =  ++i >= links.Length ? "" : links[i];
            try
            {
                pictureBox_product.Image = new Bitmap(label_link_main.Text);

            }
            catch
            {
                pictureBox_product.Image = Properties.Resources.images;
            }
            
            
        }
        private string COnvertDesc(string desc)
        {

            int max = 20;
            string nre_desc = "";
            foreach(char  c in desc)
            {
                nre_desc += c;
                if(max == 0)
                {
                    nre_desc += "\n";
                    max = 20;
                }
                max--;

            }
            return nre_desc;
        }
        private product ReturnProduct(object peoduct_name)
        {
             foreach(var product in products)
             {
                if(product.name == peoduct_name.ToString())
                {
                    return BUS_product.InfoOneProduct(product.product_id);
                }
             }                      
            return null;
        }
        private void dataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex == dataGridView_products.RowCount - 1 || e.RowIndex == -1)
            {
                return;
            }
            if(e.ColumnIndex == 3)
            {
                if(MessageBox.Show("Are you sure, You'll take all responsibility for this action !","Confirm product",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    ConfirmProduct(e.RowIndex);
                    LoadData();
                }
            }
            ShowproductInfo(e.RowIndex);
        }

        private void label_product_name_Click(object sender, EventArgs e)
        {

        }

        private void label_forward_Click(object sender, EventArgs e)
        {
            if(label_index.Text == "1")
            {
                try
                {

                    pictureBox_product.Image = new Bitmap(@label_link_1.Text);
                }
                catch
                {
                    pictureBox_product.Image = Properties.Resources.images;
                }
                label_index.Text = "2";
                return;
            }
            if (label_index.Text == "2")
            {
                try
                {
                    pictureBox_product.Image = new Bitmap(label_link_2.Text);

                }
                catch
                {
                    pictureBox_product.Image = Properties.Resources.images;
                }
                label_index.Text = "3";
                return;
            }
            if (label_index.Text == "3")
            {
                try
                {
                    pictureBox_product.Image = new Bitmap(@label_link_3.Text);

                }
                catch
                {
                    pictureBox_product.Image = Properties.Resources.images;
                }
                label_index.Text = "4";
                return;
            }
          
        }

        private void label_backward_Click(object sender, EventArgs e)
        {

            if (label_index.Text == "2")
            {
                try
                {
                pictureBox_product.Image = new Bitmap(@label_link_main.Text);

                }
                catch
                {
                    pictureBox_product.Image = Properties.Resources.images; 
                }
                label_index.Text = "1";
                return;
            }
            if (label_index.Text == "3")
            {
                try
                {
                pictureBox_product.Image = new Bitmap(@label_link_2.Text);

                }
                catch
                {
                    pictureBox_product.Image  = Properties.Resources.images;
                }
                label_index.Text = "2";
                return;
            }
            if (label_index.Text == "4")
            {
                try
                {
                pictureBox_product.Image = new Bitmap(@label_link_3.Text);

                }
                catch
                {
                    pictureBox_product.Image = Properties.Resources.images;
                }
                label_index.Text = "3";
                return;
            }

        }

        private void label_forward_MouseHover(object sender, EventArgs e)
        {
            this.label_forward.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forward.ForeColor = System.Drawing.SystemColors.HotTrack;

        }

        private void label_backward_MouseHover(object sender, EventArgs e)
        {
            this.label_backward.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backward.ForeColor = System.Drawing.SystemColors.HotTrack;


        }

        private void label_backward_MouseLeave(object sender, EventArgs e)
        {
            this.label_backward.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backward.ForeColor = System.Drawing.SystemColors.InfoText;
        }

        private void label_forward_MouseLeave(object sender, EventArgs e)
        {

            this.label_forward.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forward.ForeColor = System.Drawing.SystemColors.InfoText;
        }

        private void button_change_pwd_Click(object sender, EventArgs e)
        {
            frm_reset_password frm_Reset_Password = new frm_reset_password(current_staff);
            frm_Reset_Password.ShowDialog();

        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            BUS_home.StartNewProcess(this, current_staff);
        }
    }
}
