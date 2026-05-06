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
    public partial class Activity3_Classes : Form
    {
        int qty_total = 0;
        double discount_total = 0;
        double discounted_total = 0;
        double price = 0;
        public Activity3_Classes()
        {
            InitializeComponent();
        }

        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void quantity_price_Convert()
        {
            qty_total = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            discounted_total = (qty_total * price) - discount_total;
            discounttxtbox.Text = discount_total.ToString("n");
            discountedtxtbox.Text = discounted_total.ToString("n");
        }
        public void price_item_TextValue(string itemname, string price) 
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            pictureBox20.Image = Image.FromFile("C:\\Users\\Ken Cruz\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\8 pcs Burger Steak w Spaghetti Pan.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Ken Cruz\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\Iced Vanilla Coffee.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Ken Cruz\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\Bucket Fries.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Ken Cruz\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\3pcs Tuna Pie.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\Ken Cruz\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\10 pcs Chicken Nuggets.png");

            name1lbl.Text = "1pc Chicken Joy w BurStk/Spag";
            name2lbl.Text = "1pc Chicken Joy w BurStk";
            name3lbl.Text = "8 pcs Chicken Joy w Spag Pan";
            name4lbl.Text = "2 pcs Chicken Joy w Coke";
            name5lbl.Text = "8 pcs Chicken Joy";
            name6lbl.Text = "Aloha Champ Jr. Burger";
            name7lbl.Text = "Bacon Cheese Yumburger";
            name8lbl.Text = "Champ Burger";
            name9lbl.Text = "Chocolate Sundae";
            name10lbl.Text = "Coke Float";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name16lbl.Text;
            pricetextbox.Text = "899.75";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                /*int qty;
                double price, discount_amount, discounted_amount;

                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amount = (qty * price) * 0.30;
                discounted_amount = (qty * price) - discount_amount;

                discounttxtbox.Text = discount_amount.ToString("n");
                discountedtxtbox.Text = discounted_amount.ToString("n");

                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;*/
                    quantity_price_Convert();
                    discount_total = (qty_total * price) * 0.30;
                    computation_Formula_and_DisplayData();

                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /*int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amt = (qty * price) * 0.10;
                discounted_amt = (qty * price) - discount_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");*/

                    quantity_price_Convert();
                    discount_total = (qty_total * price) * 0.30;
                    computation_Formula_and_DisplayData();

                radioButton1.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /*int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amt = (qty * price) * 0.15;
                discounted_amt = (qty * price) - discount_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");*/

                    quantity_price_Convert();
                    discount_total = (qty_total * price) * 0.15;
                    computation_Formula_and_DisplayData();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /*int qty;
                double price, discount_amt, discounted_amt;
                qty = Convert.ToInt32(quantitytxtbox.Text);
                price = Convert.ToDouble(pricetextbox.Text);

                discount_amt = (qty * price) * 0;
                discounted_amt = (qty * price) - discount_amt;

                discounttxtbox.Text = discount_amt.ToString("n");
                discountedtxtbox.Text = discounted_amt.ToString("n");*/

                    quantity_price_Convert();
                    discount_total = (qty_total * price) * 0;
                    computation_Formula_and_DisplayData();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
            }
            catch
            {
                MessageBox.Show("Input is invalid");
                quantityTxtbox();
            }

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amount, discounted_amount, cash_rendered, change;

            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);
                discount_amount = Convert.ToDouble(discounttxtbox.Text);
                discounted_amount = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);

                qty_total += qty;
                discount_total += discount_amount;
                discounted_total += discounted_amount;
                change = cash_rendered - discounted_amount;

                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text = discount_total.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not empty       invalid");
                cashrenderedtxtbox.Clear();
                cashrenderedtxtbox.Focus();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name1lbl.Text, "198.75");
            quantityTxtbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name2lbl.Text, "149.75");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name3lbl.Text, "799.75");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name4lbl.Text, "179.75");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name5lbl.Text, "599.75");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name6lbl.Text, "189.75");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name7lbl.Text, "139.75");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name8lbl.Text, "229.75");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name9lbl.Text, "49.75");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name10lbl.Text, "39.75");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name11lbl.Text, "219.75");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name12lbl.Text, "89.75");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name13lbl.Text, "149.75");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name14lbl.Text, "299.75");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name15lbl.Text, "179.75");
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name17lbl.Text, "89.75");
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name18lbl.Text, "169.75");
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name19lbl.Text, "219.75");
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(name20lbl.Text, "179.75");
            quantityTxtbox();
        }

        private void cashrenderedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
