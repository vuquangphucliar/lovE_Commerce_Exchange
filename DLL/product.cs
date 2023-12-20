using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class product
    {
        public string product_id;
        public string name;
        public string description;
        public string price;
        public string quantity;
        public string product_date;
        public string category_id;
        public string shop_id;
        public string product_status;
        public string product_type;
        public string main_image;


        public product(
            string product_id,
            string name,
            string description, 
            string price, 
            string quantity,
            string product_date, 
            string category_id,
            string shop_id, 
            string product_status,
            string product_type,
            string main_image
)
        {

            this.name = name;
            this.description = description;
            this.product_id = product_id;
            this.price = price;
            this.quantity = quantity;
            this.product_date = product_date;
            this.category_id = category_id;
            this.shop_id = shop_id;
            this.main_image = main_image;
            this.category_id = category_id;
            this.product_type = product_type;
            this.product_status = product_status;

        }
        public product()
        {
            name = "My product !";
            price = "3000000";
            quantity = "43";
            product_status = "confirm";
            

        }
       
    }
    
}
