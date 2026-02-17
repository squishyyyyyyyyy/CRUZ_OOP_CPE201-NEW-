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
    public partial class Lesson3Example5 : Form
    {
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private Double netincome = 0.00,
            grossincome = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;
        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        public Lesson3Example5()
        {
            InitializeComponent();
        }

        private void Lesson3Example5_Load(object sender, EventArgs e)
        {
            incmbscpaytxtbox.Enabled = false;
            total_honopaytxtbox.Enabled = false;
            total_othpaytxtbox.Enabled = false;
            netinctxtbox.Enabled = false;
            grossinctxtbox.Enabled = false;
            total_deductxtbox.Enabled = false;
            sss_contritxtbox.Text = "0.00";
            pagibig_contritxtbox.Text = "0.00";
            philhlt_contritxtbox.Text = "0.00";
            tax_contritxtbox.Text = "0.00";
            sss_loantxtbox.Text = "0.00";
            pagibig_loantxtbox.Text = "0.00";
            faculty_savingsdeptxtbox.Text = "0.00";
            faculty_svgsloantxtbox.Text = "0.00";
            salary_loantxtbox.Text = "0.00";
            other_loantxtbox.Text = "0.00";
            other_loancombo.Text = "Select other deduction";
            other_loancombo.Items.Add("Other 1");
            other_loancombo.Items.Add("Other 2");
            other_loancombo.Items.Add("Other 3");
            other_loancombo.Items.Add("Other 4");
            picpathtxtbox.Hide();

        }

       
    }
}
