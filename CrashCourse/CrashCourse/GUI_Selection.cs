using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashCourse
{
    public partial class GUI_Selection : Form
    {
        public GUI_Selection()
        {
            InitializeComponent();
        }

        private void bProSel_Click(object sender, EventArgs e)
        {
            tbSelected.Text = lbWorkers.SelectedItem.ToString();
        }
    }
}
