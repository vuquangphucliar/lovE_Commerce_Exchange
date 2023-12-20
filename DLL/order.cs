using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class order
    {
        public string order_id;
        public string order_name;
        public string order_date;
        public string total_amount;// total cost
        public string voucher_id;
        public string delivery_id;
        public string payment_id;
        public bool order_state;
        public product[] products;

        public order(string order_id, string order_name, string order_date, string total_amount, string voucher_id, string delivery_id, string payment_id, bool order_state, product[] products)
        {
            this.order_id = order_id;
            this.order_name = order_name;
            this.order_date = order_date;
            this.total_amount = total_amount;
            this.voucher_id = voucher_id;
            this.delivery_id = delivery_id;
            this.payment_id = payment_id;
            this.order_state = order_state;
            this.products = products;
        }
    }
}
