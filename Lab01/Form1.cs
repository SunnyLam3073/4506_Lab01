using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int quanitity;
            quanitity = Int32.Parse(txtbox_quantity.Text);
            string productCode;
            productCode = cb_productCode.Text;
            int price = Int32.Parse(lbl_price.Text);
            int totalPrice =  price * quanitity;
            lbl_TotalPrice.Text = "Total Price of the Order is " + totalPrice.ToString();
            MessageBox.Show("You have ordered " + quanitity + " units of " + productCode + " with total cost equal to HK$" + totalPrice);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cb_productCode.ResetText();
            txtbox_quantity.Clear();
        }

        private void cb_productCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productA1 = "Car A1";
            string productCodeA1 = "A0001";
            int priceA1 = 100;

            string productA2 = "Car A2";
            string productCodeA2 = "A0002";
            int priceA2 = 150;

            string productB1 = "Car B1";
            string productCodeB1 = "B0001";
            int priceB1 = 50;

            string productB2 = "Car B2";
            string productCodeB2 = "B0002";
            int priceB2 = 200;

            if (cb_productCode.SelectedItem.ToString() == productCodeA1)
            {
                lbl_Name.Text = productA1;
                lbl_price.Text = priceA1.ToString();
            } else if (cb_productCode.SelectedItem.ToString() == productCodeA2)
            {
                lbl_Name.Text = productA2;
                lbl_price.Text = priceA2.ToString();
            } else if (cb_productCode.SelectedItem.ToString() == productCodeB1)
            {
                lbl_Name.Text = productB1;
                lbl_price.Text = priceB1.ToString();
            } else if (cb_productCode.SelectedItem.ToString() == productCodeB2)
            {
                lbl_Name.Text = productB2;
                lbl_price.Text = priceB2.ToString();
            }

        }
    }
}
