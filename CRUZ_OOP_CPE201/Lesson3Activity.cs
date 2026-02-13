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
        int lecture_fee = 1500;
        int lab_fee = 2500;
        int cisco_fee = 4500;
        int exambook_fee = 450;
        int sap_fee = 2000;
        decimal instmnt_charge = 0.5m;
        double total_credunits = 0;
        double total_tuitionfee = 0;
        double total_miscfee = 0;
        double comlab_fee = 0;
        double total_tui_fee = 0;

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
            
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

        }

        private void clstudinfobtn_Click(object sender, EventArgs e)
        {

        }

        private void clschcourbtn_Click(object sender, EventArgs e)
        {

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
