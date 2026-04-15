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
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "1pc Chicken Joy w Burger Steak & Spaghetti";
            priceTextbox.Text = "198.75";   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "1pc Chicken Joy w Burger Steak";
            priceTextbox.Text = "149.75";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "8 pcs Chicken Joy w Spaghetti Pan";
            priceTextbox.Text = "799.75";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "2 pcs Chicken Joy w Coke";
            priceTextbox.Text = "179.75";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "8 pcs Chicken Joy";
            priceTextbox.Text = "599.75";
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
            itemnameTextbox.Text = "Aloha Champ Jr. Burger";
            priceTextbox.Text = "189.75";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Bacon Cheese Yumburger";
            priceTextbox.Text = "139.75";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Champ Burger";
            priceTextbox.Text = "229.75";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Chocolate Sundae";
            priceTextbox.Text = "49.75";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Coke Float";
            priceTextbox.Text = "39.75";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Double Aloha Champ Jr. Burger";
            priceTextbox.Text = "219.75";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Jolly Hotdog";
            priceTextbox.Text = "89.75";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Palabok ";
            priceTextbox.Text = "149.75";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Peach Mango Pie 6 pcs";
            priceTextbox.Text = "299.75";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Text = "Spaghetti Kiddie Meal w Drink";
            priceTextbox.Text = "179.75";
        }
    }
}
