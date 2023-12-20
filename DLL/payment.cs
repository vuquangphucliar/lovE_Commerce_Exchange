using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class payment
    {
        public string id;
        public string name;
        public string description;

        public payment(string id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
