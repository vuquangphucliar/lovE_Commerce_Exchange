using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_forgot_password : Form
    {
        public frm_forgot_password()
        {
            InitializeComponent();
        }
        private void label_go_back_login_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void button_send_me_code_Click(object sender, EventArgs e)
        {
            bool valid = BUS_login.EmailChecking(textBox_email.Text);
            if (valid)
            {
                string verfycode = BUS_login.SendEmailVerifyCode(textBox_email.Text);
                string username = BUS_login.ReturnUsernameByEmail(textBox_email.Text);
                frm_verify_code frm_Verify_Code = new frm_verify_code(username,verfycode); ;
                frm_Verify_Code.ShowDialog();
            }
            else
            {
                MessageBox.Show("Couldn't find your email address !", "Incorrect email address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Noo usage
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
