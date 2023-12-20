namespace GUI
{
    partial class frm_bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bill));
            this.flowLayoutPanel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_accept = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label_total_amount = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_provision = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_products
            // 
            resources.ApplyResources(this.flowLayoutPanel_products, "flowLayoutPanel_products");
            this.flowLayoutPanel_products.Name = "flowLayoutPanel_products";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button_accept
            // 
            this.button_accept.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.button_accept, "button_accept");
            this.button_accept.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_accept.Name = "button_accept";
            this.button_accept.UseVisualStyleBackColor = false;
            this.button_accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label_total_amount
            // 
            resources.ApplyResources(this.label_total_amount, "label_total_amount");
            this.label_total_amount.ForeColor = System.Drawing.Color.Red;
            this.label_total_amount.Name = "label_total_amount";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label_provision
            // 
            resources.ApplyResources(this.label_provision, "label_provision");
            this.label_provision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_provision.Name = "label_provision";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label_discount
            // 
            resources.ApplyResources(this.label_discount, "label_discount");
            this.label_discount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_discount.Name = "label_discount";
            // 
            // frm_bill
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label_provision);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label_total_amount);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel_products);
            this.Name = "frm_bill";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frm_bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label_total_amount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label_provision;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_discount;
    }
}