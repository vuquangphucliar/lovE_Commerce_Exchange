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
    public partial class frm_shop_register : Form
    {
        public bool accept = false;
        private shop[] shops;
        private customer onwer;
        public frm_shop_register(customer customer)
        {
            shops = BUS_shop.ReturnAllShops();
            onwer = customer;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void checkBox_terms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_terms.Checked)
            {
                button_register.Enabled = true;
            }
            else
            {
                button_register.Enabled = false;
            }

        }
        private bool CheckNameSHop(string name)
        {
            foreach (var shop in shops)
            {
                if (shop.name == textBox_shop_name.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if(textBox_shop_name.Text.Length > 20)
            {
                MessageBox.Show("This shop name must not more than 20 characters,\nPlease try again !", "Invalid Shop name !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }
            if (CheckNameSHop(textBox_shop_name.Text))
            {
                MessageBox.Show("This shop name's already exist,\nPlease try again !", "Invalid Shop name !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_shop_address.Text.Length > 20)
            {
                MessageBox.Show("The address must not more than 20 characters,\nPlease try again !", "Invalid Shop address !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if(textBox_phone.Text.Length != 11)
            {
                MessageBox.Show("The phone must has 11 digits ,\nPlease try again !", "Invalid phone number!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            }
            if(textBox_desc.Text.Length > 50)
            {
                MessageBox.Show("The description length must less than 50 characters ,\nPlease try again !","Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            
            BUS_shop.ShopRegister(name: textBox_shop_name.Text,
                    address: textBox_shop_address.Text,
                    desc: textBox_desc.Text,
                    phone: textBox_phone.Text,
                    owner: onwer.id.ToString());
            accept = true;
            MessageBox.Show("Shop registration successful,\n" +
                            "Let's start a bussiness now !","Confratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Dispose();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
