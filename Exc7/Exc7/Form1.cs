using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exc7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSelected.Text = lbBags.SelectedItem.ToString();
            bClear.Enabled = true;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbSelected.Text = "";
            bClear.Enabled = false;
        }
    }
}
