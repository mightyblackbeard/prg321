using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.rbInt.Checked = true;
        }

        private void Compute_CheckedChanged(object sender, EventArgs e)
        {
            decimal total = 0;

            if(cbSwim.Checked)
            {
                total += 25;
            }
            if (cbSnorkel.Checked)
            {
                total += 50;
            }
            if (cbDive.Checked)
            {
                total += 100;
            }

            if(rbBeg.Checked)
            {
                total += 10;
                ExpMod.Text = "Beginner - $10 additional charge";
            }
            else
            {
                if(rbAdv.Checked)
                {
                    total -= 15;
                    ExpMod.Text = "Advanced - $15 discount";
                }
                else
                {
                    ExpMod.Text = "";
                }
            }
            tbTotal.Text = total.ToString("C");
        }
    }
}
