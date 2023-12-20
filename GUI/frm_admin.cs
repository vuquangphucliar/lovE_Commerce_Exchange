using BUS;
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
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
            textBox_today.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_code.Clear();
            textBox_name.Clear();
            textBox_discount.Clear();
            textBox_expire.Clear();
            textBox_quantity.Clear();
            textBox_today.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = BUS_voucher.AllVoucher();

        }

        bool CheckDate(string expire)
        {
            //DateTime date;
            if(DateTime.TryParse(expire, out DateTime date))
            {
                if(date > DateTime.Now)
                {
                    return true;
                }
            }
            return false;

        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to add this voucher ?", "Info", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (!CheckDate(textBox_expire.Text))
                {
                    //
                    MessageBox.Show("Date expire format must be yyyy/MM/dd and more than today.", "Invalid expire date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(textBox_code.Text.Length != 10)
                {
                    MessageBox.Show("The voucher code length must be 10 characters !", "Invalid voucher code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                if(int.Parse(textBox_discount.Text) > 100)
                {
                    MessageBox.Show("The voucher discount cannot more than 100% !", "Invalid voucher discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }
                if(textBox_name.Text.Length < 5)
                {
                    MessageBox.Show("The voucher name length need at least 6 chacraters !", "Invalid voucher discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BUS_voucher.InsertIntoVOucher(name:  textBox_name.Text,
                                            code:    textBox_code.Text,
                                            discount:textBox_discount.Text,
                                            today:   textBox_today.Text,
                                            expire:  textBox_expire.Text,
                                            quanity: textBox_quantity.Text);

                //dataGridView1.Rows.Add(new object[] { textBox_name.Text, 
                //                                        textBox_code.Text,
                //                                        textBox_discount.Text  ,
                //                                        textBox_today.Text,
                //                                        textBox_expire.Text,
                //                                        textBox_quantity.Text  });
                LoadData();
           
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count == 1)
            {
                BUS_voucher.DeleteVOucher(voucher_id: dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("You need to choose one voucher to axecute this action !", "Invalid voucher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        string COnvertDate(string date)
        {
            return DateTime.Parse(date).ToString("yyyy/MM/dd");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;

            }
            textBox_name.Text = dataGridView1[1,e.RowIndex].Value.ToString();
            textBox_code.Text = dataGridView1[2,e.RowIndex].Value.ToString();
            textBox_discount.Text = dataGridView1[3,e.RowIndex].Value.ToString();
            textBox_today.Text =        COnvertDate( dataGridView1[4,e.RowIndex].Value.ToString());
            textBox_expire.Text =       COnvertDate( dataGridView1[5,e.RowIndex].Value.ToString());
            textBox_quantity.Text = dataGridView1[6,e.RowIndex].Value.ToString();
        }

        private void button_staff_load_Click(object sender, EventArgs e)
        {
            LoadStaffData();
            
        }
        private void LoadStaffData()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.DataSource = BUS_customer.ReturnAllStaff();
        }

        bool CheckStaffName(string name)
        {
            foreach(DataRow dataRow in dataGridView2.Rows)
            {
                if (dataRow["staff_name"].ToString() == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void button_staff_insert_Click(object sender, EventArgs e)
        {
            if(CheckStaffName(textBox_staff_name.Text.Trim()))
            {
                MessageBox.Show("This staff name already exist, Please try another one !", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BUS_customer.AddNewStaff(name: textBox_staff_name.Text,
                                        email:textBox_staff_email.Text,
                                        phone:textBox_staff_phone.Text,
                                        picture:comboBox_picture.SelectedItem.ToString());
            LoadStaffData();
            button_staff_new_Click(null,null);

        }

        private void comboBox_picture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_picture.SelectedIndex == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    comboBox_picture.Items.Add( openFileDialog.FileName    );
                    comboBox_picture.SelectedItem = openFileDialog.FileName;
                }
            }
        }

        private void button_staff_new_Click(object sender, EventArgs e)
        {
            textBox_staff_name.Clear(); ;
            textBox_staff_email.Clear(); ;
            textBox_staff_phone.Clear(); ;
            comboBox_picture.Text = "";
            textBox_staff_name.Focus();
        }

        private void button_staff_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("Are you sure want to delete this staff ?","Waring ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    BUS_customer.deleteStaff(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
                
        }

        private void button_delivery_laod_Click(object sender, EventArgs e)
        {
            LoadDelivery();

        }
        void LoadDelivery()
        {
            dataGridView_delivery.DataSource = null;
            dataGridView_delivery.Rows.Clear();
            dataGridView_delivery.DataSource = BUS_delivery.ReturnDatatableAllDelivery();

        }

        private void button_payment_load_Click(object sender, EventArgs e)
        {
            LoadPayments();
        }
        private void LoadPayments()
        {
            dataGridView_payment.DataSource = null;
            dataGridView_payment.Rows.Clear ();
            dataGridView_payment.DataSource = BUS_payment.ReturnDataTableAllPayments();


        }

        private void button_payment_new_Click(object sender, EventArgs e)
        {
            textBox_payment_name.Clear();
            textBox_payment_description.Clear();
                
        }

      
        private void button_delivery_load_Click_1(object sender, EventArgs e)
        {
            textBox_delivery_name.Clear();
            textBox_delivery_price.Clear();
            textBox_delivery_address.Clear();
            textBox_description.Clear();


        }

        private void button_dellivery_insert_Click(object sender, EventArgs e)
        {
            // insert
            BUS_delivery.InsertIntoDelivery(
                                                textBox_delivery_name.Text,
                                                textBox_delivery_address.Text,
                                                textBox_delivery_price.Text,
                                                textBox_description.Text);
            LoadDelivery();
        }

        private void button_delerery_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView_delivery.SelectedColumns.Count  == 1)
            {

                BUS_delivery.DeleteDElivery(dataGridView_delivery.SelectedRows[0].Cells[0].Value.ToString());
                LoadDelivery();
                return;
            }
            MessageBox.Show("You need to choose a delivery to delete !","Invalid delivery ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_payment_insert_Click(object sender, EventArgs e)
        {
            BUS_payment.InsertIntoPayment(  textBox_payment_name.Text,
                                            textBox_payment_description.Text);
        }

        private void button_payment_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView_payment.SelectedRows.Count == 1)
                {
                    BUS_payment.DeletePayment(dataGridView_payment.SelectedRows[0].Cells[0].Value.ToString());
                    LoadPayments();
                    MessageBox.Show("Delete successfully !");
                    return;
                }


            }
            catch
            {
                MessageBox.Show("Cannot delete payment is being used !","Invalid payment");
            }
        }

        private void button_payment_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button_delivery_exit_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}

