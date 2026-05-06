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
    public partial class Lesson3Example3PrintForm_Classes : Form
    {
        public Lesson3Example3PrintForm_Classes()
        {
            InitializeComponent();

            printDisplayListbox.Items.AddRange(printDisplayListbox.Items);
        }

        private void Lesson3Example3PrintForm_Classes_Load(object sender, EventArgs e)
        {

        }
    }
}
