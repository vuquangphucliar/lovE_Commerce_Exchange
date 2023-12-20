using BUS;
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
    public partial class frm_New_messenger : Form
    {
        public frm_New_messenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GenFriend();
            //GenSenderMessage();
            //GenRecieverMessage();
        }


        private void GenFriend(string friend_name,string image)
        {
            GroupBox groupBox_friend = new GroupBox();
            flowLayoutPanel_show_friends.Controls.Add(groupBox_friend);
            groupBox_friend.Size = new Size(165, 54);
            groupBox_friend.Location = new Point(2, 2);

            Label label_friend_name = new Label();
            groupBox_friend.Controls.Add(label_friend_name);
            label_friend_name.Size = new Size(80, 18);
            label_friend_name.Location = new Point(49, 21);
            label_friend_name.Text = friend_name;

            PictureBox pictureBox_friend_image = new PictureBox();
            groupBox_friend.Controls.Add(pictureBox_friend_image);
            pictureBox_friend_image.Size = new Size(38, 41);
            pictureBox_friend_image.Location = new Point(4, 9);
            pictureBox_friend_image.Image = new Bitmap(image);


        }
        private void GenSenderMessage(string sender_image,string message)
        {
            Panel panel_sender = new Panel();
            flowLayoutPanel_show_message.Controls.Add(panel_sender);
            panel_sender.Size = new Size(504,47);
            //panel_sender.Location = new Point(2, 2);

            GroupBox groupBox_sender = new GroupBox();
            panel_sender.Controls.Add(groupBox_sender);
            groupBox_sender.Size = new Size(295,46);
            groupBox_sender.Location = new Point(172,2);



            PictureBox pictureBox_sender_image = new PictureBox();
            panel_sender.Controls.Add((pictureBox_sender_image));
            pictureBox_sender_image.Size = new Size(30,32);
            pictureBox_sender_image.Location = new Point(472,2);
            pictureBox_sender_image.Image = new Bitmap(sender_image);

            Label label_sender_message = new Label();
            groupBox_sender.Controls.Add(label_sender_message);
            label_sender_message.Location = new Point(1,15);
            label_sender_message.Size = new Size(288,17);
            label_sender_message.AutoSize = true;
            label_sender_message.Dock = System.Windows.Forms.DockStyle.Left;
            label_sender_message.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_sender_message.Text = message;
        }
        private void GenRecieverMessage(string reciever_image, string message)
        {
            Panel panel_reciever = new Panel();
            flowLayoutPanel_show_message.Controls.Add(panel_reciever);
            panel_reciever.Size = new Size(504, 47);
            //panel_reciever.Location = new Point(2, 2);

            GroupBox groupBox_reciever = new GroupBox();
            panel_reciever.Controls.Add(groupBox_reciever);
            groupBox_reciever.Size = new Size(220, 46);
            groupBox_reciever.Location = new Point(37, 2);

            PictureBox pictureBox_reciever_image = new PictureBox();
            panel_reciever.Controls.Add((pictureBox_reciever_image));
            pictureBox_reciever_image.Size = new Size(30, 32);
            pictureBox_reciever_image.Location = new Point(2, 15);
            pictureBox_reciever_image.Image = new Bitmap(reciever_image);

            Label label_reciever_message = new Label();
            groupBox_reciever.Controls.Add(label_reciever_message);
            label_reciever_message.Location = new Point(2, 15);
            label_reciever_message.Size = new Size(176, 17);
            label_reciever_message.AutoSize = true;
            label_reciever_message.Dock = System.Windows.Forms.DockStyle.Top;
            label_reciever_message.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_reciever_message.Text = message;
        }
        private string FormatMessage(string message)
        {
            string new_message = "";
            return new_message;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            //GenSenderMessage()
        }
    }
}
