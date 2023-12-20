namespace GUI
{
    partial class frm_greeting
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_greeting = new System.Windows.Forms.TextBox();
            this.button_send_request = new System.Windows.Forms.Button();
            this.button_image = new System.Windows.Forms.Button();
            this.label_friend_name = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.label_max_length = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(211, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Greeting";
            // 
            // textBox_greeting
            // 
            this.textBox_greeting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_greeting.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_greeting.Location = new System.Drawing.Point(75, 152);
            this.textBox_greeting.MaxLength = 150;
            this.textBox_greeting.Multiline = true;
            this.textBox_greeting.Name = "textBox_greeting";
            this.textBox_greeting.Size = new System.Drawing.Size(379, 131);
            this.textBox_greeting.TabIndex = 1;
            this.textBox_greeting.TextChanged += new System.EventHandler(this.textBox_greeting_TextChanged);
            // 
            // button_send_request
            // 
            this.button_send_request.BackColor = System.Drawing.Color.Cyan;
            this.button_send_request.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send_request.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_send_request.Location = new System.Drawing.Point(192, 289);
            this.button_send_request.Name = "button_send_request";
            this.button_send_request.Size = new System.Drawing.Size(160, 49);
            this.button_send_request.TabIndex = 2;
            this.button_send_request.Text = "Send request";
            this.button_send_request.UseVisualStyleBackColor = false;
            this.button_send_request.Click += new System.EventHandler(this.button_send_request_Click);
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(75, 71);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(60, 60);
            this.button_image.TabIndex = 3;
            this.button_image.UseVisualStyleBackColor = true;
            // 
            // label_friend_name
            // 
            this.label_friend_name.AutoSize = true;
            this.label_friend_name.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_friend_name.Location = new System.Drawing.Point(157, 93);
            this.label_friend_name.Name = "label_friend_name";
            this.label_friend_name.Size = new System.Drawing.Size(120, 22);
            this.label_friend_name.TabIndex = 4;
            this.label_friend_name.Text = "Friend name";
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(419, 111);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(35, 35);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "X";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label_max_length
            // 
            this.label_max_length.AutoSize = true;
            this.label_max_length.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_max_length.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_max_length.Location = new System.Drawing.Point(367, 251);
            this.label_max_length.Name = "label_max_length";
            this.label_max_length.Size = new System.Drawing.Size(54, 20);
            this.label_max_length.TabIndex = 6;
            this.label_max_length.Text = "0/150";
            // 
            // frm_greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 381);
            this.Controls.Add(this.label_max_length);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label_friend_name);
            this.Controls.Add(this.button_image);
            this.Controls.Add(this.button_send_request);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_greeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_greeting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greeting";
            this.Load += new System.EventHandler(this.frm_greeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_greeting;
        private System.Windows.Forms.Button button_send_request;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.Label label_friend_name;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label label_max_length;
    }
}