using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            double price = Convert.ToDouble(textBox3.Text);
            double discount = Convert.ToDouble(textBox2.Text) * 0.01;
            int quantity = Convert.ToInt32(textBox4.Text);

            
            double discountedPrice = price * (1 - discount);
            double totalAmount = discountedPrice * quantity;


            label6.Text = Convert.ToString(totalAmount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalAmount = Convert.ToDouble(label6.Text);

            double payment = Convert.ToDouble(textBox5.Text);


            double change = payment - totalAmount;

            
            label9.Text = Convert.ToString(change);
        }
    }
    }
namespace ItemNamespace {
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    public class DiscountedItem : Item
    {
        public double Discount { get; set; }

        public double GetDiscountedPrice()
        {
            return Price * (1 - Discount * 0.01);
        }
    }
}
