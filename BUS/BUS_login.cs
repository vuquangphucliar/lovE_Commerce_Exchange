using DAO;
using DLL;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BUS
{
    public static class BUS_login
    {
        public static account ReturnOneAccount(string username)
        {
            DataTable dataTable = DAO_account.ReturnOneAccount(username);
            if (dataTable.Rows.Count == 0)
            {
                return new account();
            }

            account new_account = new account(
                dataTable.Rows[0]["user_name"].ToString(),
                dataTable.Rows[0]["pass_word"].ToString(),
                dataTable.Rows[0]["remember_me"].ToString(),
                dataTable.Rows[0]["onl"].ToString(),
                dataTable.Rows[0]["login_role"].ToString()
                );
            return new_account;

        }
        public static void SetRememberMe(string user, bool check)
        {
            DAO_account.SetRememberMe(user, check);
        }
        public static account[] ReturnAllRememberLogin()
        {
            DataTable dataTable = DAO_account.ReturnAllRememberLogin();
            if (dataTable.Rows.Count == 0)
            {
                return new account[1] { new account() };
            }
            else if (dataTable.Rows.Count == 1)
            {
                account account = new account(
                    dataTable.Rows[0]["user_name"].ToString(),
                    dataTable.Rows[0]["pass_word"].ToString(),
                    dataTable.Rows[0]["onl"].ToString(),
                    dataTable.Rows[0]["remember_me"].ToString(),
                    dataTable.Rows[0]["login_role"].ToString()
                    );

                return new account[1] { account };

            }
            else
            {
                account[] accounts = new account[dataTable.Rows.Count];
                int i = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    accounts[i] = new account(
                        dataTable.Rows[i]["user_name"].ToString(),
                        dataTable.Rows[i]["pass_word"].ToString(),
                        dataTable.Rows[i]["onl"].ToString(),
                        dataTable.Rows[i]["remember_me"].ToString(),
                        dataTable.Rows[i]["login_role"].ToString()
                        );
                    i++;
                }
                return accounts;
            }


        }
        public static string SendEmailVerifyCode(string email)
        {
            DataTable emails = DAO_account.ReturnNameAndEmailLogin();
            Random random = new Random();
            string verify_code = random.Next(100000, 999999).ToString();
            foreach (DataRow account in emails.Rows)
            {
                if (account["email"].ToString() == email)
                {
                    DAO_account.SendEmailVerifyCode(email, verify_code, account["login_"].ToString());
                    break;
                }
            }
            return verify_code;
        }
        public static string SendMailSignUp(string email)
        {
            //DataTable emails = DAO_account.ReturnNameAndEmailLogin();
            Random random = new Random();
            string verify_code = random.Next(100000, 999999).ToString();
            DAO_account.SendEmailSignUp(email, verify_code);
            return verify_code;
        }
        
        public static bool EmailChecking(string email)
        {
            DataTable emails = DAO_account.ReturnNameAndEmailLogin();
            foreach (DataRow row in emails.Rows)
            {
                if (row["email"].ToString() == email)
                {
                    return true;
                }
            }
            return false;
        }
        public static void ResetPassword(string user, string password)
        {
            DAO_account.ResetPassword(user, password);

        }
        public static string ReturnUsernameByEmail(string email)
        {
            DataTable emails = DAO_account.ReturnNameAndEmailLogin();
            foreach (DataRow row in emails.Rows)
            {
                if (row["email"].ToString() == email)
                {
                    return row["login_"].ToString();
                }
            }
            return "unknown";
        }

        public static customer[] ReturnAllLogin()
        {
            DataTable emails = DAO_account.ReturnNameAndEmailLogin();
            customer[] customers = new customer[emails.Rows.Count];
            int i = 0;
            foreach (DataRow row in emails.Rows)
            {
                customers[i] = new customer(
                    row["login_"].ToString(),
                    row["email"].ToString()
                    );
                i++;
            }
            return customers;
        }
        public static void SetLoginStatus(string user, string status)
        {
            DAO_account.SetLoginStatus(user, status);

        }
        public static void InsertNewLogin(string username, string password)
        {
            DAO_account.InsertNewLogin(username, password);
        }
        public static int InsertNewAccount(string name, string gender,string email)
        {
            return DAO_account.InsertNewAccount(name, gender, email);
        }
       

    }
}
