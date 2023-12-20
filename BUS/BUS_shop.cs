using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using DAO;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_shop
    {
        public  static shop ReturnOneShop(string shop_id)
        {
            DataTable dataTable = DAO_shop.ReturnOneShop(shop_id);
            return new shop(
            id: dataTable.Rows[0]["shop_id"].ToString()   ,
            name: dataTable.Rows[0]["name_shop"].ToString(),
            description: dataTable.Rows[0]["shop_description"].ToString() ,
            address: dataTable.Rows[0]["shop_address"].ToString()  ,
            phone: dataTable.Rows[0]["phone_number"].ToString()  ,
            owner: dataTable.Rows[0]["owner_id"].ToString()
            );
        }
        public static shop[] ReturnAllShops()
        {
            DataTable dataTable = DAO_shop.ReturnAllShops();
            shop[] shops = new shop[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                shops[i++] = new shop(
                                id: row["shop_id"].ToString(),
                                name: row["name_shop"].ToString(),
                                description: row["shop_description"].ToString(),
                                address: row["shop_address"].ToString(),
                                phone: row["phone_number"].ToString(),
                                owner: row["owner_id"].ToString()
                                );
            }
            return shops;

        }
        public static product[] ReturnShoppingCart(string cus_id)
        {
            DataTable dataTable = DAO_shop.ReturnShoppingCart( cus_id );
            product[] products = new product[dataTable.Rows.Count];
            int i = 0;
            foreach(DataRow row in dataTable.Rows)
            {
                products[i++] = BUS_product.InfoOneProduct(row["pro_id"].ToString());
            }
            return products;
        }
        public static void AddToCart(string cus_id,string pro_id)
        {
            DAO_shop.AddToCart( cus_id, pro_id );

        }
        public static bool CheckCart(string cus_id,string pro_id)
        {
            DataTable dataTable = DAO_shop.ReturnAllCart();
            foreach(DataRow row in dataTable.Rows)
            {
                if (row["customer_id"].ToString() == cus_id && row["product_id"].ToString() == pro_id)
                {
                    return true;
                }
            }
            return false;
        }
        public static void RemoveProductCart(string cus_id,string pro_)
        {
            DAO_shop.RemoveProductCart(cus_id,pro_);
        }
        public static shop ReturnShopWithShopOwnerID(string cus_id)
        {
            DataTable shops = DAO_shop.ReturnAllShops();
            foreach(DataRow row in shops.Rows)
            {
                if (row["owner_id"].ToString().Equals(cus_id))
                {
                    return new shop(
                        id: row["shop_id"].ToString(),
                        name: row["name_shop"].ToString(),
                        description: row["shop_description"].ToString(),
                        address: row["shop_address"].ToString(),
                        phone: row["phone_number"].ToString(),
                        owner: row["owner_id"].ToString()
                        );
                }
            }
          
            return new shop();

        }
        public static product[] ReturnAllShopProducts(string shop_id)
        {
            DataTable datatable = BUS_product.ReturnProductWithShopID(shop_id);
            product[]  products = new product[datatable.Rows.Count];
            int i = 0;
            foreach(DataRow row1 in datatable.Rows)
            {
                products[i++] = new product(row1["product_id"].ToString(),
                                                    row1["product_name"].ToString(),
                                                    row1["pd_description"].ToString(),
                                                    row1["price"].ToString(),
                                                    row1["quantity"].ToString(),
                                                    row1["pd_date"].ToString(),
                                                    row1["category_id"].ToString(),
                                                    row1["shop_id"].ToString(),
                                                    row1["product_status"].ToString(),
                                                    "Unknown", main_image: "No need");
            }
            return products;
        }

        public static void ShopRegister(string name, string desc, string address, string phone, string owner)
        {
            DAO_shop.ShopRegister(name, desc, address, phone, owner);   
            //MyConnection.Instance.ExecuteQuery(/$"ShopRegister {name},{desc},{address},{phone},{owner}");
        }
        public static void AddOrder(string cus_id, string date, string total, string voucher_id, string delivery_id, string payment, string status)
        {
            DAO_shop.AddOrder(cus_id, date, total, voucher_id, delivery_id, payment, status);
        }
        public static void AddOrderDetail(string order_id, string product_id, string quantity, string state)
        {
            DAO_shop.AddOrderDetail(order_id, product_id, quantity, state);

        }
        public static string ReturnLastOrderID()
        {
            return DAO_shop.ReturnLastOrderID().Rows[0]["order_id"].ToString();
        }
        public static order_confirm[] ReturnOrderConfirm(string shop_id)
        {
            DataTable dataTable = DAO_shop.ReturnOrderConfirm(shop_id);
            order_confirm[] order_Confirms = new order_confirm[dataTable.Rows.Count];
            int i = 0;
            foreach(DataRow row in dataTable.Rows)
            {
                order_Confirms[i++] = new order_confirm(name: row["product_name"].ToString(),
                                                    order_id: row["order_id"].ToString(),
                                                    customer_id: row["customer_id"].ToString(),
                                                    quantity: row["quantity"].ToString(),
                                                    price: row["price"].ToString(),
                                                    order_status: row["order_status"].ToString(),
                                                    order_detail_id: row["order_detail_id"].ToString());
            }
            return order_Confirms;
        }
       




        public static string ReturnShopName(string shop_id)
        {
            DataTable dataTable = DAO_product.ReturnShopName(shop_id);
            return dataTable.Rows[0]["name_shop"].ToString().Trim();
        }



        public static void UpdateOrderConfirm(string order_id,string order_detail_id)
        {
            MyConnection.Instance.ExecuteQuery($"SetAcceptConfirmOrder {order_id}, {order_detail_id}");
        }
        public static void DeleteOrderDetail(string order_id,string order_detail_id)
        {
            MyConnection.Instance.ExecuteQuery($"DeleteOrderDetail {order_id}, {order_detail_id}");
        }


    }

}
