using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class DAO_friend
    {
        public static void SendGreeting(string you_id,string friend_id,string greeting,string index)
        {
            MyConnection.Instance.ExecuteQuery($"AddFriendGreeting {you_id}, {friend_id} , '{greeting}',{index}");

        }
        public static void ReturnAllFriends()
        {
            MyConnection.Instance.ExecuteQuery("ReturnAllFriendMessage");
        }
        public static DataTable ReturnFriendNotAdded(string you_id)
        {
             return MyConnection.Instance.ExecuteDataTable($"ReturnFriendNotAdded {you_id}");
        }
        public static DataTable ReturnFriendInfoWithID(string id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnFriendInfoWithID {id}");
        }
        public static DataTable ReturnFriendAdded(string id)
        {
            return MyConnection.Instance.ExecuteDataTable($"ReturnFriendAdded {id}");
        }
        public static DataTable ReturnConverstion(string you_id,string friend_id,int long_before)
        {
            return MyConnection.Instance.ExecuteDataTable($" ReturnConverstion {you_id},{friend_id},{long_before}");
        }
        public static void AddNewMessage(string you_id,string friend_id,string added,string message)
        {
            MyConnection.Instance.ExecuteQuery($"AddNewMessage '{you_id}','{friend_id}','{added}','{message}'");
        }
    }
}
