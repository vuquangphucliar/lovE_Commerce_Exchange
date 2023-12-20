using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public  class staff
    {
        public string id;
        public string name;
        public string phone;
        public string image;

        public staff(string id, string name, string phone, string image)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.image = image;
        }
    }
}
