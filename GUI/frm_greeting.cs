using BUS;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_greeting : Form
    {
        private customer you;
        private string friend_id;
        //private string greeting;    
        public bool add = false;
        private friend Friend;
        public frm_greeting(customer you,string friend_id)
        {
            this.you = you;
            this.friend_id = friend_id;
            Friend = BUS_friend.ReturnInfoFriendWithID(friend_id);
            
            //this.greeting = greeting;
            InitializeComponent();
        }
        public frm_greeting()
        {
            InitializeComponent();
        }

        private void textBox_greeting_TextChanged(object sender, EventArgs e)
        {
            if(textBox_greeting.Text.Length == 0)
            {
                button_send_request.Enabled = false;
            }
            else
            {
                button_send_request.Enabled = true;
            }
            label_max_length.Text = textBox_greeting.Text.Length.ToString() + "/150";
        }

        private void button_send_request_Click(object sender, EventArgs e)
        {

            BUS_friend.SendGreeting(you.id.ToString(), friend_id, textBox_greeting.Text,"0");  
            add = true;
            Dispose();
        }

        private void frm_greeting_Load(object sender, EventArgs e)
        {
            button_image.Image = new Bitmap(Friend.image);
            label_friend_name.Text = Friend.Username;
            textBox_greeting.Text = $"Hi, I'm {you.name}.I've got your phone number, Let's be friend now !";

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            textBox_greeting.Text = "";
        }
    }
}
