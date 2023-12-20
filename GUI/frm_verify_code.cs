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
    public partial class frm_verify_code : Form
    {
        static string code;
        private static string username;
        private static string notificaton;
        public bool validation;
        public frm_verify_code(string username_= "unkown",string verifycode = "000001",string noti = "This code now become the password of this email's account\n" +
                                "You can using it to log in your account now,\n" +
                                "And make sure that you change your password immediately.")
        {
            username = username_;
            code = verifycode;
            notificaton = noti;
            validation = false;
            InitializeComponent();
        }

        private void button_verify_Click(object sender, EventArgs e)
        {
            if (maskedTextBox_verify_code.Text == code)
            {
                if (username != "sign_up")
                {
                    BUS_login.ResetPassword(username, code);
                }
                validation = true;
                MessageBox.Show($"Welcome, {username}\n"+notificaton,"Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Dispose();
            }                                       
            else
            {
                MessageBox.Show("Incorrect Code !\n" +
                                "Try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label_back_to_login_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labe_timer.Text = (int.Parse(labe_timer.Text) - 1).ToString();

            if(labe_timer.Text == "0")
            {
                MessageBox.Show("Please, re sign up and try again    !","Time out",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Dispose(true);
            }
        }
    }
}
