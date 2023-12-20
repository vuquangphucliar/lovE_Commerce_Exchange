using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_statistic
    {
        public static DataTable StatisticQuantitySoldProductsByShopID(string shop_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"StatisticQuantitySoldProductsByShopID {shop_id}");
        }
        public static DataTable Bought_product(string customer_id)
        {
            return MyConnection.Instance.ExecuteDataTable($"Bought_product {customer_id}");

        }
    }
}
