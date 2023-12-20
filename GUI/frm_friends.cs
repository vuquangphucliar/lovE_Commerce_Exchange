using BUS;
using DLL;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_friends : Form
    {
        private friend[] friends;
        private friend[] friendsAdded;
        private customer current_customer;
        private messenger[] messengers;
        private string current_friend;
        public frm_friends(customer current_customer)
        {

            this.current_customer = current_customer;
            friends = BUS_friend.ReturnFriendNotAdded(current_customer.id.ToString());
            friendsAdded = BUS_friend.ReturnFriendAdded(current_customer.id.ToString());
            InitializeComponent();
            //friend_id.Text

        }

       
        private void frm_friends_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            LoadAccount(friends);
        }
        private void LoadAccount(friend[] friends)
        {
            foreach (friend friend in friends)
            {
                AddAccount(friend);
            }
        }
        private void AddAccount(friend friend)
        {
            GroupBox groupBox_friend = new GroupBox();
            flowLayoutPanel_show_friend.Controls.Add(groupBox_friend);
            groupBox_friend.Size = new Size(150, 264);
            //groupBox_friend.Location = new Point(2,2);
            groupBox_friend.Text = friend.Username;

            PictureBox pictureBox_avatar = new PictureBox();
            groupBox_friend.Controls.Add(pictureBox_avatar);
            pictureBox_avatar.Location = new Point(2, 21);
            pictureBox_avatar.Size = new Size(149, 161);
            pictureBox_avatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_avatar.Image = new Bitmap(@friend.image == "" ? Resources.image : @friend.image);
            pictureBox_avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox_avatar.Dock = System.Windows.Forms.DockStyle.Top;

            Label label_status = new Label();
            groupBox_friend.Controls.Add(label_status);
            label_status.Location = new Point(40, 165);
            label_status.Size = new Size(75, 19);
            if (friend.Online != "False")
            {
                label_status.Text = "Online";
                label_status.ForeColor = System.Drawing.Color.Lime;

            }
            else
            {
                label_status.Text = "Offline";
                label_status.ForeColor = System.Drawing.Color.Red;

            }
            label_status.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_status.BringToFront();



            Button button_add_friend = new Button();
            groupBox_friend.Controls.Add(button_add_friend);
            button_add_friend.Size = new Size(104, 28);
            button_add_friend.Location = new Point(21, 188);
            button_add_friend.Text = "Add Friend";
            button_add_friend.BackColor = System.Drawing.Color.Cyan;
            button_add_friend.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button_add_friend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button_add_friend.Click += Button_add_friend_Click;
            button_add_friend.Name = friend.id;

            Button button_info = new Button();
            groupBox_friend.Controls.Add(button_info);
            button_info.Size = new Size(104, 28);
            button_info.Location = new Point(21, 221);
            button_info.Text = "Info";
            button_info.Click += Button_info_Click;
            button_info.Name = friend.id;

        }
        private void Button_info_Click(object sender, EventArgs e)
        {

            Control control = sender as Control;
            friend friend = BUS_friend.ReturnInfoFriendWithID(control.Name);
            MessageBox.Show($"Information Here" +
                            $"Name : {friend.Username}\n" +
                            $"Online : {friend.Online}\n" +
                            $"Email : {friend.email}\n" +
                            $"Gender : {friend.gender}\n" +
                            $"Phone number : {friend.phonenumber}\n",
                                "General innformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void Button_add_friend_Click(object sender, EventArgs e)
        {
            // logic Add friend;            
            Control control = sender as Control;
            frm_greeting greeting = new frm_greeting(current_customer, control.Name);
            greeting.ShowDialog();
            if (greeting.add)
            {
                Button button = sender as Button;
                button.Text = "Sended";
                button.Enabled = false;
            }


            // forward to messenger

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void button_refresh_Click(object sender, EventArgs e)
        {

            if(timer1.Interval == 5000)
            {
                if (MessageBox.Show("DO you wanna set the interval down to  1000 miliseconds", "Turbo Boost", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    timer1.Interval = 1000;
                }
            }
            else
            {
                if (MessageBox.Show("DO you wanna reset time interval to 5000 miliseconds", "Good performance", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    timer1.Interval = 5000;
                }
            }

        }


        //FriendAdded area

        private void LoadFriendAdded(friend[] friends)
        {
            foreach (friend friend in friends)
            {
                ShowFriend(friend);
            }
        }

        private void ShowFriend(friend friend)
        {
            GroupBox groupBox_account = new GroupBox();
            flowLayoutPanel_show_friends.Controls.Add(groupBox_account);
            groupBox_account.Size = new System.Drawing.Size(156, 70);
            groupBox_account.Text = friend.Username;
            groupBox_account.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox_account.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            Button buton_chat_now = new Button();
            groupBox_account.Controls.Add(buton_chat_now);
            buton_chat_now.Size = new Size(104, 25);
            buton_chat_now.Location = new Point(17, 39);
            buton_chat_now.BackColor = System.Drawing.Color.Lime;
            buton_chat_now.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            buton_chat_now.Text = "Chat Now  ~" + friend.id;
            buton_chat_now.Name = "chatnow";
            buton_chat_now.BringToFront();
            buton_chat_now.Click += Buton_chat_now_Click;

            Label label_state = new Label();
            groupBox_account.Controls.Add(label_state);
            label_state.Size = new Size(72, 17);
            label_state.Location = new Point(14, 20);
            label_state.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_state.Text = "Status :";
            //label_state


            Label label_status = new Label();
            groupBox_account.Controls.Add(label_status);
            label_status.Size = new Size(56, 17);
            label_status.Location = new Point(88, 20);
            label_status.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_status.ForeColor = System.Drawing.Color.Lime;
            label_status.Text = "Online";
            label_status.BringToFront();


        }

        private void Buton_chat_now_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.Enabled = false;
            flowLayoutPanel_show_message.Controls.Clear();
            current_friend = control.Text.Split('~')[1];
            //messengers = 
            timer1.Enabled = true;
            //timer1_Tick(null, null);
            LoadMessage(current_friend);
            control.Name = "changed";

            foreach (Control control_ in control.Parent.Parent.Controls)
            {
                if(control_.Controls.Find("chatnow", true).Length != 0)
                {
                    control_.Controls.Find("chatnow", true)[0].Enabled = true ;
                } 
            }
            control.Name = "chatnow";
        }


        // Messenger area
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedTab ==  tabPage2)
            {
                //Logic send message runtime
                flowLayoutPanel_show_friends.Controls.Clear();
                LoadFriendAdded(friendsAdded);
                //timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
        private void LoadMessage(string friend_id)
        {
            messengers = BUS_friend.ReturnConverstion(you_id:current_customer.id.ToString(),
                                                                friend_id_:friend_id,0);   

            foreach(var messenger in messengers)
            {
                if(messenger.you_id == current_customer.id.ToString())
                {
                    GenMessage(messenger.you_name, messenger.message, you: true);
                }
                else
                {
                    GenMessage(messenger.you_name, messenger.message);
                }
            }
            ScrollToBottom();
        }
        private  void GenMessage(string Sender, string message,bool you = false)
        {
            //GenMessage
            string new_string = "";
            int max_char_in_line = 45;
            
            foreach(char c in message)
            {
                if( max_char_in_line-- < 2)
                {
                    max_char_in_line = 45;
                    new_string += '\n';
                }
                new_string += c;
            }
                

            GroupBox groupBox_Message = new GroupBox();
            flowLayoutPanel_show_message.Controls.Add(groupBox_Message);
            groupBox_Message.Location = new Point(2,2);
            if(new_string.Split('\n').Length > 1 )
            {
                groupBox_Message.Size = new Size(385, 50 * new_string.Split('\n').Length - 10 * new_string.Split('\n').Length);
            }
            else
            {
                groupBox_Message.Size = new Size(385, 50 );

            }
            groupBox_Message.Text = Sender;
            groupBox_Message.ForeColor = you ? Color.Aqua : SystemColors.ControlText;

            Label label_message = new Label();
            groupBox_Message.Controls.Add(label_message);
            //label_message.Size = new Size(152,17);
            label_message.Location = new Point(11,22);
            label_message.AutoSize = true;
            label_message.Text = new_string;
            label_message.ForeColor = SystemColors.ControlText;

        }

        private void Sychronize()
        {
            messenger[] messengers_ = BUS_friend.ReturnConverstion(you_id: current_customer.id.ToString(),
                                                                friend_id_: current_friend,messengers.Length);
            if(messengers_ == null)
            {
                return;
            }

            for (int i = messengers.Length ; i < messengers_.Length; i++)
            {
                //MessageBox.Show("Why are you here" + messengers_[i].message);
                if (messengers_[i].you_id == current_customer.id.ToString())
                {
                    GenMessage(messengers_[i].you_name, messengers_[i].message, you: true);
                }
                else
                {
                    GenMessage(messengers_[i].you_name, messengers_[i].message);
                }
            }
            ScrollToBottom();
            messengers = messengers_;
        }
        private void button_send_Click(object sender, EventArgs e)
        {
            //timer1_Tick(null, null);
            //Sychronize();
            BUS_friend.AddNewMessage(you_id: current_customer.id.ToString(),
                                            friend_id: current_friend,
                                             added: "0",
                                             message: BUS_friend.FormatMessage(textBox_message.Text));

            textBox_message.Clear();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sychronize();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox_message_TextChanged(object sender, EventArgs e)
        {
            //if (textBox_message.Text == "")
            //{
            //    button_send.Enabled = false;
            //}
        }
        private void ScrollToBottom()
        {
            // Đặt AutoScrollPosition để di chuyển xuống cuối của FlowLayoutPanel
            flowLayoutPanel_show_message.AutoScrollPosition = new Point(0, flowLayoutPanel_show_message.VerticalScroll.Maximum);
            //flowLayoutPanel_show_message.
        }

        private void button_info_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_New_messenger().ShowDialog();
        }
    }
}
