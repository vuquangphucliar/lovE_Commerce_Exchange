using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DLL;

namespace BUS
{
    public class BUS_customer
    {
        public static customer ReturnOneCustomer(string user)
        {
            DataTable dataTable = DAO_account.ReturnOneCustomer(user);
            if(dataTable.Rows.Count == 0)
            {
                return new customer();
            }
            
            return new customer(
                (int)dataTable.Rows[0]["customer_id"],
                dataTable.Rows[0]["custormer_name"].ToString(),
                dataTable.Rows[0]["gender"].ToString(),
                dataTable.Rows[0]["customer_email"].ToString(),
                dataTable.Rows[0]["phone_number"].ToString(),
                dataTable.Rows[0]["picture"].ToString()
                );

        }
        public static customer[] ReturnAllCustomer()
        {
            DataTable dataTable = DAO_account.ReturnAllCustomer();
            customer[] customers = new customer[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                customers[i] = new customer(
                (int)row["customer_id"],
                row["custormer_name"].ToString(),
                row["gender"].ToString(),
                row["customer_email"].ToString(),
                row["phone_number"].ToString(),
                row["picture"].ToString()
                );
                i++;

            }
            return customers;
        }
        public static void UpdateAvatar(string user, string avatar)
        {
            DAO_account.UpdateAvatar(user, avatar);
        }
        public static void UpdatePhoneNumber(string user, string phone)
        {
            DAO_account.UpdatePhoneNumber(user, phone);
        }




        public static DataTable ReturnAllStaff()
        {
            return MyConnection.Instance.ExecuteDataTable("select * from staffs");
        }
        public static void AddNewStaff(string name,string email,string phone,string picture)
        {
            MyConnection.Instance.ExecuteQuery($"AddNewStaff '{name}','{email}','{phone}','{picture}'");

        }
        public static void deleteStaff(string id)
        {
            MyConnection.Instance.ExecuteQuery($"deleteStaff {id}");

        }

    }
}
