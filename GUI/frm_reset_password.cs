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
    public partial class frm_reset_password : Form
    {
        private account account;
        private bool changed = false;
        public frm_reset_password(account account)
        {
            
            this.account = account;
            InitializeComponent();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if(account.password == textBox_password.Text)
            {
                if(textBox_new_password.Text == textBox_confirm_password.Text)
                {
                    if(textBox_confirm_password.Text.Length > 6 && textBox_confirm_password.Text.Length < 20)
                    {
                        if(MessageBox.Show("Are you sure !\nYour password'll be changed now ! ","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            changed = true;
                          BUS_login.ResetPassword(account.username, textBox_confirm_password.Text);
                        Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password must has at least 6 characters and less than 20 characters!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show("Your password's not match with the re-password,\n" +
                        "Please, try again !","Oops !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password\nPlesae, try again !", "Error !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frm_reset_password_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (changed)
            {
            MessageBox.Show("Your password has been changed successfully !","Password changed !",MessageBoxButtons.OK,MessageBoxIcon.Question);

            }
        }
    }
}
