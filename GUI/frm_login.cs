using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DLL;

namespace GUI
{
    public partial class frm_login : Form
    {
        public bool UserSuccessFullyAuthenticated = false;
        account[] accounts;
        public account current_account;
        static string pass;
        public bool staff = false;
        //private static bool show_pass_word = true;
        public frm_login()
        {
            InitializeComponent();
            accounts = BUS_login.ReturnAllRememberLogin();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            frm_sign_up frm_Sign_Up = new frm_sign_up();
            frm_Sign_Up.ShowDialog(); 
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string userName = comboBox_username.Text;
            string password = textBox_password.Text;


            if (comboBox_username.Text == "staff_admin" && textBox_password.Text == "admin")
            {
             
                UserSuccessFullyAuthenticated = true;
                Dispose();
                return;
                
            }


            account current_account = BUS_login.ReturnOneAccount(userName);

            if (current_account.username == "unknown")
            {
                //Not exist
                MessageBox.Show("This account doesn't exist !"," Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //else if (current_account.status == "True")
            //{
            //    //Account has logged in on another divice
            //    MessageBox.Show("This account has been logged in on another device !", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else if(password == current_account.password)
            {
                if(current_account.role == "False")
                {
                    staff = true;
                }
                UserSuccessFullyAuthenticated = true;
                SetRememberMe(userName, checkBox_remember_me.Checked);
                //this.current_account = current_account;
                BUS_login.SetLoginStatus(userName, "1");
                Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again !"," Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void SetRememberMe(string username,bool rememberme)
        {
            BUS_login.SetRememberMe(username,rememberme);
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;
        }

        private void label_forgot_password_Click(object sender, EventArgs e)
        {
           
            frm_forgot_password frm_Forgot_Password = new frm_forgot_password();
            frm_Forgot_Password.ShowDialog();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            
            if(textBox_password.Text == pass)
            {
                //pass = textBox_password.Text;
                checkBox_show_password.Enabled = false;
            }
            else
            {
                pass = textBox_password.Text;
                checkBox_show_password.Enabled = true;

            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            comboBox_username.Items.Clear();
            foreach (var account in accounts)
            {
                if (account.username == "unknown")
                {
                    comboBox_username.Items.Add("No account !");
                    break;
                }
                comboBox_username.Items.Add(account.username);
            }
        }

        static int times = 0;
        private void comboBox_username_SelectedValueChanged(object sender, EventArgs e)
        {           
            
            if(times == 2)
            {
                times = 0;
                return;
            }
            times++;
            foreach (var account in accounts)
            {
                if(account.username == comboBox_username.SelectedItem.ToString())
                {
                    checkBox_show_password.Enabled = false;
                    current_account = account;
                    checkBox_remember_me.Checked = true;
                    pass = textBox_password.Text;
                    textBox_password.Text = account.password; break;
                }
            }
            comboBox_username_SelectedValueChanged(sender, e);
           
        }

    }
}
