using System.Drawing;

namespace GUI
{
    partial class frm_friends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_friends));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_show_friend = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_show_friends = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_black_heart = new System.Windows.Forms.Button();
            this.button_gif = new System.Windows.Forms.Button();
            this.button_red_heart = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.flowLayoutPanel_show_message = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_info = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 508);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel_show_friend);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "   Friend    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // flowLayoutPanel_show_friend
            // 
            this.flowLayoutPanel_show_friend.AutoScroll = true;
            this.flowLayoutPanel_show_friend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_show_friend.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_show_friend.Name = "flowLayoutPanel_show_friend";
            this.flowLayoutPanel_show_friend.Size = new System.Drawing.Size(868, 469);
            this.flowLayoutPanel_show_friend.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel_show_friends);
            this.tabPage2.Controls.Add(this.textBox_message);
            this.tabPage2.Controls.Add(this.button_black_heart);
            this.tabPage2.Controls.Add(this.button_gif);
            this.tabPage2.Controls.Add(this.button_red_heart);
            this.tabPage2.Controls.Add(this.button_send);
            this.tabPage2.Controls.Add(this.flowLayoutPanel_show_message);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "   Messenger    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // flowLayoutPanel_show_friends
            // 
            this.flowLayoutPanel_show_friends.AutoScroll = true;
            this.flowLayoutPanel_show_friends.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_show_friends.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_show_friends.Name = "flowLayoutPanel_show_friends";
            this.flowLayoutPanel_show_friends.Size = new System.Drawing.Size(241, 469);
            this.flowLayoutPanel_show_friends.TabIndex = 3;
            // 
            // textBox_message
            // 
            this.textBox_message.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_message.Location = new System.Drawing.Point(381, 423);
            this.textBox_message.MaxLength = 150;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(290, 31);
            this.textBox_message.TabIndex = 2;
            this.textBox_message.TextChanged += new System.EventHandler(this.textBox_message_TextChanged);
            // 
            // button_black_heart
            // 
            this.button_black_heart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_black_heart.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_black_heart.ForeColor = System.Drawing.SystemColors.Control;
            this.button_black_heart.Image = ((System.Drawing.Image)(resources.GetObject("button_black_heart.Image")));
            this.button_black_heart.Location = new System.Drawing.Point(301, 416);
            this.button_black_heart.Name = "button_black_heart";
            this.button_black_heart.Size = new System.Drawing.Size(45, 45);
            this.button_black_heart.TabIndex = 1;
            this.button_black_heart.UseVisualStyleBackColor = false;
            // 
            // button_gif
            // 
            this.button_gif.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_gif.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gif.ForeColor = System.Drawing.SystemColors.Control;
            this.button_gif.Image = ((System.Drawing.Image)(resources.GetObject("button_gif.Image")));
            this.button_gif.Location = new System.Drawing.Point(250, 416);
            this.button_gif.Name = "button_gif";
            this.button_gif.Size = new System.Drawing.Size(45, 45);
            this.button_gif.TabIndex = 1;
            this.button_gif.UseVisualStyleBackColor = false;
            // 
            // button_red_heart
            // 
            this.button_red_heart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_red_heart.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_red_heart.ForeColor = System.Drawing.SystemColors.Control;
            this.button_red_heart.Image = ((System.Drawing.Image)(resources.GetObject("button_red_heart.Image")));
            this.button_red_heart.Location = new System.Drawing.Point(788, 415);
            this.button_red_heart.Name = "button_red_heart";
            this.button_red_heart.Size = new System.Drawing.Size(45, 45);
            this.button_red_heart.TabIndex = 1;
            this.button_red_heart.UseVisualStyleBackColor = false;
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_send.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.ForeColor = System.Drawing.SystemColors.Control;
            this.button_send.Location = new System.Drawing.Point(677, 415);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(105, 45);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // flowLayoutPanel_show_message
            // 
            this.flowLayoutPanel_show_message.AutoScroll = true;
            this.flowLayoutPanel_show_message.Location = new System.Drawing.Point(250, 3);
            this.flowLayoutPanel_show_message.Name = "flowLayoutPanel_show_message";
            this.flowLayoutPanel_show_message.Size = new System.Drawing.Size(621, 406);
            this.flowLayoutPanel_show_message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Explore";
            // 
            // button_info
            // 
            this.button_info.Image = ((System.Drawing.Image)(resources.GetObject("button_info.Image")));
            this.button_info.Location = new System.Drawing.Point(803, 12);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(50, 50);
            this.button_info.TabIndex = 2;
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click_1);
            // 
            // button_refresh
            // 
            this.button_refresh.Image = ((System.Drawing.Image)(resources.GetObject("button_refresh.Image")));
            this.button_refresh.Location = new System.Drawing.Point(747, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(50, 50);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(691, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_friends
            // 
            this.AcceptButton = this.button_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_friends";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Friend";
            this.Load += new System.EventHandler(this.frm_friends_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_show_friend;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_show_message;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_red_heart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_show_friends;
        private System.Windows.Forms.Button button_black_heart;
        private System.Windows.Forms.Button button_gif;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}