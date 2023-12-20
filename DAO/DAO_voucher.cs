using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_voucher
    {
        public static DataTable ReturnAllVouchers()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnAllVouchers");
        }
        public static DataTable ReturnUserVoucher(string cus_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnUserVoucher {cus_id}");
        }
        public static void DeleteUserVoucher(string cus_id,string voucher_id)
        {
            MyConnection.Instance.ExecuteQuery($"DeleteUserVoucher {cus_id}, {voucher_id}");

        }
        public static void ClaimVoucher(string cus_id, string voucher_id)
        {
            MyConnection.Instance.ExecuteQuery($"ClaimVoucher {cus_id}, {voucher_id}");

        }
        public static void VOucherUsedByUser(string cus_id,string voucher_)
        {
            MyConnection.Instance.ExecuteQuery($"VOucherUsedByUser {cus_id}, {voucher_}");
        }
    }
}
