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
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
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

            pictureBox20.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\8 pcs Burger Steak w Spaghetti Pan.png");
            pictureBox19.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\Iced Vanilla Coffee.png");
            pictureBox18.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\Bucket Fries.png");
            pictureBox17.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\3pcs Tuna Pie.png");
            pictureBox16.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\CRUZ_OOP_CPE201\\Resources\\10 pcs Chicken Nuggets.png");

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
            int qty;
            double price, discount_amt, discounted_amt;
            
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            regularRbtn.Checked = false;    
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);

            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);

            qty_totaltxtbox.Text += qty;
            discount_totaltxtbox.Text += discount_amt;
            discounted_totaltxtbox.Text += discounted_amt;
            change = cash_rendered - discounted_amt;
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
            itemnametxtbox.Text = name1lbl.Text;
            pricetextbox.Text = "198.75";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = "149.75";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name3lbl.Text;
            pricetextbox.Text = "799.75";   
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = "179.75";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = "599.75";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = "189.75";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = "139.75";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = "229.75";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = "49.75";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = "39.75";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = "219.75";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = "89.75";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = "149.75";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = "299.75";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = "179.75";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name17lbl.Text;
            pricetextbox.Text = "89.75";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = "169.75";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = "219.75";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = "179.75";
        }
    }
}
