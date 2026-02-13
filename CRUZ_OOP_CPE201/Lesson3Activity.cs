using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUZ_OOP_CPE201
{
    public partial class Lesson3Activity : Form
    {

        public Lesson3Activity()
        {
            InitializeComponent();
        }
       
        double comlabfee = 0;
        double sapfee = 2000;
        double ciscolabfee = 4500;
        double exambookfee = 450;

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox146_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lesson3Activity_Load(object sender, EventArgs e)
        {
            progChoice.Items.Add("BS in Aeronautical Engineering");
            progChoice.Items.Add("BS in Civil Engineering");
            progChoice.Items.Add("BS in Computer Engineering");
            progChoice.Items.Add("BS in Electrical Engineering");
            progChoice.Items.Add("BS in Electronics Engineering");
            progChoice.Items.Add("BS in Industrial Engineering");
            progChoice.Items.Add("BS in Mechanical Engineering");

            yrlvl.Items.Add("1st Year");
            yrlvl.Items.Add("2nd Year");
            yrlvl.Items.Add("3rd Year");
            yrlvl.Items.Add("4th Year");

            mode.Items.Add("Installment");
            modepaytxt.Text = "Installment";
            instchartxt.Text = "8000";

            comlabfeetxt.Text = comlabfee.ToString();
            sapfeetxt.Text = sapfee.ToString();
            ciscolabtxt.Text = ciscolabfee.ToString();
            exambooktxt.Text = exambookfee.ToString();

        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            double total_lecunits = Convert.ToInt32(lec1.Text) + Convert.ToInt32(lec2.Text) + Convert.ToInt32(lec3.Text) + Convert.ToInt32(lec4.Text) + Convert.ToInt32(lec5.Text) + Convert.ToInt32(lec6.Text) + Convert.ToInt32(lec7.Text);
            double total_tuition = Convert.ToInt32(total_crunits.Text) * 1500;
            total_tuitiontxt.Text = total_tuition.ToString();

            double total_labunits = Convert.ToInt32(lab1.Text) + Convert.ToInt32(lab2.Text) + Convert.ToInt32(lab3.Text) + Convert.ToInt32(lab4.Text) + Convert.ToInt32(lab5.Text) + Convert.ToInt32(lab6.Text) + Convert.ToInt32(lab7.Text);
            comlabfee = 2500 * (total_labunits);
            comlabfeetxt.Text = comlabfee.ToString();
            double total_misc = comlabfee + sapfee + ciscolabfee + exambookfee;

            misctxt.Text = total_misc.ToString();
            total_othschtxt.Text = total_misc.ToString();

            comlabfee = (Convert.ToDouble(lab1.Text) + Convert.ToDouble(lab2.Text) + Convert.ToDouble(lab3.Text) + Convert.ToDouble(lab4.Text) + Convert.ToDouble(lab5.Text) + Convert.ToDouble(lab6.Text) + Convert.ToDouble(lab7.Text)) * 2500;

            double total_tuitandfees = total_tuition + total_misc;
            total_tui_feetxt.Text = total_tuitandfees.ToString();

            double instmnt_fee = (total_tuitandfees - 8000) / 3;
            firstinstxt.Text = instmnt_fee.ToString("C");
            secondinstxt.Text = instmnt_fee.ToString("C");
            thirdinstxt.Text = instmnt_fee.ToString("C");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

        }

        private void clstudinfobtn_Click(object sender, EventArgs e)
        {
            studnametxtbox.Clear();
            studnotxtbox.Clear();
            progChoice.SelectedIndex = -1;
            yrlvl.SelectedIndex = -1;
            scholar.SelectedIndex = -1;
        }

        private void clschcourbtn_Click(object sender, EventArgs e)
        {
            cc1.Clear();
            cc2.Clear();
            cc3.Clear();
            cc4.Clear();
            cc5.Clear();
            cc6.Clear();
            cc7.Clear();

            sec1.Clear();
            sec2.Clear();
            sec3.Clear();
            sec4.Clear();
            sec5.Clear();
            sec6.Clear();
            sec7.Clear();

            desc1.Clear();
            desc2.Clear();
            desc3.Clear();
            desc4.Clear();
            desc5.Clear();
            desc6.Clear();
            desc7.Clear();

            lec1.Clear();
            lec2.Clear();
            lec3.Clear();
            lec4.Clear();
            lec5.Clear();
            lec6.Clear();
            lec7.Clear();

            lab1.Clear();
            lab2.Clear();
            lab3.Clear();
            lab4.Clear();
            lab5.Clear();
            lab6.Clear();
            lab7.Clear();

            cred1.Clear();
            cred2.Clear();
            cred3.Clear();
            cred4.Clear();
            cred5.Clear();
            cred6.Clear();
            cred7.Clear();

            time1.Clear();
            time2.Clear();
            time3.Clear();
            time4.Clear();
            time5.Clear();
            time6.Clear();
            time7.Clear();

            day1.Clear();
            day2.Clear();
            day3.Clear();
            day4.Clear();
            day5.Clear();
            day6.Clear();
            day7.Clear();

            room1.Clear();
            room2.Clear();
            room3.Clear();
            room4.Clear();
            room5.Clear();
            room6.Clear();
            room7.Clear();

        }

        private void lec1_TextChanged(object sender, EventArgs e)
        {
            if (lec1.Text != "" && lab1.Text != "")
            {
                cred1.Text = (Convert.ToInt32(lec1.Text) + Convert.ToInt32(lab1.Text)).ToString();
            }
                
        }

        private void lab1_TextChanged(object sender, EventArgs e)
        {
            if (lec1.Text != "" && lab1.Text != "")
            {
                cred1.Text = (Convert.ToInt32(lec1.Text) + Convert.ToInt32(lab1.Text)).ToString();
            }
        }

        private void lec2_TextChanged(object sender, EventArgs e)
        {
            if (lec2.Text != "" && lab2.Text != "")
            {
                cred2.Text = (Convert.ToInt32(lec2.Text) + Convert.ToInt32(lab2.Text)).ToString();
            }
        }

        private void lab2_TextChanged(object sender, EventArgs e)
        {
            if (lec2.Text != "" && lab2.Text != "")
            {
                cred2.Text = (Convert.ToInt32(lec2.Text) + Convert.ToInt32(lab2.Text)).ToString();
            }
        }

        private void lec3_TextChanged(object sender, EventArgs e)
        {
            if (lec3.Text != "" && lab3.Text != "")
            {
                cred3.Text = (Convert.ToInt32(lec3.Text) + Convert.ToInt32(lab3.Text)).ToString();
            }
        }

        private void lab3_TextChanged(object sender, EventArgs e)
        {
            if (lec3.Text != "" && lab3.Text != "")
            {
                cred3.Text = (Convert.ToInt32(lec3.Text) + Convert.ToInt32(lab3.Text)).ToString();
            }
        }

        private void lec4_TextChanged(object sender, EventArgs e)
        {
            if (lec4.Text != "" && lab4.Text != "")
            {
                cred4.Text = (Convert.ToInt32(lec4.Text) + Convert.ToInt32(lab4.Text)).ToString();
            }
        }

        private void lab4_TextChanged(object sender, EventArgs e)
        {
            if (lec4.Text != "" && lab4.Text != "")
            {
                cred4.Text = (Convert.ToInt32(lec4.Text) + Convert.ToInt32(lab4.Text)).ToString();
            }
        }

        private void lec5_TextChanged(object sender, EventArgs e)
        {
            if (lec5.Text != "" && lab5.Text != "")
            {
                cred5.Text = (Convert.ToInt32(lec5.Text) + Convert.ToInt32(lab5.Text)).ToString();
            }
        }

        private void lab5_TextChanged(object sender, EventArgs e)
        {
            if (lec5.Text != "" && lab5.Text != "")
            {
                cred5.Text = (Convert.ToInt32(lec5.Text) + Convert.ToInt32(lab5.Text)).ToString();
            }
        }

        private void lec6_TextChanged(object sender, EventArgs e)
        {
            if (lec6.Text != "" && lab6.Text != "")
            {
                cred6.Text = (Convert.ToInt32(lec6.Text) + Convert.ToInt32(lab6.Text)).ToString();
            }
        }

        private void lab6_TextChanged(object sender, EventArgs e)
        {
            if (lec6.Text != "" && lab6.Text != "")
            {
                cred6.Text = (Convert.ToInt32(lec6.Text) + Convert.ToInt32(lab6.Text)).ToString();
            }
        }

        private void lec7_TextChanged(object sender, EventArgs e)
        {
            if (lec7.Text != "" && lab7.Text != "")
            {
                cred7.Text = (Convert.ToInt32(lec7.Text) + Convert.ToInt32(lab7.Text)).ToString();
            }
        }

        private void lab7_TextChanged(object sender, EventArgs e)
        {
            if (lec7.Text != "" && lab7.Text != "")
            {
                cred7.Text = (Convert.ToInt32(lec7.Text) + Convert.ToInt32(lab7.Text)).ToString();
            }
        }

        private void cred1_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void cred2_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void cred3_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void cred4_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void cred5_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void cred6_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void cred7_TextChanged(object sender, EventArgs e)
        {
            if (cred1.Text != "" && cred2.Text != "" && cred3.Text != "" && cred4.Text != "" && cred5.Text != "" && cred6.Text != "" && cred7.Text != "")
            {
                total_crunits.Text = (Convert.ToInt32(cred1.Text) + Convert.ToInt32(cred2.Text) + Convert.ToInt32(cred3.Text) + Convert.ToInt32(cred4.Text) + Convert.ToInt32(cred5.Text) + Convert.ToInt32(cred6.Text) + Convert.ToInt32(cred7.Text)).ToString();
            }
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
