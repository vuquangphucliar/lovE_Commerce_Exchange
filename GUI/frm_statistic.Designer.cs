using System.Drawing;

namespace GUI
{
    partial class frm_statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_statistic));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.button_info = new System.Windows.Forms.Button();
            this.comboBox_dataset = new System.Windows.Forms.ComboBox();
            this.comboBox_top = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistic";
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.GridColor = System.Drawing.Color.Black;
            this.dataGridView_data.Location = new System.Drawing.Point(12, 102);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.ReadOnly = true;
            this.dataGridView_data.RowHeadersWidth = 51;
            this.dataGridView_data.RowTemplate.Height = 24;
            this.dataGridView_data.Size = new System.Drawing.Size(948, 454);
            this.dataGridView_data.TabIndex = 6;
            this.dataGridView_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_data_CellClick);
            this.dataGridView_data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_data_CellDoubleClick);
            // 
            // button_info
            // 
            this.button_info.Image = ((System.Drawing.Image)(resources.GetObject("button_info.Image")));
            this.button_info.Location = new System.Drawing.Point(910, 46);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(50, 50);
            this.button_info.TabIndex = 10;
            this.button_info.UseVisualStyleBackColor = true;
            // 
            // comboBox_dataset
            // 
            this.comboBox_dataset.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dataset.FormattingEnabled = true;
            this.comboBox_dataset.Location = new System.Drawing.Point(12, 68);
            this.comboBox_dataset.Name = "comboBox_dataset";
            this.comboBox_dataset.Size = new System.Drawing.Size(185, 28);
            this.comboBox_dataset.TabIndex = 7;
            this.comboBox_dataset.Text = "DataSet";
            this.comboBox_dataset.SelectedIndexChanged += new System.EventHandler(this.comboBox_dataset_SelectedIndexChanged);
            // 
            // comboBox_top
            // 
            this.comboBox_top.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_top.FormattingEnabled = true;
            this.comboBox_top.Items.AddRange(new object[] {
            "Top",
            "top 1",
            "top 10",
            "top 100"});
            this.comboBox_top.Location = new System.Drawing.Point(203, 68);
            this.comboBox_top.Name = "comboBox_top";
            this.comboBox_top.Size = new System.Drawing.Size(112, 28);
            this.comboBox_top.TabIndex = 7;
            this.comboBox_top.Text = "Top";
            this.comboBox_top.SelectedIndexChanged += new System.EventHandler(this.comboBox_top_SelectedIndexChanged);
            // 
            // frm_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 674);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.comboBox_top);
            this.Controls.Add(this.comboBox_dataset);
            this.Controls.Add(this.dataGridView_data);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_statistic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.frm_statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.ComboBox comboBox_dataset;
        private System.Windows.Forms.ComboBox comboBox_top;
    }
}