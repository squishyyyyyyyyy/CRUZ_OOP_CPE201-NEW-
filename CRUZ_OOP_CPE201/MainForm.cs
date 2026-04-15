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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void activiy1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity activity1 = new Activity();
            activity1.MdiParent = this;
            activity1.Show();
        }

        private void activity2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 activity2 = new Form1();
            activity2.MdiParent = this;
            activity2.Show();
        }

        private void activity3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 activity3 = new Activity3();
            activity3.MdiParent = this;
            activity3.Show();
        }

        private void lesson2ActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson2Activity lesson2Activity = new Lesson2Activity();
            lesson2Activity.MdiParent = this;
            lesson2Activity.Show();
        }

        private void lesson3ActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson3Activity lesson3Activity = new Lesson3Activity();
            lesson3Activity.MdiParent = this;
            lesson3Activity.Show();
        }

        private void lesson3Example3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson3Example3 lesson3Example3 = new Lesson3Example3();
            lesson3Example3.MdiParent = this;
            lesson3Example3.Show();
        }

        private void lesson3Example5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson3Example5 lesson3Example5 = new Lesson3Example5();
            lesson3Example5.MdiParent = this;
            lesson3Example5.Show();
        }

        private void lesson5ActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5Activity lesson5Activity = new Lesson5Activity();
            lesson5Activity.MdiParent = this;
            lesson5Activity.Show();
        }

        private void lesson7Example4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson7Example4 lesson7Example4 = new Lesson7Example4();
            lesson7Example4.MdiParent = this;
            lesson7Example4.Show();
        }

        private void lesson7Example5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson7Example5 lesson7Example5 = new Lesson7Example5();
            lesson7Example5.MdiParent = this;
            lesson7Example5.Show();
        }

        private void lesson7Example6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson7Example6 lesson7Example6 = new Lesson7Example6();
            lesson7Example6.MdiParent = this;
            lesson7Example6.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fINALSACTIVITIESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}
