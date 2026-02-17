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
    public partial class Lesson3Example3 : Form
    {
        private double total_amount = 0;
        private int total_quantity = 0;
        public Lesson3Example3()
        {
            InitializeComponent();
        }

        private void bundleA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lesson3Example3_Load(object sender, EventArgs e)
        {
            // Disable textboxes
            pricetxtbox.Enabled = false;
            discntedamttxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            totalBillstxtbox.Enabled = false;
            discntamttxtbox.Enabled = false;
            totalqtytxtbox.Enabled = false;

            // Codes for inserting pictures in pictureboxes
            pizza6.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\6.png");
            pizza7.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\7.png");
            pizza8.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\8.png");
            pizza9.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\9.png");
            pizza10.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\10.png");

        }
    }
}
