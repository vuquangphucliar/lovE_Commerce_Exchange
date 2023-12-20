using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_shop
    {
        public static DataTable ReturnOneShop(string shop_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnOneShop '{shop_id}'");
        }
        public static DataTable ReturnAllShops()
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnAllShops");
        }
        public static DataTable ReturnShoppingCart(string cus_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnShoppingCart {cus_id}");

        }
        public static void AddToCart(string cus_id,string pro_id)
        {
            MyConnection.Instance.ExecuteQuery($"AddToCart {cus_id}, {pro_id}");
        }
        public static DataTable ReturnAllCart()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnAllCart");
        }
        public static void RemoveProductCart(string cus_id,string pro_id)
        {
            MyConnection.Instance.ExecuteQuery($"RemoveProductCart '{cus_id}', '{pro_id}'");

        }
        public static void ShopRegister(string name,string desc, string address,string phone,string owner)
        {
            MyConnection.Instance.ExecuteQuery($"ShopRegister '{name}','{desc}','{address}','{phone}','{owner}'");
        }
        


        public static void AddOrder(string cus_id,string date,string total,string voucher_id,string delivery_id,string payment,string status) 
        {
            MyConnection.Instance.ExecuteQuery($"AddOrder {cus_id},'{date}',{total},{voucher_id},{delivery_id},{payment},{status}");

        }
        public static void AddOrderDetail(string order_id,string product_id,string quantity,string state)
        {
            MyConnection.Instance.ExecuteQuery($"AddOrderDetails {order_id},{product_id},{quantity},{state}");

        }
        public static DataTable ReturnLastOrderID()
        {
             return MyConnection.Instance.ExecuteDataTable("ReturnLastOrderID");
            
        }
        public static DataTable ReturnOrderConfirm(string shop_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnOrderConfirm {shop_id}");
        }
    }
}
