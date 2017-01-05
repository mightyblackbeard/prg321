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
        private double price;
        private double shipRate;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lbBags.SelectedIndex)
            {
                case 0:
                    price = 50.00;
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $50.00";
                    break;
                case 1:
                    price = 45.00;
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $45.00";
                    break;
                case 2:
                    price = 40.00;
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $40.00";
                    break;
                case 3:
                    price = 25.00;
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $25.00";
                    break;
                case 4:
                    price = 30.00;
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $30.00";
                    break;
                case 5:
                    price = 20.00;
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $20.00";
                    break;
                default:
                    break;
            }
           
            bClear.Enabled = true;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbSelected.Text = "";
            price = 0.00;
            bClear.Enabled = false;
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            if (rbOvernight.Checked)
            {
                shipRate = .10;
                MessageBox.Show("YOUR ORDER: \n\n " + tbSelected.Text + "\n" + rbOvernight.Text +
                    ":  " + (price * shipRate).ToString("C") + "\n\n Total: " + (price + (price * shipRate)).ToString("C"), "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(rbThree.Checked)
            {
                shipRate = .07;
                MessageBox.Show("YOUR ORDER: \n\n " + tbSelected.Text + "\n" + rbThree.Text +
                    ":  " + (price * shipRate).ToString("C") + "\n\n Total: " + (price + (price * shipRate)).ToString("C"), "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                shipRate = .05;
                MessageBox.Show("YOUR ORDER: \n\n " + tbSelected.Text + "\n" + rbStandard.Text +
                    ":  " + (price * shipRate).ToString("C") + "\n\n Total: " + (price + (price * shipRate)).ToString("C"), "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
