using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public  class DAO_payment
    {
        public static DataTable ReturnAllPayments()
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnAllPayments");    
        }
    }
}
