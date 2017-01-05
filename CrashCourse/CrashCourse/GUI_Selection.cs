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
            MessageBox.Show("Congratulations! You did something",
                "Doing Whatever You Want", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void lbWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSelected.Text = lbWorkers.SelectedItem.ToString();
        }
    }
}
