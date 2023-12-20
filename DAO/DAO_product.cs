using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_product
    {
        public DAO_product() { }

        public static DataTable ReturnAllProducts()
        {
            return MyConnection.Instance.ExecuteDataTable("AllInfoProduct");
        }
        public static DataTable ReturnInfoProduct(string id)
        {
            return MyConnection.Instance.ExecuteDataTable($"InfoOneProduct '{id}'");

        }        
        public static DataTable ReturnCategoryName(string id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnCategoryName '{id}'");
        }
        public static DataTable ReturnShopName(string id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnShopName '{id}'");
        }
        public static DataTable ReturnAllCategories()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnAllCategories");

        }
        public static void AddNewProduct(string product_name,string desc,string price,string quantity,string date,string category_id,string shop_id)
        {
            MyConnection.Instance.ExecuteQuery($"AddNewProduct '{product_name}','{desc}','{price}','{quantity}','{date}','{category_id}','{shop_id}'");

        }
        public static void AddProductImage(string product_id,string main_image_link, string link1,string link2,string link3)
        {
            MyConnection.Instance.ExecuteQuery($"AddMainProductImage '{product_id}','{main_image_link}'" );
            MyConnection.Instance.ExecuteQuery($"AddProductImage '{product_id}','{link1}','{link2}','{link3}'");
        }
        public static DataTable ReturnMaxProductID()
        {
            return MyConnection.Instance.ExecuteDataTable("ReturnMaxProductID") ;
        }
        public static void UpdateProductInfo(string product_id,string product_name,string desc,string   price,string quantity,string category_id)
        {
            MyConnection.Instance.ExecuteQuery($"UpdateProductInfo '{product_id}','{product_name}','{desc}','{price}','{quantity}','{category_id}'");
        }
        public static void UpdateProductImage(string product_id,string main_image, string link1, string link2, string link3)
        {
            MyConnection.Instance.ExecuteQuery($"UpdateMainProductImage '{product_id}','{main_image}'");

            MyConnection.Instance.ExecuteQuery($"UpdateProductImage '{product_id}','{link1}','{link2}','{link3}'");

        }
        public static void DeleteWaitingProduct(string product_id)
        {
            MyConnection.Instance.ExecuteQuery($"DeleteWaitingProduct {product_id}");
        }
        public static DataTable CheckQuantity(string product_id,string quantity)
        {
            return MyConnection.Instance.ExecuteDataTable($"CheckQuantity '{product_id}',{quantity}");

        }
        public static void ConfirmProduct(string product_id,string staff)
        {
            MyConnection.Instance.ExecuteQuery($"COnfirmProduct {product_id}, {staff}");
        }
        
    }
}
