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
    public partial class Lesson2Activity : Form
    {
        public Lesson2Activity()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif";
            openFileDialog.Title = "Select Photo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    displayimage.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Image: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            studnametxtbox.Clear();
            studnotxtbox.Clear();
            yrlvltxtbox.Clear();
            scholartxtbox.Clear();
            cournotxtbox.Clear();
            courcodetxtbox.Clear();
            courdesctxtbox.Clear();
            unitlectxtbox.Clear();
            unitlabtxtbox.Clear();
            timetxtbox.Clear();
            daytxtbox.Clear();
            credunittxtbox.Clear();
            total_nounitstxtbox.Clear();
            labfeetxtbox.Clear();
            total_tuitionfeetxtbox.Clear();
            total_miscfeetxtbox.Clear();
            ciscolabfeetxtbox.Clear();
            exambooklettxtbox.Clear();
            total_tuitionandfeetxtbox.Clear();
            total_tuitionfeefinal.Clear();
            total_miscfeefinal.Clear();
            total_nounitsfinal.Clear();
            total_tuitionandfeefinal.Clear();
            complabfeefinal.Clear();    
            ciscolabfeefinal.Clear();
            exambookletfinal.Clear();
            total_otherschfee.Clear();
        }

        private void Lesson2Activity_Load(object sender, EventArgs e)
        {
            progChoice.Items.Add("BS in Aeronautical Engineering");
            progChoice.Items.Add("BS in Civil Engineering");
            progChoice.Items.Add("BS in Computer Engineering");
            progChoice.Items.Add("BS in Electrical Engineering");
            progChoice.Items.Add("BS in Electronics Engineering");
            progChoice.Items.Add("BS in Industrial Engineering");
            progChoice.Items.Add("BS in Mechanical Engineering");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            courNolistbox.Items.Add(cournotxtbox.Text);
            courcodelistbox.Items.Add(courcodetxtbox.Text);
            courdesclistbox.Items.Add(courdesctxtbox.Text);
            unitleclistbox.Items.Add(unitlectxtbox.Text);
            unitlablistbox.Items.Add(unitlabtxtbox.Text);
            timelistbox.Items.Add(timetxtbox.Text);
            daylistbox.Items.Add(daytxtbox.Text);
            credunitlistbox.Items.Add(credunittxtbox.Text);
        }

        private void courdesclistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
