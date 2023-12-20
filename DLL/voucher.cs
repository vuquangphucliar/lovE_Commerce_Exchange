using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class voucher
    {
        public int id;
        public string name;

        public string description;
        public string discount;
        public string expire;
        public string active;
        public string quantity;
        public string code;
        public string used;

        public voucher(int id, string name, string description, string discount, string expire, string active, string quantity, string code)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.discount = discount;
            this.expire = expire;
            this.active = active;
            this.quantity = quantity;
            this.code = code;
        }
        //public voucher(int id, string name, string description, string discount, string expire, string active, string quantity, string code,string used)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.description = description;
        //    this.discount = discount;
        //    this.expire = expire;
        //    this.active = active;
        //    this.quantity = quantity;
        //    this.code = code;
        //    this.used = used;
        //}
    }
}
