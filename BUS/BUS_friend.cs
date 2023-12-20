using DAO;
using DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_friend
    {
        private static customer[] customers;
        //public static friend[] ReturnAllFriends(string you_id)
        //{
        //    DataTable account = DAO_account.ReturnAllAccount();
        //    DataTable customer = DAO_friend.ReturnFriendNotAdded(you_id); ///
        //    friend[] friends = new friend[customer.Rows.Count];

        //    //remove staffs account
        //    for (int i = 0; i < account.Rows.Count; i++)
        //    {
        //        if (account.Rows[i]["login_role"].ToString() == "0")
        //        {
        //            account.Rows.Remove(account.Rows[i]);
        //        }
        //    }
        //    // get friends
        //    for (int i = 0; i < friends.Length; i++)
        //    {
        //        friends[i] = new friend(id: customer.Rows[i]["customer_id"].ToString(),
        //            username: account.Rows[i]["user_name"].ToString(),
        //            online: (bool)account.Rows[i]["onl"],
        //            email: customer.Rows[i]["customer_email"].ToString(),
        //            phonenumber: customer.Rows[i]["customer_email"].ToString(),
        //            image: customer.Rows[i]["picture"].ToString()
        //            );
        //    }
        //    return friends;
        //}
        public static friend[] ReturnFriendNotAdded(string you_id)
        {
            DataTable dataTable = DAO_friend.ReturnFriendNotAdded(you_id);
            friend[] friends = new friend[dataTable.Rows.Count];
            int i = 0;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                friends[i++] = new friend(id: dataRow["customer_id"].ToString(),
                                    username: dataRow["custormer_name"].ToString(),
                                    gender: dataRow["gender"].ToString(),
                                    online: dataRow["onl"].ToString(),
                                    email: dataRow["customer_email"].ToString(),
                                    phonenumber: dataRow["phone_number"].ToString(),
                                    image: dataRow["picture"].ToString()
                                    );
            }
            return friends;
        }
        public static friend[] ReturnFriendAdded(string you_id)
        {
            DataTable dataTable = DAO_friend.ReturnFriendAdded(you_id);
            friend[] friends = new friend[dataTable.Rows.Count];
            int i = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                friends[i++] = new friend(id: dataRow["customer_id"].ToString(),
                                    username: dataRow["custormer_name"].ToString(),
                                    gender: dataRow["gender"].ToString(),
                                    online: dataRow["onl"].ToString(),
                                    email: dataRow["customer_email"].ToString(),
                                    phonenumber: dataRow["phone_number"].ToString(),
                                    image: dataRow["picture"].ToString()
                                    );
            }
            return friends;
        }

        public static void SendGreeting(string you_id, string friend_id, string greeting,string index)
        {
            DAO_friend.SendGreeting(you_id,friend_id,FormatMessage(greeting),index);

        }
        public static string FormatMessage(string message)
        {
            string format_greeting = "";
            foreach (char c in message)
            {
                if (c == '\'')
                {
                    format_greeting += '\'';
                }
                format_greeting += c;
            }
            return format_greeting;
        }
        public static friend ReturnInfoFriendWithID(string id)
        {
            DataTable friends =  DAO_friend.ReturnFriendInfoWithID(id);
            return new friend(id: friends.Rows[0]["customer_id"].ToString(),
                                username: friends.Rows[0]["custormer_name"].ToString(),
                                gender: friends.Rows[0]["gender"].ToString(),
                                online: friends.Rows[0]["onl"].ToString(),
                                email: friends.Rows[0]["customer_email"].ToString(),
                                phonenumber: friends.Rows[0]["phone_number"].ToString(),
                                image: friends.Rows[0]["picture"].ToString()
                                );
        }
        private static string ReturnCustomerName( string id)
        {
            foreach(customer customer in customers)
            {
                if(customer.id.ToString() == id)
                {
                    return customer.name;
                }
            }
            return "nothing";
        }

        public static messenger[] ReturnConverstion(string you_id,string friend_id_,int long_before)
        {
            customers = BUS_customer.ReturnAllCustomer();
            DataTable messengers = DAO_friend.ReturnConverstion(you_id, friend_id_,long_before);
            if(messengers.Rows.Count == 0)
            {
                return null;
            }
            messenger[] mes = new messenger[messengers.Rows.Count];
            int i = 0;
            foreach(DataRow row in messengers.Rows)
            {
                mes[i++] = new messenger(you_id: row["you_id"].ToString(),
                                        you_name:ReturnCustomerName(row["you_id"].ToString()),
                                        friends_id: row["friend_id"].ToString(),
                                        friends_name: ReturnCustomerName(row["friend_id"].ToString()),
                                        message: row["message_"].ToString(),
                                        added: row["add_friend"].ToString());
            }
            return mes; 

        }
        public static void AddNewMessage(string you_id,string friend_id,string added ,string message)
        {
            DAO_friend.AddNewMessage(you_id,friend_id,added,message);

        }


    }
}
