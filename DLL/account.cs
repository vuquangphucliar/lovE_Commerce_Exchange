using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class account
    {
        public string username;
        public string password;
        public string remember;
        public string status;
        public string role;

        public account(string username ,string password,string remember,string status,string role)
        {
            this.username = username;
            this.password = password;
            this.remember = remember;
            this.status = status;
            this.role = role;

        }
        public account()
        {
            this.username = "unknown";
            this.password = "";
            this.remember = "";
            this.status = "";
            this.role = "";
        }


    }

}
