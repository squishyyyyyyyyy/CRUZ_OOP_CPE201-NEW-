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
    public partial class Lesson7Example4 : Form
        
    {
        public Lesson7Example4()
        {
            InitializeComponent();
        }

        private Double basic_netincome = 0.00,
                       basic_numhrs = 0.00,
                       basic_rate = 0.00,
                       hono_netincome = 0.00,
                       hono_numhrs = 0.00,
                       hono_rate = 0.00,
                       other_netincome = 0.00,
                       other_numhrs = 0.00,
                       other_rate = 0.00,
                       grossincome = 0.00,
                       tax = 0.00;

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            
            basic_ratehrstxt.Clear();
            basic_nohourstxt.Clear();
            basic_incometxt.Clear();
            hono_ratehrstxt.Clear();
            hono_nohourstxt.Clear();
            hono_incometxt.Clear();
            other_ratehrstxt.Clear();
            other_nohourstxt.Clear();
            other_incometxt.Clear();
            ssscontribtxt.Clear();
            pagibigcontribtxt.Clear();
            philcontribtxt.Clear();
            taxtxt.Clear();
            total_deducttxt.Clear();
            gross_inctxt.Clear();
            net_inctxt.Clear();
            
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sss_contrib = Convert.ToDouble(ssscontribtxt.Text);
                pagibig_contrib = Convert.ToDouble(pagibigcontribtxt.Text);
                philhealth_contrib = Convert.ToDouble(philcontribtxt.Text);
                tax = Convert.ToDouble(taxtxt.Text);
                total_deductions = sss_contrib + pagibig_contrib + philhealth_contrib + tax;
                net_income = grossincome - total_deductions;
                net_inctxt.Text = net_income.ToString("n");
                total_deducttxt.Text = total_deductions.ToString("n");
                gross_inctxt.Text = grossincome.ToString("n");
            }
            catch (Exception) 
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator.");
            }
        }

        private void other_nohourstxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                other_numhrs = Convert.ToDouble(other_nohourstxt.Text);
                other_rate = Convert.ToDouble(other_ratehrstxt.Text);
                other_netincome = other_numhrs * other_rate;
                other_incometxt.Text = other_netincome.ToString("n");

                grossincome = basic_netincome + hono_netincome + other_netincome;
                gross_inctxt.Text = grossincome.ToString("n");

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
                philcontribtxt.Text = philhealth_value.ToString("n");

                double sss_value = 0;
                if (grossincome <= 1000)
                {
                    sss_value = 36.30;
                }
                else
                {
                    double sss_employshare = 36.30;
                    for (int x = 1000; x <= 15750; x += 500)
                    {
                        if (grossincome >= x && grossincome < x + 500 || grossincome > x + 500)
                        {
                            sss_value = sss_employshare;
                        }
                        sss_employshare += 18.20;
                    }
                }
                ssscontribtxt.Text = sss_value.ToString("n");

                if (grossincome < (250000 / 24))
                {
                    taxtxt.Text = "0.00";
                }
                else if (grossincome > 10416.67 && grossincome <= 16666.67)
                {
                    tax = ((((grossincome * 24) - 250000) * 0.20) / 24);
                    taxtxt.Text = tax.ToString("n");
                }
                else if (grossincome > 16666.67 && grossincome <= 33333.33)
                {
                    tax = ((((grossincome * 24) - 400000) * 0.25 + 30000) / 24);
                    taxtxt.Text = tax.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 83333.33)
                {
                    tax = ((((grossincome * 24) - 800000) * 0.30 + 130000) / 24);
                    taxtxt.Text = tax.ToString("n");
                }
                else if (grossincome > 83333.33 && grossincome <= 333333.33)
                {
                    tax = ((((grossincome * 24) - 2000000) * 0.32 + 490000) / 24);
                    taxtxt.Text = tax.ToString("n");
                }
                else
                {
                    tax = ((((grossincome * 24) - 8000000) * 0.35 + 2410000) / 24);
                    taxtxt.Text = tax.ToString("n");
                }

                pagibigcontribtxt.Text = "100.00";

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator.");
            }
        }

        private void hono_nohourstxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(hono_nohourstxt.Text);
                hono_rate = Convert.ToDouble(hono_ratehrstxt.Text);
                hono_netincome = hono_numhrs * hono_rate;
                hono_incometxt.Text = hono_netincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator.");
            }
        }

        private void basic_nohours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Convert.ToDouble(basic_nohourstxt.Text);
                basic_rate = Convert.ToDouble(basic_ratehrstxt.Text);
                basic_netincome = basic_numhrs * basic_rate;
                basic_incometxt.Text = basic_netincome.ToString("n");

                grossincome = basic_netincome + hono_netincome + other_netincome;
                gross_inctxt.Text = grossincome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator.");
            }
        }

        private double sss_contrib,
                       philhealth_contrib,
                       pagibig_contrib,
                       total_deductions,
                       net_income;
        private void Lesson7Example4_Load(object sender, EventArgs e)
        {
            basic_incometxt.Enabled = false;
            hono_incometxt.Enabled = false;
            other_incometxt.Enabled = false;
            gross_inctxt.Enabled = false;
            net_inctxt.Enabled = false;
            total_deducttxt.Enabled = false;
            ssscontribtxt.Enabled = false;
            pagibigcontribtxt.Enabled = false;
            philcontribtxt.Enabled = false; 
            taxtxt.Enabled = false;
        }


    }
}
