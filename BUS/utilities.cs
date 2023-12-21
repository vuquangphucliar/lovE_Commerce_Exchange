using DAO;
using DLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{

    //public static class Resources
    //{

    //    public static string office_girl = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Office-Girl-icon.png";
    //    public static string receiced = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\received_16097338494.jpeg";
    //    public static string search_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\search-icon.png";
    //    public static string shop_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\shop-icon.png";
    //    public static string cart_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Shoppingcart-11-icon.png";
    //    public static string log_out_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\system-log-out-icon.png";
    //    public static string task_bar_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\taskbar-icon.png";
    //    public static string notice = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Apps-preferences-desktop-notification-icon.png";
    //    public static string log_off_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Button-Log-Off-icon.png";
    //    public static string gift_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\gift-icon.png";
    //    public static string statistic_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\gnome-power-statistics-icon.png";
    //    public static string user_admin_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Hopstarter-Soft-Scraps-User-Administrator-Blue.48.png";
    //    public static string image = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\images.jpg";
    //    public static string internet_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Internet-icon.png";
    //    public static string message_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\message-already-read-icon.png";
    //    public static string mall = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Guillendesign-Variations-3-Shop.48.png";
    //    public static string home_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Hopstarter-Sleek-Xp-Basic-Home.24.png";
    //    public static string filter_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Colebemis-Feather-Filter.24.png";
    //    public static string guest_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Icons8-Windows-8-Users-Guest.24.png";
    //    public static string back_ = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\Custom-Icon-Design-Flatastic-8-Go-back.24.png";
    //    public static string No_picture = @"D:\Documents\utehy\utehy_Winform\lovE_Commerce_Exchange\Images\no_picture.png";
    //    //public static string refresh 


    //}
    public static class Utilities
    {
        public static void Info(object target)
        {
            // dùng expression re 
            if (target is Button button)
            {
                MessageBox.Show(
                    $"button name : {button.Name}\n" +
                    $"Size : {button.Size}\n" +
                    $"Location : {button.Location} \n"
                    );
            }          
            else if (target is Label label)
            {
                MessageBox.Show(
                    $"label name : {label.Name}\n" +
                    $"Size : {label.Size}\n" +
                    $"Location : {label.Location} \n"
                    );
            }
            else if (target is GroupBox groupbox)
            {
                MessageBox.Show(
                    $"groupbox name : {groupbox.Name}\n" +
                    $"Size : {groupbox.Size}\n" +
                    $"Location : {groupbox.Location} \n"
                    );
            }         
            else if (target is FlowLayoutPanel flowpanel)
            {
                MessageBox.Show(
                    $"flowpanel name : {flowpanel.Name}\n" +
                    $"Size : {flowpanel.Size}\n" +
                    $"Location : {flowpanel.Location} \n"
                    );
            }      
            else if (target is ComboBox combobox)
            {
                MessageBox.Show(
                    $"combobox name : {combobox.Name}\n" +
                    $"Size : {combobox.Size}\n" +
                    $"Location : {combobox.Location} \n"
                    );
            }           
            else if (target is CheckBox checkbox)
            {
                MessageBox.Show(
                    $"checkbox name : {checkbox.Name}\n" +
                    $"Size : {checkbox.Size}\n" +
                    $"Location : {checkbox.Location} \n"
                    );
            }
            else  if (target is Control control)
            {
                MessageBox.Show(
                    $"checkbox name : {control.Name}\n" +
                    $"Size : {control.Size}\n" +
                    $"Location : {control.Location} \n"
                    );
            }

        }

        public static string ConfigureMailProducts(product[] products,string quantity)
        {
            string[] quantities = quantity.Split('~');
            int i = 0;
            string productRows = "";
            foreach(product product in products)
            {
                ++i;
                productRows += $"<tr>\r\n                <td>{product.name}</td>\r\n                " +
                                                        $"<td>{quantities[i]}</td>\r\n                " +
                                                        $"<td>{int.Parse(quantities[i]) * int.Parse(product.price)}</td>\r\n            </tr>";
            }
            return productRows;
        }
        public static void SendProductBill(customer customer,string address,string payment,string products,string total_price)
        {
            MyConnection.Instance.ExecuteQuery("mail_send_bill_products " +
                                               $"'{customer.email}'," +
                                               $"'{customer.name}'," +
                                               $"'{address}'," +
                                               $"'{payment}'," +
                                               $"'{products}'," +
                                               $"'{total_price}'");
           
        }
        public static void SendProductBillBuyNow(customer customer,string product_name,string quantity,string voucher_name,string address,string payment,string shop__name,string date)
        {
            MyConnection.Instance.ExecuteQuery("mail_send_bill " +
                                                $"'{customer.email}'," +
                                                $"'{customer.name}'," +
                                                $"'{product_name}'," +
                                                $"'{quantity}'," +
                                                $"'{voucher_name}'," +
                                                $"'{address}'," +
                                                $"'{payment}'," +
                                                $"'{shop__name}'," +
                                                $"'{date}'");
        }
        

    }

}
