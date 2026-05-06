using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUZ_OOP_CPE201
{
    public partial class Activity_Classes : Form
    {
        private double amount_paid, price, cash_given, change;
        private int quantity;
        public Activity_Classes()
        {
            InitializeComponent();
        }

        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        private void GetPriceItemValue()
        {
            itemnameTextbox.Text = price_item_value.GetItemName();
            priceTextbox.Text = price_item_value.GetPrice();
        }

        private void displayTxtbox(string itemname, string price)
        {
            itemnameTextbox.Text = itemname;
            priceTextbox.Text = price;
        }

        private void quantityTxtbox(string quantity)
        {
            qtytxtbox.Clear();
            qtytxtbox.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1pc Chicken Joy w Burger Steak & Spaghetti", "198.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("1pc Chicken Joy w Burger Steak", "149.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("8 pcs Chicken Joy w Spaghetti Pan", "799.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("2 pcs Chicken Joy w Coke", "179.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("8 pcs Chicken Joy", "599.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Clear();
            priceTextbox.Clear();
            qtytxtbox.Clear();
            amountpaidtxtbox.Clear();
            cashgiventxtbox.Clear();
            changetxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Aloha Champ Jr. Burger", "189.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Bacon Cheese Yumburger", "139.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Champ Burger", "229.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Chocolate Sundae", "49.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changetxtbox.Enabled = false;
            this.Location = new Point(0,0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Coke Float", "39.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Double Aloha Champ Jr. Burger", "219.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Jolly Hotdog", "89.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Palabok", "149.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Peach Mango Pie 6 pcs", "299.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            /*price = Convert.ToDouble(priceTextbox.Text);
            quantity = Convert.ToInt32(qtytxtbox.Text);
            amount_paid = price * quantity;
            amountpaidtxtbox.Text = amount_paid.ToString("n");
            cashgiventxtbox.Focus();*/
            try
            {
                variables.amount_paid = Convert.ToDouble(amountpaidtxtbox.Text);
                variables.cash_given = Convert.ToDouble(cashgiventxtbox.Text);
                variables.change = variables.cash_given - variables.amount_paid;
                changetxtbox.Text = variables.change.ToString("n");
                amountpaidtxtbox.Text = variables.amount_paid.ToString("n");
                cashgiventxtbox.Text = variables.cash_given.ToString("n");
            }
            catch
            { 
                
            }

        }

        private void qtytxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                variables.price = Convert.ToDouble(priceTextbox.Text);
                variables.quantity = Convert.ToInt32(qtytxtbox.Text);
                variables.amount_paid = variables.price * variables.quantity;
                amountpaidtxtbox.Text = variables.amount_paid.ToString("n");
                cashgiventxtbox.Focus();
            }
            catch
            {

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Spaghetti Kiddie Meal w Drink", "179.75");
            GetPriceItemValue();
            quantityTxtbox("");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
