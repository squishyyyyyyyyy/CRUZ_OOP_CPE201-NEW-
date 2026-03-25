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
        private int total_qty = 0;
        public Lesson3Example3()
        {
            InitializeComponent();
        }

        bool can_change = true;
        private void bundleA_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.LightCyan;
            bundleB.Checked = false;
            displayPicture.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Family Meal.png");

            // Codes to enable and disable checkboxes
            A_Cokecheckbox.Enabled = true;
            A_FriedChickencheckbox.Enabled = true;
            A_Mojocheckbox.Enabled = true;
            A_Sidedishescheckbox.Enabled = true;
            A_Specialpizzacheckbox.Enabled = true;

            A_Cokecheckbox.Checked = true;
            A_FriedChickencheckbox.Checked = true;
            A_Mojocheckbox.Checked = true;
            A_Sidedishescheckbox.Checked = true;
            A_Specialpizzacheckbox.Checked = true;

            B_Carbonaracheckbox.Enabled = false;
            B_Dessertpizza.Enabled = false;
            B_FriedChickencheckbox.Enabled = false;
            B_Mojobcktcheckbox.Enabled = false;
            B_pizzacheckbox.Enabled = false;

            // Displaying data in the textbox
            pricetxtbox.Text = "1,000.00";
            discntamttxtbox.Text = "200.00";
            price = Convert.ToDouble(pricetxtbox.Text);

            // Displaying data in the listbox
            displayListbox.Items.Add(bundleA.Text + "   "
                + pricetxtbox.Text);
            displayListbox.Items.Add("         Discount Amount:    " + " " 
                + discntamttxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void Lesson3Example3_Load(object sender, EventArgs e)
        {
            // Disable textboxes
            this.WindowState = FormWindowState.Maximized; 
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
            pizza11.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\11.png");
            pizza12.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\12.png");
            pizza13.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\13.png");
            pizza14.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\14.png");
            pizza15.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\15.png");
            pizza16.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\16.png");
            pizza17.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\17.png");
            pizza18.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\18.png");
            pizza19.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\19.png");
            pizza20.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Pizzas\\20.png");

            // Codes to disable checkboxes
            A_Cokecheckbox.Enabled = false;
            A_FriedChickencheckbox.Enabled = false;
            A_Mojocheckbox.Enabled = false;
            A_Sidedishescheckbox.Enabled = false;
            A_Specialpizzacheckbox.Enabled = false;
            B_Carbonaracheckbox.Enabled = false;
            B_Dessertpizza.Enabled = false;
            B_FriedChickencheckbox.Enabled = false; 
            B_Mojobcktcheckbox.Enabled = false;
            B_pizzacheckbox.Enabled = false;


        }

        private void bundleB_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            this.BackColor = Color.LightCyan;
            bundleA.Checked = false;
            displayPicture.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Family Meal 2.png");

            A_Cokecheckbox.Enabled = false;
            A_FriedChickencheckbox.Enabled = false;
            A_Mojocheckbox.Enabled = false;
            A_Sidedishescheckbox.Enabled = false;
            A_Specialpizzacheckbox.Enabled = false;

            B_Carbonaracheckbox.Enabled = true;
            B_Dessertpizza.Enabled = true;
            B_FriedChickencheckbox.Enabled = true;
            B_Mojobcktcheckbox.Enabled = true;
            B_pizzacheckbox.Enabled = true;

            B_Carbonaracheckbox.Checked = true;
            B_Dessertpizza.Checked = true;
            B_FriedChickencheckbox.Checked = true;
            B_Mojobcktcheckbox.Checked = true;
            B_pizzacheckbox.Checked = true;

            pricetxtbox.Text = "1,299.00";
            discntamttxtbox.Text = "194.85";
            price = Convert.ToDouble(pricetxtbox.Text);

            displayListbox.Items.Add(bundleB.Text + "   "
                + pricetxtbox.Text);
            displayListbox.Items.Add("         Discount Amount:    " + " "
                + discntamttxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            try
            {
                cash_given = Convert.ToDouble(cashgvntxtbox.Text);
                total_amountPaid = Convert.ToDouble(totalBillstxtbox.Text);
                change = cash_given - total_amountPaid;
                changetxtbox.Text = change.ToString("N");
                displayListbox.Items.Add("Total Bills:  " + " "
                    + totalBillstxtbox.Text);
                displayListbox.Items.Add("Cash Given: " + " "
                    + cashgvntxtbox.Text);
                displayListbox.Items.Add("Change: " + " "
                    + changetxtbox.Text);
                displayListbox.Items.Add("Total No. of Items: " + " "
                    + totalqtytxtbox.Text);
            } 
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox");
                cashgvntxtbox.Clear();
                cashgvntxtbox.Focus();
            }
        }

        private void prnttranscBtn_Click(object sender, EventArgs e)
        {
            Lesson3Example3PrintForm print = new Lesson3Example3PrintForm();

            print.printDisplayListbox.Items.AddRange(this.displayListbox.Items);

            print.ShowDialog();

        }

        private void remordBtn_Click(object sender, EventArgs e)
        {
            displayListbox.Items.RemoveAt(displayListbox.SelectedIndex);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            can_change = false;
            bundleA.Checked = false;
            bundleB.Checked = false;

            displayPicture.Image = Image.FromFile("C:\\Users\\aron\\source\\repos\\squishyyyyyyyyy\\CRUZ_OOP_CPE201-NEW-\\Image New\\Default.png");
            
            A_Cokecheckbox.Enabled = false;
            A_FriedChickencheckbox.Enabled = false;
            A_Mojocheckbox.Enabled = false;
            A_Sidedishescheckbox.Enabled = false;
            A_Specialpizzacheckbox.Enabled = false;
            B_Carbonaracheckbox.Enabled = false;
            B_Dessertpizza.Enabled = false;
            B_FriedChickencheckbox.Enabled = false;
            B_Mojobcktcheckbox.Enabled = false;
            B_pizzacheckbox.Enabled = false;

            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            pizzano1.Checked = false;
            pizzano2.Checked = false;
            pizzano3.Checked = false;
            pizzano4.Checked = false;
            pizzano5.Checked = false;
            pizzano6.Checked = false;
            pizzano7.Checked = false;
            pizzano8.Checked = false;
            pizzano9.Checked = false;
            pizzano10.Checked = false;
            pizzano11.Checked = false;
            pizzano12.Checked = false;
            pizzano13.Checked = false;
            pizzano14.Checked = false;
            pizzano15.Checked = false;
            pizzano16.Checked = false;
            pizzano17.Checked = false;
            pizzano18.Checked = false;
            pizzano19.Checked = false;
            pizzano20.Checked = false;

            displayListbox.Items.Clear();

            
            can_change = true;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            if (can_change)
            {
                double price, discounted_amount, discount_amount;
                int qty;
                try
                {
                    price = Convert.ToDouble(pricetxtbox.Text);
                    qty = Convert.ToInt32(quantitytxtbox.Text);
                    discount_amount = Convert.ToDouble(discntamttxtbox.Text);
                    discounted_amount = (price * qty) - discount_amount;
                    total_qty += qty;
                    totalqtytxtbox.Text = total_qty.ToString();
                    total_amount += discounted_amount;
                    totalBillstxtbox.Text = total_amount.ToString("N");
                    discntedamttxtbox.Text = discounted_amount.ToString("N");
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter number of quantity ordered");
                    quantitytxtbox.Focus();
                }
            }
        }

        private void pizzano1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "500.99";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano1.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "550.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano2.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "600.99";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano3.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "700.50";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano4.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "500.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano5.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "750.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano6.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "700.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano7.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "850.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano8.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "450.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano9.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "650.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano10.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano11.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano12.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano13.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano14.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano15.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano16.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano17.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano18.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano19.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }

        private void pizzano20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discntamttxtbox.Text = "0.00";
            pricetxtbox.Text = "575.00";
            price = Convert.ToDouble(pricetxtbox.Text);
            displayListbox.Items.Add(pizzano20.Text + "   "
                + pricetxtbox.Text);
            quantitytxtbox.Text = "0";
            quantitytxtbox.Focus();
        }
    }
}
