using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_setting : Form
    {
        private static string username;
        public frm_setting(string user)
        {
            username = user;
            InitializeComponent();
        }
        

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/troi2004day/");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            bool check;
            if (comboBox_remember.SelectedItem.ToString() == "Yes")
            {
                check = true;
            }
            else
            {
                check = false;
            }
            BUS_login.SetRememberMe(username,check);
            //BUS_login.SetRememberMe(username, rememberme);
            Dispose();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void comboBox_language_SelectedValueChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void comboBox_noti_SelectedValueChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }

        private void comboBox_remember_SelectedValueChanged(object sender, EventArgs e)
        {
            button_save.Enabled = true;
        }
    }
}
