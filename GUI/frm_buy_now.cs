using BUS;
using DLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_buy_now : Form
    {
        public bool accept = false;
        private product product;
        private customer customer;
        private payment[] payments;
        private delivery[] deliveries;
        private voucher[] vouchers;
        public frm_buy_now(customer customer,product product,string quantity)
        {
            InitializeComponent();

            this.product = product;
            this.customer = customer;
            label_product_name.Text = product.name;
            label_price.Text = product.price + " VND";
            label_quantity.Text ="x " +  quantity;
            label_provisional.Text = (int.Parse(quantity) * int.Parse(product.price)).ToString() + " Vnd";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_adderss.Text == "")
            {
                MessageBox.Show("Please, choose your address !","Try again",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;

            }
            if(comboBox_delivery.Text == "")
            {
                MessageBox.Show("Please, choose your delivery!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;

            }if(comboBox_voucher.Text == "")
            {
                MessageBox.Show("Please, choose your voucher", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return;
            }
            if(comboBox_payment.Text == "")
            {
                MessageBox.Show("Please, choose your payment!", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            BuyNow();
            MessageBox.Show("Your product's on the way to you soon", "Thanks for your time !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            accept = true;
            Dispose();
        }
        private void BuyNow()
        {
            Utilities.SendProductBillBuyNow(customer:customer,
                                            product_name:product.name,
                                            quantity: label_quantity.Text.Split(' ')[1],
                                            voucher_name: comboBox_voucher.Text.Split('~')[0],
                                            address:"Your current location ",
                                            payment: comboBox_payment.Text.Split('~')[0],
                                            shop__name:BUS_shop.ReturnOneShop(product.shop_id).name,
                                            date: DateTime.Now.ToString("yyyy/MM/dd").Split(' ')[0]);

            BUS_shop.AddOrder(cus_id: customer.id.ToString(),
                                date: DateTime.Now.ToString("yyyy/MM/dd").Split(' ')[0],
                                total: label_total_amount.Text.Split(' ')[0],
                                voucher_id: comboBox_voucher.Text.Split('~')[1],
                                delivery_id: comboBox_delivery.Text.Split('~')[1],
                                payment: comboBox_payment.Text.Split('~')[1],                                       
                                status: "0");

            string lastorderid = BUS_shop.ReturnLastOrderID();
            BUS_shop.AddOrderDetail(order_id: lastorderid,
                                    product_id: product.product_id,
                                    quantity: label_quantity.Text.Split(' ')[1],
                                    state: "0");
        }


        private void frm_buy_now_Load(object sender, EventArgs e)
        {
            payments = BUS_payment.ReturnAllPayments();
            vouchers = BUS_voucher.ReturnUserVouchers(cus_id: customer.id.ToString());
            deliveries = BUS_delivery.ReturnAllDelivery();

            foreach(payment item in payments)
            {
                comboBox_payment.Items.Add(item.name + " ~" + item.id);
            }
            foreach(delivery item in deliveries)
            {
                comboBox_delivery.Items.Add(item.delivery_name + " ~" + item.delivery_id);
            }
            foreach( voucher item in vouchers)
            {
                if(item.description == "False")
                {
                    comboBox_voucher.Items.Add(item.name + " ~" + item.id);

                }
            }                                                                         
        }
        private void CalculateTotalAmount()
        {
            int provision = int.Parse(label_provisional.Text.Split(' ')[0]);
            int discount = int.Parse(label_discount.Text.Split(' ')[0]);
            label_total_amount.Text = (provision - discount >= 0) ? (provision - discount).ToString() + " Vnd" : "0 Vnd ";
        }

        private void comboBox_voucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_voucher.Text == "NO voucher")
            {
                label_discount.Text =  "0 Vnd";
            }
            foreach(voucher item in vouchers)
            {
                if(item.name + " " == comboBox_voucher.SelectedItem.ToString().Split('~')[0])
                {
                    label_discount.Text = item.discount + " Vnd";
                    break;

                }
            }

        }

        private void label_provisional_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void label_discount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }
    }
}
