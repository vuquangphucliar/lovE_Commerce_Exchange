using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DAO
{
    public class DAO_account
    {
        private DAO_account() { }
        private static DAO_account instance;

        public static DAO_account Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_account();
                }
                return instance;
            }
        }
        public static DataTable ReturnAllAccount()
        {

            return MyConnection.Instance.ExecuteDataTable("ReturnAllAccount");

        }
        public static DataTable ReturnOneAccount(string username)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnOneAccount '{username}'");
        }
        public static void SetRememberMe(string user, bool remember)
        {
            if (remember)
            {
                MyConnection.Instance.ExecuteQuery($"exec SetRememberMe '{user}', 1");
            }
            else
            {
                MyConnection.Instance.ExecuteQuery($"exec SetRememberMe '{user}', 0");

            }
        }
        public static DataTable ReturnAllRememberLogin()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnALLRemeberLogin"); ;
        }
        public static void SendEmailVerifyCode(string email, string verifycode, string user)
        {
            MyConnection.Instance.ExecuteQuery($"exec mail_forget_password '{email}','{verifycode}', '{user}'");
        }
        public static DataTable ReturnNameAndEmailLogin()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnNameAndEmailLogin");
        }
        public static void ResetPassword(string user, string password)
        {
            MyConnection.Instance.ExecuteQuery($"ResetPassword '{user}', '{password}'");
        }
        public static void SetLoginStatus(string username, string status)
        {
            MyConnection.Instance.ExecuteQuery($"SetLoginStatus '{username}', {status}");
        }
        public static void InsertNewLogin(string username, string password)
        {
            MyConnection.Instance.ExecuteQuery($"InsertNewLogin '{username}', '{password}'");
        }
        public static int InsertNewAccount(string username, string gender, string email)
        {
            return MyConnection.Instance.ExecuteNonQuery($"exec InsertNewAccount '{username}', {gender}, '" + email + "' ");
            //exec[InsertNewAccount] 'tran_anh_tan',0,'trananhtan@gmail.com'

        }
        public static void SendEmailSignUp(string email, string verifycode)
        {
            MyConnection.Instance.ExecuteQuery($"exec mail_sign_up '{email}', '{verifycode}'");
        }
        public static DataTable ReturnAllCustomer()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnAllCustomer");

        }
        public static DataTable ReturnOneCustomer(string user)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnOneCustomer '{user}'");

        }
        public static void UpdateAvatar(string user, string avatar)
        {
            MyConnection.Instance.ExecuteQuery($"UpdateAvatar '{user}', '{avatar}'");

        }
        public static void UpdatePhoneNumber(string user, string phone)
        {
            MyConnection.Instance.ExecuteQuery($"UpdatePhoneNumber '{user}', '{phone}'");

        }

     

    }
}
