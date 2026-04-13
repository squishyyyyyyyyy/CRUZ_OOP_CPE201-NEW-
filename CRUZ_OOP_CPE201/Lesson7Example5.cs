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
    public partial class Lesson7Example5 : Form
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

        bool can_change = true;

        private void cancelBtn_Click(object sender, EventArgs e)
        { 
            can_change = false;
            emplynotxtbox.Clear();
            firstnametxtbox.Clear();
            middlenametxtbox.Clear();
            surnametxtbox.Clear();
            civilstattxtbox.Clear();
            desigtxtbox.Clear();
            nodepentstxtbox.Clear();
            emplyststxtbox.Clear();
            departmenttxtbox.Clear();
            incmbscpaytxtbox.Clear();
            no_hoursbscpaytxtbox.Clear();
            rthrbscpaytxtbox.Clear();
            total_honopaytxtbox.Clear();
            no_hourshonotxtbox.Clear();
            rthrhonotxtbox.Clear();
            total_othpaytxtbox.Clear();
            no_hoursothtxtbox.Clear();
            rthrothtxtbox.Clear();
            netinctxtbox.Clear();
            grossinctxtbox.Clear();
            sss_contritxtbox.Clear();
            pagibig_contritxtbox.Clear();
            philhlt_contritxtbox.Clear();
            tax_contritxtbox.Clear();
            sss_loantxtbox.Clear();
            pagibig_loantxtbox.Clear();
            faculty_savingsdeptxtbox.Clear();
            faculty_svgsloantxtbox.Clear();
            salary_loantxtbox.Clear();
            other_loantxtbox.Clear();
            other_loancombo.SelectedIndex = -1;
            other_loancombo.Text = "Select other deduction";
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
            total_deductxtbox.Clear();

            can_change = true;

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathtxtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void no_hoursbscpaytxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {   if (!can_change) return;
                basic_numhrs = Double.Parse(no_hoursbscpaytxtbox.Text);
                basic_rate = Convert.ToDouble(rthrbscpaytxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                incmbscpaytxtbox.Text = basic_netincome.ToString("N");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numeric values for Basic Pay hours and rate.");
            }

        }

        private void no_hourshonotxtbox_TextChanged(object sender, EventArgs e)
        {
            try
                {
                 if (!can_change) return;
                hono_numhrs = Convert.ToDouble(no_hourshonotxtbox.Text);
                hono_rate = Convert.ToDouble(rthrhonotxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                total_honopaytxtbox.Text = hono_netincome.ToString("N");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numeric values for Honorarium hours and rate.");
            }
        }

        private void no_hoursothtxtbox_TextChanged(object sender, EventArgs e)
        {
            try
                {
                 if (!can_change) return;
                other_numhrs = Convert.ToDouble(no_hoursothtxtbox.Text);
                other_rate = Convert.ToDouble(rthrothtxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                total_othpaytxtbox.Text = other_netincome.ToString("N");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                grossinctxtbox.Text = grossincome.ToString("N");

                double philhealth_value = 0;
                if (grossincome < 10000)
                {
                    philhealth_value = 137.50;
                }
                else
                {
                    double philhealth_employshare = 137.50;

                    for (int x = 10000; x <= 40000; x += 1000)
                    {
                        if (grossincome >= x && grossincome < x + 1000 || grossincome > x + 1000)
                        {
                            philhealth_value = philhealth_employshare;
                        }
                        philhealth_employshare += 13.75;
                    }
                }
                philhlt_contritxtbox.Text = philhealth_value.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numeric values for Overtime hours and rate.");
            }

            
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            can_change = false;
            emplynotxtbox.Clear();
            firstnametxtbox.Clear();
            middlenametxtbox.Clear();
            surnametxtbox.Clear();
            civilstattxtbox.Clear();
            desigtxtbox.Clear();
            nodepentstxtbox.Clear();
            emplyststxtbox.Clear();
            departmenttxtbox.Clear();
            incmbscpaytxtbox.Clear();
            no_hoursbscpaytxtbox.Clear();
            rthrbscpaytxtbox.Clear();
            total_honopaytxtbox.Clear();
            no_hourshonotxtbox.Clear();
            rthrhonotxtbox.Clear();
            total_othpaytxtbox.Clear();
            no_hoursothtxtbox.Clear();
            rthrothtxtbox.Clear();
            netinctxtbox.Clear();
            grossinctxtbox.Clear();
            sss_contritxtbox.Clear();
            pagibig_contritxtbox.Clear();
            philhlt_contritxtbox.Clear();
            tax_contritxtbox.Clear();
            sss_loantxtbox.Clear();
            pagibig_loantxtbox.Clear();
            faculty_savingsdeptxtbox.Clear();
            faculty_svgsloantxtbox.Clear(); 
            salary_loantxtbox.Clear();  
            other_loantxtbox.Clear();
            other_loancombo.SelectedIndex = -1;
            other_loancombo.Text = "Select other deduction";
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
            total_deductxtbox.Clear();

            can_change = true;
        }

        private void printpayslipBtn_Click(object sender, EventArgs e)
        {
            Lesson7Example5PrintForm print1 = new Lesson7Example5PrintForm();

            print1.priDisplayListbox.Items.AddRange(this.payslip_viewlistbox.Items);

            print1.Show();
        }

        private void prevpayslipdetBtn_Click(object sender, EventArgs e)
        {
            payslip_viewlistbox.Items.Add("Employee Number: " + ""
                + emplynotxtbox.Text);
            payslip_viewlistbox.Items.Add("First Name: " + ""
                + firstnametxtbox.Text);
            payslip_viewlistbox.Items.Add("Middle Name: " + ""
                + middlenametxtbox.Text);
            payslip_viewlistbox.Items.Add("Surname: " + ""
                + surnametxtbox.Text);
            payslip_viewlistbox.Items.Add("Designation: " + ""
                + desigtxtbox.Text);
            payslip_viewlistbox.Items.Add("Employee Status: " + ""
                + emplyststxtbox.Text);
            payslip_viewlistbox.Items.Add("Department: " + ""
                + departmenttxtbox.Text);
            payslip_viewlistbox.Items.Add("Pay Date: " + ""
                + paydatepicker.Text);
            payslip_viewlistbox.Items.Add("------------------------------------------------------------------------");
           
            payslip_viewlistbox.Items.Add("BP Num. of Hrs.: " + "P"
                + rthrbscpaytxtbox.Text);
            payslip_viewlistbox.Items.Add("BP Rate / Hr.: " + "P"
                + no_hoursbscpaytxtbox.Text);
            payslip_viewlistbox.Items.Add("BP Net Income: " + "P"
                + incmbscpaytxtbox.Text);
            payslip_viewlistbox.Items.Add("");

            payslip_viewlistbox.Items.Add("HI Num. of Hrs.: " + "P"
                + rthrhonotxtbox.Text);
            payslip_viewlistbox.Items.Add("HI Rate / Hr.: " + "P"
                + no_hourshonotxtbox.Text);
            payslip_viewlistbox.Items.Add("Honorarium Income: " + "P"
                + total_honopaytxtbox.Text);
            payslip_viewlistbox.Items.Add("");

            payslip_viewlistbox.Items.Add("OTI Num. of Hrs.: " + "P"
                + rthrothtxtbox.Text);
            payslip_viewlistbox.Items.Add("OTI Rate / Hr.: " + "P"
                + no_hoursothtxtbox.Text);
            payslip_viewlistbox.Items.Add("Other Income: " + "P"
                + total_othpaytxtbox.Text);
            payslip_viewlistbox.Items.Add("------------------------------------------------------------------------");

            payslip_viewlistbox.Items.Add("SSS Contribution: " + "P"
                + sss_contritxtbox.Text);
            payslip_viewlistbox.Items.Add("PhilHealth Contribution: " + "P"
                + philhlt_contritxtbox.Text);
            payslip_viewlistbox.Items.Add("Pag-IBIG Contribution: " + "P"
                + pagibig_contritxtbox.Text);
            payslip_viewlistbox.Items.Add("Tax Contribution: " + "P"
                + tax_contritxtbox.Text);
            
            payslip_viewlistbox.Items.Add("SSS Loan: " + "P"
                + sss_loantxtbox.Text);
            payslip_viewlistbox.Items.Add("Pag-IBIG Loan: " + "P"
                + pagibig_loantxtbox.Text);
            payslip_viewlistbox.Items.Add("Faculty Savings Deposit: " + "P"
                + faculty_savingsdeptxtbox.Text);
            payslip_viewlistbox.Items.Add("Faculty Savings Loan: " + "P"
                + faculty_svgsloantxtbox.Text);
            payslip_viewlistbox.Items.Add("Salary Loan: " + "P"
                + salary_loantxtbox.Text);
            payslip_viewlistbox.Items.Add("Other Loan: " + "P"
                + other_loantxtbox.Text);
            payslip_viewlistbox.Items.Add("------------------------------------------------------------------------");

            payslip_viewlistbox.Items.Add("Total Deduction: " + "P"
                + total_deductxtbox.Text);
            payslip_viewlistbox.Items.Add("Gross Income: " + "P"
                + grossinctxtbox.Text);
            payslip_viewlistbox.Items.Add("Net Income: " + "P"
                + netinctxtbox.Text);

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(sss_contritxtbox.Text);
                pagibig_contrib = Convert.ToDouble(pagibig_contritxtbox.Text);
                philhealth_contrib = Convert.ToDouble(philhlt_contritxtbox.Text);
                tax_contrib = Convert.ToDouble(tax_contritxtbox.Text);
                sss_loan = Convert.ToDouble(sss_loantxtbox.Text);
                pagibig_loan = Convert.ToDouble(pagibig_loantxtbox.Text);
                salary_loan = Convert.ToDouble(salary_loantxtbox.Text);
                faculty_sav_loan = Convert.ToDouble(faculty_svgsloantxtbox.Text);
                salary_savings = Convert.ToDouble(faculty_savingsdeptxtbox.Text);
                other_deduction = Convert.ToDouble(other_loantxtbox.Text);

                /*basic_numhrs = Double.Parse(no_hoursbscpaytxtbox.Text);
                basic_rate = Convert.ToDouble(rthrbscpaytxtbox.Text);
                basic_netincome = basic_numhrs * basic_rate;
                incmbscpaytxtbox.Text = basic_netincome.ToString("N");
                hono_numhrs = Convert.ToDouble(no_hourshonotxtbox.Text);
                hono_rate = Convert.ToDouble(rthrhonotxtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                total_honopaytxtbox.Text = hono_netincome.ToString("N");
                other_numhrs = Convert.ToDouble(no_hoursothtxtbox.Text);
                other_rate = Convert.ToDouble(rthrothtxtbox.Text);
                other_netincome = other_numhrs * other_rate;
                total_othpaytxtbox.Text = other_netincome.ToString("N");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                grossinctxtbox.Text = grossincome.ToString("N"); */

                total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
                total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
                total_deduction = total_contrib + total_loan;

                total_deductxtbox.Text = total_deduction.ToString("N");
                netincome = grossincome - total_deduction;
                netinctxtbox.Text = netincome.ToString("N");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numeric values for contributions and loans.");
            }
        }

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

        public Lesson7Example5()
        {
            InitializeComponent();
        }

        private void Lesson7Example5_Load(object sender, EventArgs e)
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
