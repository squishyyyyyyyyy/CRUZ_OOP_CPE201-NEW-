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
    public partial class Lesson5Activity : Form
    {
        double grossincome = 0;
        double ssscontrib = 0;
        double philhealthcontrib = 0;
        double pagibigcontrib = 0;
        double taxcontrib = 0;

        public Lesson5Activity()
        {
            InitializeComponent();
        }

        private void Lesson5Activity_Load(object sender, EventArgs e)
        {
            {
                //department.Enabled = false;
                basicincincomecuttxt.Enabled = false;
                honoincincomecuttxt.Enabled = false;
                otherincincomecuttxt.Enabled = false;
                netincometxt.Enabled = false;
                totaldeductxt.Enabled = false;
                grossincometxt.Enabled = false;
                //firstname.Enabled = false;
                //middlename.Enabled = false;
                //surname.Enabled = false;
                //civilstatus.Enabled = false;
                //employeestat.Enabled = false;
                //designation.Enabled = false;
                ssscontritxt.Enabled = false;
                philhealthcontritxt.Enabled = false;
                pagibigcontritxt.Enabled = false;
                taxcontritxt.Enabled = false;

            }
        }

        private void grossBtn_Click(object sender, EventArgs e)
        {

            //basic income
            double basicincratephour, basicincnohours, basicincincomecut;
            basicincratephour = Convert.ToDouble(basicincratephourtxt.Text);
            basicincnohours = Convert.ToDouble(basicincnohourstxt.Text);
            basicincincomecut = basicincratephour * basicincnohours;
            basicincincomecuttxt.Text = basicincincomecut.ToString("N");

            // hono income
            double honoincratephour, honoincnohours, honoincincomecut;
            honoincratephour = Convert.ToDouble(basicincratephourtxt.Text);
            honoincnohours = Convert.ToDouble(basicincnohourstxt.Text);
            honoincincomecut = honoincratephour * honoincnohours;
            honoincincomecuttxt.Text = honoincincomecut.ToString("N");

            // other income
            double otherincratephour, otherincnohours, otherincincomecut;
            otherincratephour = Convert.ToDouble(basicincratephourtxt.Text);
            otherincnohours = Convert.ToDouble(basicincnohourstxt.Text);
            otherincincomecut = otherincratephour * otherincnohours;
            otherincincomecuttxt.Text = otherincincomecut.ToString("N");

            // gross income
            grossincome = basicincincomecut + honoincincomecut + otherincincomecut;
            grossincometxt.Text = grossincome.ToString("N");

            // regular deductions
            if (grossincome <= 20000)
            {
                ssscontrib = 581.30;
                philhealthcontrib = 300.00;
                pagibigcontrib = 200.00;
                taxcontrib = 0.00;
            }
            else if (grossincome <= 40000)
            {
                ssscontrib = 581.30;
                philhealthcontrib = 300.00;
                pagibigcontrib = 200.00;
                taxcontrib = 0.00;
            }
            else if (grossincome <= 60000)
            {
                ssscontrib = 581.30;
                philhealthcontrib = 300.00;
                pagibigcontrib = 200.00;
                taxcontrib = 0.00;
            }
            else if (grossincome <= 80000)
            {
                ssscontrib = 581.30;
                philhealthcontrib = 300.00;
                pagibigcontrib = 200.00;
                taxcontrib = 0.00;
            }
            else if (grossincome <= 100000)
            {
                ssscontrib = 581.30;
                philhealthcontrib = 300.00;
                pagibigcontrib = 200.00;
                taxcontrib = 0.00;
            }
            else
            {
                ssscontrib = 0.00;
                philhealthcontrib = 0.00;
                pagibigcontrib = 0.00;
                taxcontrib = 0.00;
            }
            ssscontritxt.Text = ssscontrib.ToString("N");
            philhealthcontritxt.Text = philhealthcontrib.ToString("N");
            pagibigcontritxt.Text = pagibigcontrib.ToString("N");
            taxcontritxt.Text = taxcontrib.ToString("N");
        }

        private void netBtn_Click(object sender, EventArgs e)
        {
            // regular deductions
            double ssscontri, philhealthcontri, pagibigcontri, taxcontri;
            ssscontri = Convert.ToDouble(ssscontritxt.Text);
            philhealthcontri = Convert.ToDouble(philhealthcontritxt.Text);
            pagibigcontri = Convert.ToDouble(pagibigcontritxt.Text);
            taxcontri = Convert.ToDouble(taxcontritxt.Text);

            // other deductions
            double sssloan, pagibigloan, facultydeposit, facultyloan, salaryloan, otherloan;
            sssloan = Convert.ToDouble(sssloantxt.Text);
            pagibigloan = Convert.ToDouble(pagibigloantxt.Text);
            facultydeposit = Convert.ToDouble(faculsavingsdeptxt.Text);
            facultyloan = Convert.ToDouble(faculsavingsloantxt.Text);
            salaryloan = Convert.ToDouble(salaryloantxt.Text);
            otherloan = Convert.ToDouble(otherloanstxt.Text);

            // total deductions
            double totaldeduc;
            totaldeduc = ssscontri + philhealthcontri + pagibigcontri + taxcontri + sssloan + pagibigloan + facultydeposit + facultyloan + salaryloan + otherloan;
            totaldeductxt.Text = totaldeduc.ToString("N");

            // net income
            double netincome;
            netincome = grossincome - totaldeduc;
            netincometxt.Text = netincome.ToString("N");
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            basicincratephourtxt.Clear();
            basicincnohourstxt.Clear();
            basicincincomecuttxt.Clear();
            honoincratephourtxt.Clear();
            honoincnohourstxt.Clear();
            honoincincomecuttxt.Clear();
            otherincratephourtxt.Clear();
            otherincnohourstxt.Clear();
            otherincincomecuttxt.Clear();
            grossincometxt.Clear();
            netincometxt.Clear();
            ssscontritxt.Clear();
            philhealthcontritxt.Clear();
            pagibigcontritxt.Clear();
            taxcontritxt.Clear();
            sssloantxt.Clear();
            pagibigloantxt.Clear();
            faculsavingsdeptxt.Clear();
            faculsavingsloantxt.Clear();
            salaryloantxt.Clear();
            otherloanstxt.Clear();
            totaldeductxt.Clear();
            paydate.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Lesson5ActivityPrintForm save = new Lesson5ActivityPrintForm();
            save.Show();

            save.companytxt.Text = "Lyceum of the Philippines University Cavite";
            save.employeecodetxt.Text = employeeno.Text;
            string fullname = firstname.Text + " " + middlename.Text + " " + surname.Text;
            save.employeenametxt.Text = fullname;
            save.departmenttxt.Text = department.Text;
            save.cutofftxt.Text = paydate.Text;
            save.payperiodtxt.Text = paydate.Text;
            save.basicpaytxt.Text = basicincincomecuttxt.Text.ToString();
            save.honotxt.Text = honoincincomecuttxt.Text.ToString();
            save.overtimetxt.Text = otherincincomecuttxt.Text.ToString();
            save.honoadjtxt.Text = "0.00";
            save.substxt.Text = "0.00";
            save.tardytxt.Text = "0.00";
            save.ssscontritxt.Text = ssscontritxt.Text.ToString();
            save.philcontritxt.Text = philhealthcontritxt.Text.ToString();
            save.taxcontritxt.Text = taxcontritxt.Text.ToString();
            save.hdmftxt.Text = pagibigcontritxt.Text.ToString();
            save.ssswisptxt.Text = "750.00";
        }
    }
}
