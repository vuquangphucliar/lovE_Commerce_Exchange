using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class friend
    {
        public string id;
        public string Username;
        public string Online;
        public string email;
        public string gender;
        public string phonenumber;
        public string image;

        public friend() { }

        public friend(string id,string gender,string username, string online, string email, string phonenumber, string image)
        {
            this.id = id;
            this.gender = gender;
            Username = username;
            Online = online;
            this.email = email;
            this.phonenumber = phonenumber;
            this.image = image;
        }
        
    }
}
