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
    public partial class frm_voucher : Form
    {
        private voucher[] vouchers;
        private customer customer;
        voucher[] User_voucher;
        public frm_voucher(customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }
        private void LoadVoucher()
        {
            //Load all voucehr
            vouchers = BUS_voucher.ReturnAllVouchers();
            User_voucher = BUS_voucher.ReturnUserVouchers(cus_id: customer.id.ToString());
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel_my_voucher.Controls.Clear();
            foreach (var voucher in vouchers)
            {
                AddVoucher(voucher);
            }
            //Load user voucher
            foreach (var voucher in User_voucher)
            {
                AddMyVoucher(voucher);

            }
        }
        private void AddVoucher(voucher voucher)
        {
            GroupBox groupBox_voucher = new GroupBox();
            flowLayoutPanel1.Controls.Add(groupBox_voucher);
            groupBox_voucher.Size = new System.Drawing.Size(625, 63);
            //groupBox_vouche

            Label label_voucher_desc = new Label();
            groupBox_voucher.Controls.Add(label_voucher_desc);
            //label_voucher_desc.Size = new Size(160, 18);
            label_voucher_desc.Location = new Point(14, 28);
            label_voucher_desc.Text = voucher.name;      
            label_voucher_desc.AutoSize = true;

            Label label_voucher_name = new Label();
            groupBox_voucher.Controls.Add(label_voucher_name);
            //label_voucher_name.Size = new Size();
            label_voucher_name.Location = new Point(220,28);
            label_voucher_name.Text = voucher.name;

            Label label_quantity = new Label();
            groupBox_voucher.Controls.Add(label_quantity);
            label_quantity.Size = new Size(16, 18);
            label_quantity.Location = new Point(344, 28);
            label_quantity.Text = voucher.quantity;
            label_quantity.Name = "quantity";
            //labe

            Label label_discount = new Label();
            groupBox_voucher.Controls.Add(label_discount);
            //label_discount.Size = new Size(40,18);
            label_discount.Location = new Point(422, 28);
            label_discount.AutoSize = true; 
            label_discount.Text = voucher.discount +'%';

            Label label_status = new Label();
            groupBox_voucher.Controls.Add((Label)label_status);
            label_status.Location = new Point(507, 28);
            //label_status.Size = new Size(16, 18);
            label_status.AutoSize = true; ;
            label_status.Text = voucher.active != "0" ? "Active" : "Expire";
            label_status.ForeColor = System.Drawing.Color.Lime;

            Button button_remove = new Button();
            groupBox_voucher.Controls.Add(button_remove);
            button_remove.Location = new Point(587, 20);
            button_remove.Size = new Size(34, 37);
            button_remove.Image = new Bitmap(@"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Hopstarter-Sleek-Xp-Basic-Add.48.png");
            button_remove.Click += Button_remove_Click;
            button_remove.Name = voucher.id.ToString();
        }
        private void AddMyVoucher(voucher voucher)
        {
            GroupBox groupBox_voucher = new GroupBox();
            flowLayoutPanel_my_voucher.Controls.Add(groupBox_voucher);
            groupBox_voucher.Size = new System.Drawing.Size(625, 63);
            //groupBox_vouche

            Label label_voucher_desc = new Label();
            groupBox_voucher.Controls.Add(label_voucher_desc);
            //label_voucher_desc.Size = new Size(160, 18);
            label_voucher_desc.Location = new Point(14, 28);
            label_voucher_desc.Text = voucher.name;
            label_voucher_desc.AutoSize = true;

            Label label_voucher_name = new Label();
            groupBox_voucher.Controls.Add(label_voucher_name);
            //label_voucher_name.Size = new Size();
            label_voucher_name.Location = new Point(220, 28);
            label_voucher_name.Text = voucher.name;

            Label label_quantity = new Label();
            groupBox_voucher.Controls.Add(label_quantity);
            label_quantity.Size = new Size(16, 18);
            label_quantity.Location = new Point(344, 28);
            label_quantity.Text = "1";  
            //labe

            Label label_discount = new Label();
            groupBox_voucher.Controls.Add(label_discount);
            //label_discount.Size = new Size(40,18);
            label_discount.Location = new Point(422, 28);
            label_discount.AutoSize = true;
            label_discount.Text = voucher.discount + '%';

            Label label_status = new Label();
            groupBox_voucher.Controls.Add((Label)label_status);
            label_status.Location = new Point(507, 28);
            //label_status.Size = new Size(16, 18);
            label_status.AutoSize = true; ;
            label_status.Text = voucher.description != "False" ? "Used" : "Active";
            label_status.ForeColor = System.Drawing.Color.Lime;

            Button button_remove = new Button();
            groupBox_voucher.Controls.Add(button_remove);                                               
            button_remove.Location = new Point(587, 20);
                                                      button_remove.Size = new Size(34, 37);
            button_remove.Image = new Bitmap(@"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Graphicloads-100-Flat-Recyclebin.16.png");
            button_remove.Click += Button_remove_Click1;
            button_remove.Name = voucher.id.ToString();
        }

        private void Button_remove_Click1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Control control = sender as Control;
            if(MessageBox.Show("Are you sure you want delete this voucher", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                BUS_voucher.DeleteUserVoucher(customer.id.ToString(),control.Name);
                control.Parent.Dispose();
                LoadVoucher();
            }

        }
        bool CheckVOucher(string voucherId)
        {
            foreach(var voucher in User_voucher)
            {
                if(voucher.id.ToString() == voucherId)
                {
                    return true;
                }
            }
            return false;
        }
        private void Button_remove_Click(object sender, EventArgs e)
        {
            //Claim voucher
            Control control = sender as Control;

            if (MessageBox.Show("Do you want to claim this voucher", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if(CheckVOucher(control.Name))
                {
                    MessageBox.Show("You already have this voucher before","Just one Voucher",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;

                }

                if (control.Parent.Controls.Find("quantity", true)[0].Text == "0")
                {
                    MessageBox.Show("Sorry but we've already sold out !", "Voucher sold out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;

                }

                BUS_voucher.ClaimVoucher(customer.id.ToString(), control.Name);
                LoadVoucher();
            }
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            
            


        }

        private void frm_voucher_Load(object sender, EventArgs e)
        {
            LoadVoucher();
        }
    }
}
