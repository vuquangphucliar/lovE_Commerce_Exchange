using BUS;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_add_product : Form
    {
        private string mode;
        private category[] categories;
        private shop shop;
        private string main_link;
        private string link_1;
        private string link_2;
        private string link_3;
        private string no_picture_link;
        private product old_product;
      
        public frm_add_product(string mode,shop shop, string product_id = "no need when add")
        {
            this.mode = mode;
            this.shop = shop;
            categories = BUS_product.ReturnAllCategories();
            InitializeComponent();
            no_picture_link = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\no_picture.png";
            if (mode == "edit")
            {
                old_product = BUS_product.InfoOneProduct(product_id);

            }
        }

        private void frm_add_product_Load(object sender, EventArgs e)
        {

            foreach(category category in categories)
            {
                comboBox_category.Items.Add(category.name + " ~" + category.id);
            }
            if(mode == "add")
            {
                label_mode.Text = "Add new product";
                pictureBox_main_image.Image = new Bitmap(no_picture_link);
                pictureBox_image_1.Image = new Bitmap(no_picture_link);
                pictureBox_image_2.Image = new Bitmap(no_picture_link);
                pictureBox_image_3.Image = new Bitmap(no_picture_link);
            }
            else
            {
                label_mode.Text = "Edit product info";
                string[] images = old_product.main_image.Split('#');
                int i = 0;

                try
                {
                    pictureBox_main_image.Image = new Bitmap(@images[++i]);

                }
                catch
                {
                    pictureBox_main_image.Image = Properties.Resources.images;
                }
                main_link = @images[i];
                link_1 = (++i < images.Length) ? images[i] : no_picture_link; pictureBox_image_1.Image = new Bitmap(link_1);
                link_2 = (++i < images.Length) ? images[i] : no_picture_link; pictureBox_image_2.Image = new Bitmap(link_2);
                link_3 = (++i < images.Length) ? images[i] : no_picture_link; pictureBox_image_3.Image = new Bitmap(link_3);
                textBox_name.Text = old_product.name;
                foreach(category category in categories)
                {
                    if (category.id == old_product.category_id)
                    {
                        comboBox_category.Text = category.name + " ~" +  category.id;
                        break;
                    }
                }
                textBox_quantity.Text = old_product.quantity;
                textBox_description.Text = old_product.description;
                textBox_price.Text = old_product.price;
                dateTimePicker_date.Text = old_product.product_date;

            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                if(MessageBox.Show("This product'll be added to your your shop. \nAre you sure ?","Confirm new product",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (textBox_name.Text.Length > 29 || textBox_name.Text == "Product name")
                    {
                        MessageBox.Show("The product name must less than 25 character and must have the meaning ", "Invalid product name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if(comboBox_category.Text == "No category")
                    {
                        MessageBox.Show("Please choose the category","Invalid category",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    int temp;
                    if(!int.TryParse(textBox_quantity.Text, out temp) || int.Parse(textBox_quantity.Text) > 1000)
                    {
                        MessageBox.Show("The product quantity can not over 1000 and need at least 20  products ! ", "Invalid product quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    if (pictureBox_main_image.Image == null)
                    {
                        MessageBox.Show("The product need at least one picture !", "Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if( int.Parse(textBox_price.Text) > 99000000 || int.Parse(textBox_price.Text) < 10000)
                    {
                        MessageBox.Show("The price need to lower than 99,000,000 Vnđ and more than 10,000 Vnđ", "Invalid price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;                                 
                    }
                    AddNewProduct();
                    Dispose();
                    MessageBox.Show("Your submission has been received. \nOur team will review your product, and it will be made available on our trading platform within the next 24 hours.", "Successfully,",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                if(MessageBox.Show("This product information'll be updated. \nAre you sure ?","Confirm action",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (textBox_name.Text.Length > 29 || textBox_name.Text == "Product name")
                    {
                        MessageBox.Show("The product name must less than 25 character and must have the meaning ", "Invalid product name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (comboBox_category.Text == "No category")
                    {
                        MessageBox.Show("Please choose the category", "Invalid category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int temp;
                    if (!int.TryParse(textBox_quantity.Text, out temp) || int.Parse(textBox_quantity.Text) > 1000)
                    {
                        MessageBox.Show("The product quantity can not over 1000 and need at least 20  products ! ", "Invalid product quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (pictureBox_main_image.Image == null)
                    {
                        MessageBox.Show("The product need at least one picture !", "Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (int.Parse(textBox_price.Text) > 99000000 || int.Parse(textBox_price.Text) < 10000)
                    {
                        MessageBox.Show("The price need to lower than 99,000,000 Vnđ and more than 10,000 Vnđ", "Invalid price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    EditOldProduct();
                    Dispose();
                    MessageBox.Show("Your product information's updated successfully", "Edit successfully", MessageBoxButtons.OK);
                }
            }
        }

        private void AddNewProduct()
        {
            BUS_product.AddNewProduct(product_name: textBox_name.Text,
                                        desc: textBox_description.Text,
                                        price: textBox_price.Text,
                                        quantity: textBox_quantity.Text,
                                        date: dateTimePicker_date.Text,
                                        category_id: comboBox_category.Text.Split('~')[1],
                                        shop_id: shop.id);
            // Save to database
            BUS_product.AddProductImage(product_id:BUS_product.ReturnMaxProductID(),
                                        main_image_link:main_link,
                                        link1:link_1,
                                        link2:link_2,
                                        link3:link_3);
        }
        private void EditOldProduct()
        {
            BUS_product.UpdateProductInfo(product_id:old_product.product_id,
                                            product_name: textBox_name.Text,
                                            desc:textBox_description.Text,
                                            price:textBox_price.Text,
                                            quantity:textBox_quantity.Text,
                                            category_id: comboBox_category.Text.Split('~')[1]
                                            );
            BUS_product.UpdateProductImage(product_id: old_product.product_id,
                                           main_image: main_link,
                                           link1: link_1 ,
                                           link2: link_2 ,
                                           link3: link_3 );
        }

        private void pictureBox_main_image_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Split('.')[1] == "webp")
                {
                    MessageBox.Show("Unsupported this kind of extension file","Invalid filename",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                pictureBox.Image  = new Bitmap(openFileDialog.FileName);

                if(pictureBox.Name == "pictureBox_main_image")
                {
                    main_link = openFileDialog.FileName;
                }
                if (pictureBox.Name == "pictureBox_image_1")
                {
                    link_1 = openFileDialog.FileName;
                }
                if (pictureBox.Name == "pictureBox_image_2")
                {
                    link_2 = openFileDialog.FileName;
                }
                if (pictureBox.Name == "pictureBox_image_3")
                {
                    link_3 = openFileDialog.FileName;
                }
            }
        }
    }
}
