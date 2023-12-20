using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using BUS;
using DAO;

namespace lovE_Commerce_Exchange
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //test form
            //Application.Run(new frm_admin());
            MyConnection.Instance.GetSeverName();



            ////real process
            frm_login frm_Login = new frm_login();
            frm_Login.ShowDialog();


            // Admin login
            //username : staff_admin
            //password : admin
            if (frm_Login.UserSuccessFullyAuthenticated && frm_Login.current_account is null)
            {
                Application.Run(new frm_admin());
            }

            // Staff log in
            else if (frm_Login.UserSuccessFullyAuthenticated && frm_Login.staff)
            {
                Application.Run(new frm_staff(frm_Login.current_account));
            }

            // Customer Log in
            else if (frm_Login.UserSuccessFullyAuthenticated)
            {
                Application.Run(new frm_home(frm_Login.current_account));
            }
        }
    }
}
