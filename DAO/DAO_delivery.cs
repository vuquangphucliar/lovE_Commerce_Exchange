using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_delivery
    {
        public static DataTable ReturnAllDelivery()
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnAllDelivery");
        }

        public static void InsertIntoDelivery(string name,string address,string price,string des)
        {
            MyConnection.Instance.ExecuteQuery($"insert into deliveries values ('{name}','{address}',{price},'{des}') ");
        }
    }
}
