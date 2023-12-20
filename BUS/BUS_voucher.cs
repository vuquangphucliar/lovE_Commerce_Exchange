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
    public class BUS_voucher
    {
        public static voucher[] ReturnAllVouchers()
        {
            DataTable dataTable = DAO_voucher.ReturnAllVouchers();
            voucher[] vouchers = new voucher[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                vouchers[i++] = new voucher(
                    id: int.Parse(row["voucher_id"].ToString()),
                    name: row["voucher_name"].ToString(),
                    description: "Voucher desription" ,
                    discount: row["discount"].ToString(),
                    expire: row["date_expire"].ToString(),
                    active: row["date_active"].ToString(),
                    quantity: row["quantity"].ToString(),
                    code: row["voucher_code"].ToString()
                    );
            }
            return vouchers;
        }
        public static voucher[] ReturnUserVouchers(string cus_id)
        {
            DataTable dataTable = DAO_voucher.ReturnUserVoucher(cus_id);
            voucher[] vouchers = new voucher[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {

                vouchers[i++] = new voucher(
                    id: int.Parse(row["voucher_id"].ToString()),
                    name: row["voucher_name"].ToString(),
                    description: row["used"].ToString(),
                    discount: row["discount"].ToString(),
                    expire: row["date_expire"].ToString(),
                    active: row["date_active"].ToString(),
                    quantity: row["quantity"].ToString(),
                    code: row["voucher_code"].ToString()
                    );
            }
            return vouchers;
        }
        public static void DeleteUserVoucher(string cus_id,string voucher_id)
        {
            DAO_voucher.DeleteUserVoucher(cus_id,voucher_id);

        }
        public static void ClaimVoucher(string cus_id, string voucher_id)
        {
            DAO_voucher.ClaimVoucher(cus_id, voucher_id);

        }
        public static DataTable AllVoucher()
        {
           return  MyConnection.Instance.ExecuteDataTable("select * from vouchers\r\n");
        }
        public static void InsertIntoVOucher(string name, string code,string discount, string today,string expire,string quanity)
        {
            MyConnection.Instance.ExecuteQuery($"InsertIntoVocuhcer '{name}','{code}',{discount},'{today}','{expire}','{quanity}'");
        }
        public static void DeleteVOucher(string voucher_id)
        {
            MyConnection.Instance.ExecuteQuery($"DeleteVOucher {voucher_id}");
        }
    }
}
