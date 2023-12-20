using BUS;
using DLL;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_sign_up : Form
    {
        private customer[] customers;
        public frm_sign_up()
        {
            customers = BUS_login.ReturnAllLogin();
            InitializeComponent();
        }

        private void label_back_to_login_Click(object sender, EventArgs e)
        {
            Dispose();
            //MessageBox.Show("hey there");
        }

        private void checkBox_terms_of_use_CheckedChanged(object sender, EventArgs e)
        {
            button_sign_up.Enabled = !button_sign_up.Enabled;
        }

        private bool EmailChecking(string email)
        {

            foreach (var customer in customers)
            {
                if (customer.email == email)
                {
                    return true;
                }
            }

            return false;

        }

        private bool UserNameChecking(string username)
        {

            foreach (var customer in customers)
            {
                if (customer.name == username)
                {
                    return true;
                }
            }
            return false;

        }

        private void button_sign_up_Click(object sender, EventArgs e)
        {

            //--------------------------------------------------------------
            if (BUS_signup.EmailFormatChecking(textBox_email.Text))
            {
                MessageBox.Show("Invalid email, Please check your email again !","Opps !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             if (EmailChecking(textBox_email.Text))
            {
                MessageBox.Show("This email's already used by our customer !\n" +
                                "Please try again with another email.","Oops",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
             //---------------------------------------------------------------
            if (BUS_signup.UserNameFormatChecking(textBox_user_name.Text))
            {
                MessageBox.Show(" \nUsername length must at least 6 characters !", "Opps, Invalid username, !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BUS_signup.PasswordChecking(textBox_user_name.Text))
            {
                MessageBox.Show("Please try again, \n Your Username length's more than 15 !", "Opps, Invalid username, !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserNameChecking(textBox_user_name.Text))
            {
                MessageBox.Show("A user with this username already exists !\n" +
                                "Please try again.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //---------------------------------------------------------------
            if (!BUS_signup.RePasswordChecking(textBox_password.Text, textBox_re_password.Text))
            {
                label_warning.Text = "The password you entered is incorrect\n." +
                    "Please try again ";
                return;
            }
            if (BUS_signup.PasswordFormatChecking(textBox_password.Text))
            {
                MessageBox.Show(" \nPassword length must at least 6 characters !", "Opps, Invalid username, !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (BUS_signup.PasswordChecking(textBox_re_password.Text))
            {
                label_warning.Text = "Your password length's more than 15 !";
                return;
            }

            //---------------------------------------------------------------
            //sign up combine with verifycode checking;

            string verifycode = BUS_login.SendMailSignUp(textBox_email.Text);
            //string verifycode = "000000";

            frm_verify_code frm_Verify_Code = new frm_verify_code("sign_up",verifycode,"Congratulations !\n" +
                                                        "Go back to log in and explore your exprerience. ");
            frm_Verify_Code.ShowDialog();

            if (frm_Verify_Code.validation)
            {
                BUS_login.InsertNewLogin(textBox_user_name.Text, textBox_re_password.Text);
                if (BUS_login.InsertNewAccount(name: textBox_user_name.Text,email: textBox_email.Text,gender: Gender()) == 0)
                {
                    MessageBox.Show("Oops !");
                }
                else
                {
                    MessageBox.Show("Account updated !");
                }
            }
            Dispose();
        }

        private string Gender()
        {
            if (radioButton_female.Checked)
            {
                return "1";
            }
            else 
            {
                return "0";
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            label_warning.Text = "";
        }
    }
}
