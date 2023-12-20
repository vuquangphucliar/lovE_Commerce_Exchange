using BUS;
using DLL;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frm_statistic : Form
    {
        customer owner;
        shop my_shop;
        DataTable data;
        public frm_statistic(customer customer)
        {
            owner = customer;
            my_shop = BUS_shop.ReturnShopWithShopOwnerID(cus_id: owner.id.ToString());
            InitializeComponent();
        }
        private enum ChartType
        {
            Area,
            Bar,
            Bubble,
            Candlestick,
            Column,
            Line,
            Scatter,
            Spline,
            SplineArea,
            Step,
            Point,
            Pie,
            Doughnut
        }
        private enum AllDataSet
        {
            All_products,
            Sold_products    ,
            Bought_product

        }

        //public frm_statistic() { InitializeComponent(); }

        private void frm_statistic_Load(object sender, EventArgs e)
        {

            foreach (AllDataSet allDataSet in Enum.GetValues(typeof(AllDataSet)))
            {
                comboBox_dataset.Items.Add(allDataSet);
            }





        }

       
        private void button_generate_Click(object sender, EventArgs e)
        {


            

        }

        private void dataGridView_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                for (int i = 0; i < dataGridView_data.Rows.Count; i++)
                {
                    dataGridView_data[e.ColumnIndex, i].Selected = true;
                }
            }
        }

        private void SelectFullColumn()
        {
            for (int i = 0; i < dataGridView_data.ColumnCount; i++)
            {
                dataGridView_data.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView_data.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
        }

        private void dataGridView_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dataGridView_data.Rows.Count; i++)
            //{
            //    dataGridView_data[e.ColumnIndex, i].Selected = false;
            //}
        }

        private DataTable LoadDataSetIntoDataGridView(AllDataSet dataSet)
        {
            if (dataSet == AllDataSet.All_products)
            {
                if(my_shop.id == null)
                {
                    MessageBox.Show("You don't have a store to use this dataset !", "Invalid dataset !", MessageBoxButtons.OK);
                    return null;

                }
                return BUS_product.ReturnProductWithShopID(my_shop.id);
            }
            else if (dataSet == AllDataSet.Sold_products)
            {
                if(my_shop.id != null)
                {

                    return BUS_statistic.StatisticQuantitySoldProductsByShopID(my_shop.id);
                }
                MessageBox.Show("You don't have a store to use this dataset !", "Invalid dataset !", MessageBoxButtons.OK);
                return null;
            }
            else if(dataSet == AllDataSet.Bought_product)
            {
                if(my_shop.id == null)
                {
                    MessageBox.Show("You don't have a store to use this dataset !","Invalid dataset !",MessageBoxButtons.OK);
                    return null;
                }
                return BUS_statistic.Bought_product(my_shop.owner);
            }
            else
            {
                return null;
            }

        }
        private void comboBox_dataset_SelectedIndexChanged(object sender, EventArgs e)
        {
                dataGridView_data.DataSource = LoadDataSetIntoDataGridView((AllDataSet)comboBox_dataset.SelectedItem);
        
        }

        private void comboBox_dataset_SelectedIndexChanged_1(object sender, EventArgs e)
        {
    
        }

        private void comboBox_top_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
