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
    public partial class Lesson3Activity : Form
    {
        int lecture_fee = 1500;
        int lab_fee = 2500;
        int cisco_fee = 4500;
        int exambook_fee = 450;
        int sap_fee = 2000;
        double total_credunits = 0;
        double total_tuitionfee = 0;
        double total_miscfee = 0;
        double comlab_fee = 0;
        double total_tui_fee = 0;

        public Lesson3Activity()
        {
            InitializeComponent();
        }

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
    }
}
