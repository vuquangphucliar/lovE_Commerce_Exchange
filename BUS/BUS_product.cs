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
    public class BUS_product
    {
        public static product[] ReturnAllProduct()
        {
            DataTable tableproduct = DAO_product.ReturnAllProducts();
            product[] products = new product[tableproduct.Rows.Count];
            int i = 0;
            foreach (DataRow row in tableproduct.Rows)
            {
                product new_product = new product(
                                                    row["product_id"].ToString(),
                                                    row["product_name"].ToString(),
                                                    row["pd_description"].ToString(),
                                                    row["price"].ToString(),
                                                    row["quantity"].ToString(),
                                                    row["pd_date"].ToString(),
                                                    row["category_id"].ToString(),
                                                    row["shop_id"].ToString(),
                                                    row["product_status"].ToString(),
                                                    row["category_name"].ToString(),
                                                    row["link"].ToString());
                products[i] = new_product;
                i++;

            }
            return products;


        }
        public static product InfoOneProduct(string product_id)
        {
            DataTable table_pro = DAO_product.ReturnInfoProduct(product_id);
            string links = "";
            foreach (DataRow row in table_pro.Rows)
            {
                links += @"#" + row["link"];

            }
            DataRow row1 = table_pro.Rows[0];
            product new_product = new product(row1["product_id"].ToString(),
                                                    row1["product_name"].ToString(),
                                                    row1["pd_description"].ToString(),
                                                    row1["price"].ToString(),
                                                    row1["quantity"].ToString(),
                                                    row1["pd_date"].ToString(),
                                                    row1["category_id"].ToString(),
                                                    row1["shop_id"].ToString(),
                                                    row1["product_status"].ToString(),
                                                    "Updating...",
                                                    links);
            return new_product;
        }
        public static category[] ReturnAllCategories()
        {
            DataTable dataTable = DAO_product.ReturnAllCategories();
            category[] categories = new category[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                categories[i++] = new category(id: row["category_id"].ToString(),
                                                name: row["category_name"].ToString());
            }
            return categories;
        }
        public static string ReturnCategoryNameWithID(string category_id)
        {
            foreach(category category in ReturnAllCategories())
            {
                if(category.id == category_id) return category.name;
            }
            return "Nothing";
        }
        public static void AddNewProduct(string product_name, string desc, string price, string quantity, string date, string category_id, string shop_id)
        {
            DAO_product.AddNewProduct(product_name,desc,price,quantity,date,category_id,shop_id);   

        }
        public static string ReturnMaxProductID()
        {
            return DAO_product.ReturnMaxProductID().Rows[0]["product_id"].ToString();

        }
        public static void AddProductImage(string product_id, string main_image_link, string link1, string link2, string link3)
        {
            DAO_product.AddProductImage(product_id,main_image_link,link1,link2,link3);

        }
        public static void UpdateProductInfo(string product_id, string product_name, string desc, string price, string quantity, string category_id)
        {
            DAO_product.UpdateProductInfo(product_id,product_name,desc,price,quantity,category_id);
        }
        public static void UpdateProductImage(string product_id, string main_image, string link1, string link2, string link3) 
        {
            DAO_product.UpdateProductImage(product_id, main_image, link1, link2, link3);

        }
        public static DataTable ReturnProductWithShopID(string shop_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnProductWithShopID '{shop_id}'");
        }
        public static void DeleteProduct(string product_id)
        {
            DAO_product.DeleteWaitingProduct(product_id);
        }
        public static bool CheckQuantity(string product_name,string quantity)
        {
            return (DAO_product.CheckQuantity(product_name,quantity).Rows.Count == 0) ? false : true;
        }
        public static void ConfirmProduct(string product_id,string staff)
        {
            DAO_product.ConfirmProduct(product_id,staff);
        }
        
    }
}
