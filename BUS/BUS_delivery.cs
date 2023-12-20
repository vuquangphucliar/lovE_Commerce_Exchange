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
    public  class BUS_delivery
    {
        public static delivery[] ReturnAllDelivery()
        {
            DataTable dataTable = DAO_delivery.ReturnAllDelivery();
            delivery[] deliveries = new delivery[dataTable.Rows.Count];
            int i = 0; ;
            foreach (DataRow row in dataTable.Rows)
            {
                deliveries[i++] = new delivery(
                    delivery_id: row["delivery_id"].ToString(),
                    delivery_name: row["delivery_name"].ToString(),
                    delivery_address: row["delivery_address"].ToString(),
                    delivery_description: row["slowgan"].ToString(),
                    delivery_price: row["price"].ToString()

                    );
            }
            return deliveries;
        }
        public static DataTable ReturnDatatableAllDelivery()
        {
                  return DAO_delivery.ReturnAllDelivery(); ;
        }
        public static void InsertIntoDelivery(string name,string address,string price,string  des)
        {
            DAO_delivery.InsertIntoDelivery(name,address,price,des);

        }
        public static void DeleteDElivery(string id)
        {

            MyConnection.Instance.ExecuteQuery($"delete from deliveries where delivery_id = {id}");
        }
    }
}
