using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public  class delivery
    {
        public string delivery_id;
        public string delivery_name;
        public string delivery_address;
        public string delivery_description;
        public string delivery_price;

        public delivery(string delivery_id, string delivery_name, string delivery_address, string delivery_description, string delivery_price)
        {
            this.delivery_id = delivery_id;
            this.delivery_name = delivery_name;
            this.delivery_address = delivery_address;
            this.delivery_description = delivery_description;
            this.delivery_price = delivery_price;
        }
    }
    
}
