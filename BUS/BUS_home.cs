using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DLL;

namespace BUS
{
    public class BUS_home
    {
        public static  BUS_home Instance { get; set; }


        public static product[] ReturnAllProduct()
        {
            DataTable tableproduct =  DAO_product.ReturnAllProducts();
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
        public static product InfoOneProduct(product pro)
        {
            DataTable table_pro = DAO_product.ReturnInfoProduct(pro.product_id);
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
                                                    pro.product_type,
                                                    links);
                return new_product;
        }
        public static string ConvertPrice(string price)
        {
            int amount = int.Parse(price);
            return (amount / 1.0).ToString("#,###") + " VND";

        }
        public static int quantity_checking(int max,int value_, bool plus)
        {
            //int value_ = int.Parse(value);

            if (value_
                <= 1)
            {
                return 1;
            }
            else if (value_ >= max)
            {
                return max;
            }
            else if (plus)
            {
                return value_++;
            }
            else
            {
                return value_--;
            }

        }

        public static product[] CategoryFilter(product[] products, string category)
        {
            if (category == "All products")
            {
                return products;
            }
            List<product> result = new List<product>();
            foreach (product product in products)
            {
                
                if (product.product_type == category)
                {
                    result.Add(product);

                }
            }
            return result.ToArray();
       
        }
        public static product[] ProductNameFilter(product[] products,string name)
        {
            if(name == "" || name  == "All products")
            {
                return products;
            }
            List<product> result = new List<product>();
            foreach(product product in products)
            {
                if(product.name.Contains(name))
                {
                    result.Add(product);
                }
            }
            return (result.ToArray());

        }
        public static string ReturnCategoryName(string category)
        {
            DataTable data = DAO_product.ReturnCategoryName(category);
            return data.Rows[0]["category_name"].ToString();
        }
        public static string ReturnShopName(string shop_id)
        {
            DataTable data = DAO_product.ReturnShopName(shop_id);
            return data.Rows[0]["name_shop"].ToString();
        }
        public static void StartNewProcess(Form form,account account)
        {
            if (MessageBox.Show("Do you wanna log out !", "Logged out ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
                form.Dispose();
                BUS_login.SetLoginStatus(account.username, "0");
                Process proc = new Process();
                proc.StartInfo.FileName = Application.StartupPath + "\\lovE_Commerce_Exchange.exe";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc.Start();
            }
        }

    }
}
