using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class shop
    {
        public string id;
        public string name;
        public string description;
        public string address;
        public string phone;
        public string owner;

        public shop(string id, string name, string description, string address, string phone, string owner)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.address = address;
            this.phone = phone;
            this.owner = owner;
        }
        public shop() { }
    }
}
