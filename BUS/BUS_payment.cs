using DAO;
using DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_payment
    {
        public static payment[] ReturnAllPayments()
        {
            DataTable dataTable = DAO_payment.ReturnAllPayments();
            payment[] payments = new payment[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                payments[i++] = new payment(
                    id: row["payment_id"].ToString(),
                    name: row["payment_name"].ToString(),
                    description: row["slowgan"].ToString()
                    );
            }
            return payments;
        }
        public static DataTable ReturnDataTableAllPayments()
        {
            return DAO_payment.ReturnAllPayments();
            //payment[] payments = new payment[dataTable.Rows.Count];
        }
        public static void InsertIntoPayment(string name ,string des)
        {
            MyConnection.Instance.ExecuteQuery($"insert into payments values ('{name}','{des}')");
        }
        public static void DeletePayment(string payment)
        {
            MyConnection.Instance.ExecuteQuery($"delete from payments where payment_id = {payment}");
        }
    }
}
