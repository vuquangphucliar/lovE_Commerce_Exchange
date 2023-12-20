namespace DLL
{
    public class messenger
    {
        public string you_id;
        public string you_name;
        public string friends_id;
        public string friends_name;
        public string message;
        public string added;

        public messenger(string you_id, string you_name, string friends_id, string friends_name, string message, string added)
        {
            this.you_id = you_id;
            this.you_name = you_name;
            this.friends_id = friends_id;
            this.friends_name = friends_name;
            this.message = message;
            this.added = added;
        }

    }
}
