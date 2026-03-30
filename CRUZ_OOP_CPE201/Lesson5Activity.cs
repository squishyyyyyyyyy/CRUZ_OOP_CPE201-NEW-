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
                basicincincomecuttxt.Clear();
                honoincincomecuttxt.Clear();
                otherincincomecuttxt.Clear();
                netincometxt.Clear();
                totaldeductxt.Clear();
                grossincometxt.Clear();
                //firstname.Enabled = false;
                //middlename.Enabled = false;
                //surname.Enabled = false;
                //civilstatus.Enabled = false;
                //employeestat.Enabled = false;
                //designation.Enabled = false;
                ssscontritxt.Clear();
                philhealthcontritxt.Clear();
                pagibigcontritxt.Clear();
                taxcontritxt.Clear();

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
            if (grossincome <= 5249)
            {
                ssscontrib = 760.00;

            }
            else if (grossincome >= 5250 && grossincome <= 5749.99)
            {
                ssscontrib = 835.00;
            }
            else if (grossincome >= 5750 && grossincome <= 6249.99)
            {
                ssscontrib = 910.00;

            }
            else if (grossincome >= 6250 && grossincome <= 6749.99)
            {
                ssscontrib = 985.00;
            }
            else if (grossincome >= 6750 && grossincome <= 7249.99)
            {
                ssscontrib = 1060.00;
            }
            else if (grossincome >= 7250 && grossincome <= 7749.99)
            {
                ssscontrib = 1135.00;
            }
            else if (grossincome >= 7750 && grossincome <= 8249.99)
            {
                ssscontrib = 1210.00;
            }
            else if (grossincome >= 8250 && grossincome <= 8749.99)
            {
                ssscontrib = 1285.00;
            }
            else if (grossincome >= 8750 && grossincome <= 9249.99)
            {
                ssscontrib = 1360.00;
            }
            else if (grossincome >= 9250 && grossincome <= 9749.99)
            {
                ssscontrib = 1435.00;
            }
            else if (grossincome >= 9750 && grossincome <= 10249.99)
            {
                ssscontrib = 1510.00;
            }
            else if (grossincome >= 10250 && grossincome <= 10749.99)
            {
                ssscontrib = 1585.00;
            }
            else if (grossincome >= 10750 && grossincome <= 11249.99)
            {
                ssscontrib = 1660.00;
            }
            else if (grossincome >= 11250 && grossincome <= 11749.99)
            {
                ssscontrib = 1735.00;
            }
            else if (grossincome >= 11750 && grossincome <= 12249.99)
            {
                ssscontrib = 1810.00;
            }
            else if (grossincome >= 12250 && grossincome <= 12749.99)
            {
                ssscontrib = 1885.00;
            }
            else if (grossincome >= 12750 && grossincome <= 13249.99)
            {
                ssscontrib = 1960.00;
            }
            else if (grossincome >= 13250 && grossincome <= 13749.99)
            {
                ssscontrib = 2035.00;
            }
            else if (grossincome >= 13750 && grossincome <= 14249.99)
            {
                ssscontrib = 2110.00;
            }
            else if (grossincome >= 14250 && grossincome <= 14749.99)
            {
                ssscontrib = 2185.00;
            }
            else if (grossincome >= 14750 && grossincome <= 15249.99)
            {
                ssscontrib = 2280.00;
            }
            else if (grossincome >= 15250 && grossincome <= 15749.99)
            {
                ssscontrib = 2355.00;
            }
            else if (grossincome >= 15750 && grossincome <= 16249.99)
            {
                ssscontrib = 2430.00;
            }
            else if (grossincome >= 16250 && grossincome <= 16749.99)
            {
                ssscontrib = 2505.00;
            }
            else if (grossincome >= 16750 && grossincome <= 17249.99)
            {
                ssscontrib = 2580.00;
            }
            else if (grossincome >= 17250 && grossincome <= 17749.99)
            {
                ssscontrib = 2655.00;
            }
            else if (grossincome >= 17750 && grossincome <= 18249.99)
            {
                ssscontrib = 2730.00;
            }
            else if (grossincome >= 18250 && grossincome <= 18749.99)
            {
                ssscontrib = 2805.00;
            }
            else if (grossincome >= 18750 && grossincome <= 19249.99)
            {
                ssscontrib = 2880.00;
            }
            else if (grossincome >= 19250 && grossincome <= 19749.99)
            {
                ssscontrib = 2955.00;
            }
            else if (grossincome >= 19750 && grossincome <= 20249.99)
            {
                ssscontrib = 3030.00;
            }
            else if (grossincome >= 20250 && grossincome <= 20749.99)
            {
                ssscontrib = 3105.00;
            }
            else if (grossincome >= 20750 && grossincome <= 21249.99)
            {
                ssscontrib = 3180.00;
            }
            else if (grossincome >= 21250 && grossincome <= 21749.99)
            {
                ssscontrib = 3255.00;
            }
            else if (grossincome >= 21750 && grossincome <= 22249.99)
            {
                ssscontrib = 3330.00;
            }
            else if (grossincome >= 22250 && grossincome <= 22749.99)
            {
                ssscontrib = 3405.00;
            }
            else if (grossincome >= 22750 && grossincome <= 23249.99)
            {
                ssscontrib = 3480.00;
            }
            else if (grossincome >= 23250 && grossincome <= 23749.99)
            {
                ssscontrib = 3555.00;
            }
            else if (grossincome >= 23750 && grossincome <= 24249.99)
            {
                ssscontrib = 3630.00;
            }
            else if (grossincome >= 24250 && grossincome <= 24749.99)
            {
                ssscontrib = 3705.00;
            }
            else if (grossincome >= 24750 && grossincome <= 25249.99)
            {
                ssscontrib = 3780.00;
            }
            else if (grossincome >= 25250 && grossincome <= 25749.99)
            {
                ssscontrib = 3855.00;
            }
            else if (grossincome >= 25750 && grossincome <= 26249.99)
            {
                ssscontrib = 3930.00;
            }
            else if (grossincome >= 26250 && grossincome <= 26749.99)
            {
                ssscontrib = 4005.00;
            }
            else if (grossincome >= 26750 && grossincome <= 27249.99)
            {
                ssscontrib = 4080.00;
            }
            else if (grossincome >= 27250 && grossincome <= 27749.99)
            {
                ssscontrib = 4155.00;
            }
            else if (grossincome >= 27750 && grossincome <= 28249.99)
            {
                ssscontrib = 4230.00;
            }
            else if (grossincome >= 28250 && grossincome <= 28749.99)
            {
                ssscontrib = 4305.00;
            }
            else if (grossincome >= 28750 && grossincome <= 29249.99)
            {
                ssscontrib = 4380.00;
            }
            else if (grossincome >= 29250 && grossincome <= 29749.99)
            {
                ssscontrib = 4455.00;
            }
            else if (grossincome >= 29750 && grossincome <= 30249.99)
            {
                ssscontrib = 4530.00;
            }
            else if (grossincome >= 30250 && grossincome <= 30749.99)
            {
                ssscontrib = 4605.00;
            }
            else if (grossincome >= 30750 && grossincome <= 31249.99)
            {
                ssscontrib = 4680.00;
            }
            else if (grossincome >= 31250 && grossincome <= 31749.99)
            {
                ssscontrib = 4755.00;
            }
            else if (grossincome >= 31750 && grossincome <= 32249.99)
            {
                ssscontrib = 4830.00;
            }
            else if (grossincome >= 32250 && grossincome <= 32749.99)
            {
                ssscontrib = 4905.00;
            }
            else if (grossincome >= 32750 && grossincome <= 33249.99)
            {
                ssscontrib = 4980.00;
            }
            else if (grossincome >= 33250 && grossincome <= 33749.99)
            {
                ssscontrib = 5055.00;
            }
            else if (grossincome >= 33750 && grossincome <= 34249.99)
            {
                ssscontrib = 5130.00;
            }
            else if (grossincome >= 34250 && grossincome <= 34749.99)
            {
                ssscontrib = 5205.00;
            }
            else
            {
                ssscontrib = 5280.00;
            }

            if (grossincome <= 10000)
            {
                philhealthcontrib = 500.00;
            }
            else if (grossincome > 10000 && grossincome <= 99999.99)
            {
                philhealthcontrib = grossincome * 0.05;
            }
            else
            {
                philhealthcontrib = 5000.00;
            }

            pagibigcontrib = 200.00;

            if (grossincome <= 250000)
            {
                taxcontrib = 0;
            }
            else if (grossincome <= 400000)
            {
                taxcontrib = 0.15 * (grossincome - 250000);
            }
            else if (grossincome <= 800000)
            {
                taxcontrib = 22500 + 0.20 * (grossincome - 400000);
            }
            else if (grossincome <= 2000000)
            {
                taxcontrib = 102500 + 0.25 * (grossincome - 800000);
            }
            else if (grossincome <= 8000000)
            {
                taxcontrib = 402500 + 0.30 * (grossincome - 2000000);
            }
            else
            {
                taxcontrib = 2202500 + 0.35 * (grossincome - 8000000);
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
            firstname.Clear();
            middlename.Clear();
            surname.Clear();
            civilstatus.Clear();
            employeestat.Clear();
            designation.Clear();
            qualified.Clear();
            employeeno.Clear();
            department.Clear();
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
            save.earningstxt.Text = grossincometxt.Text.ToString();
            save.deductionstxt.Text = totaldeductxt.Text.ToString();
            save.overtimetotaltxt.Text = otherincincomecuttxt.Text.ToString();
            save.grossearnings.Text = grossincometxt.Text.ToString();
            save.deductions.Text = totaldeductxt.Text.ToString();
            save.netpay.Text = netincometxt.Text.ToString();
        }
    }
}
