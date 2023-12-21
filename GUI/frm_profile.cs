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
    public partial class frm_profile : Form
    {
        private customer current_customer ;
        private bool changemade = false ;
        private string image;
        private bool successful= false ;
        public frm_profile(string customer_name)
        {
            current_customer = BUS_customer.ReturnOneCustomer(customer_name);
            InitializeComponent();
            
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            if(@current_customer.image == "")
            {
                pictureBox_avatar.Image = Properties.Resources.Icons8_Windows_8_Users_Guest_24;

            }
            else
            {                         
                try
                {
                    pictureBox_avatar.Image = new Bitmap(@current_customer.image);

                }
                catch
                {
                    pictureBox_avatar.Image = Properties.Resources.Icons8_Windows_8_Users_Guest_24;
                }
            }
            //string role = (current_customer.gender == "0") ? "User : " : "Staff : ";
            label_user_name.Text = "User : " + current_customer.name;
            textBox_email.Text = current_customer.email;
            textBox_phone_number.Text = current_customer.phone;
            textBox_user_name.Text = current_customer.name;
            pictureBox_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            comboBox_gender.Text = (current_customer.gender == "0") ? "Female" : "Male";
            image = current_customer.image;
            //textBox_phone_number

        }

        private void button_change_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                changemade = true;
                pictureBox_avatar.Image = new Bitmap(@openFileDialog.FileName);
                image = @openFileDialog.FileName;
            }
        }

        private void frm_profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check change
            if(!changemade)
            {
                return;
            }
            if (MessageBox.Show("Do you want to save changes", "lovE COmmerce Exchange", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // update image
                if (textBox_phone_number.Text.Length != 10)
                {
                    MessageBox.Show("The phone number lenght should be 10 digits !", " Invalid phone number !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    //return;
                }
                else
                {
                    successful = true;
                    BUS_customer.UpdateAvatar(current_customer.name, image);
                    BUS_customer.UpdatePhoneNumber(current_customer.name, textBox_phone_number.Text);

                }
            }
  
        }

        private void textBox_phone_number_TextChanged(object sender, EventArgs e)
        {
            if(textBox_phone_number.Text != current_customer.phone)
            {
                changemade = true;
            }
            else
            {
                changemade = false;
            }
            
        }

        private void frm_profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (successful)
            {
                MessageBox.Show("Re log in to see the changes !", "lovE COmmerce Exchange", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
