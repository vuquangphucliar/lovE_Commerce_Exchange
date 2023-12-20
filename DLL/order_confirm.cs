using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class order_confirm
    {
        public string order_id;
        public string name;
        public string customer_id;
        public string quantity;
        public string price;
        public string order_status;
        public string  order_detail_id;

        public order_confirm(string order_id,string name, string customer_id,string quantity,string price,string order_status,string order_detail_id)
        {
            this.name = name;
            this.order_id = order_id;
            this.customer_id = customer_id;
            this.quantity = quantity;
            this.price = price;
            this.order_status = order_status;
            this.order_detail_id = order_detail_id;


        }


    }
}
