using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class customer
    {
        public int id;
        public string name;
        public string email;
        public string gender;
        public string phone;
        public string image;

        public customer(int id, string name,string gender, string email, string phone, string image)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.phone = phone;
            this.image = image;
        }
        public customer(string name,string email)
        {
            this.name = name;
            this.email = email;

        }
        public customer() {
            image = "";
        }
    }
    
}
