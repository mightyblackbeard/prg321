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

        private void Form1_Load(object sender, EventArgs e)
        {
            price = 0.00;
            shipRate = 0.0;
        }
   

        private void lbBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lbBags.SelectedIndex)
            {
                case 0:
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $50.00";
                    break;
                case 1:
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $45.00";
                    break;
                case 2:
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $40.00";
                    break;
                case 3:
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $25.00";
                    break;
                case 4:
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $30.00";
                    break;
                case 5:
                    tbSelected.Text = lbBags.SelectedItem.ToString() + " - $20.00";
                    break;
                default:
                    break;
            }
            nudQuantity.Value = 1;
            bClear.Enabled = true;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbSelected.Text = "";
            price = 0.00;
            nudQuantity.Value = 0;
            bClear.Enabled = false;
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            switch (lbBags.SelectedIndex)
            {
                case 0:
                    price = 50.00;
                    break;
                case 1:
                    price = 45.00;
                    break;
                case 2:
                    price = 40.00;
                    break;
                case 3:
                    price = 25.00;
                    break;
                case 4:
                    price = 30.00;
                    break;
                case 5:
                    price = 20.00;
                    break;
                default:
                    break;
            }

            price *= (double)nudQuantity.Value;     

            if (rbOvernight.Checked)
            {
                shipRate = .10;
                MessageBox.Show("YOUR ORDER: \n\n " + lbBags.SelectedItem + "(" + nudQuantity.Value.ToString() + ")" +
                    " - " + price.ToString("C") + "\n" + rbOvernight.Text + ":  " + (price * shipRate).ToString("C") + 
                    "\n\n Total: " + (price + (price * shipRate)).ToString("C"), "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(rbThree.Checked)
            {
                shipRate = .07;
                MessageBox.Show("YOUR ORDER: \n\n " + lbBags.SelectedItem + "(" + nudQuantity.Value.ToString() + ")" +
                    " - " + price.ToString("C") + "\n" + rbThree.Text + ":  " + (price * shipRate).ToString("C") + 
                    "\n\n Total: " + (price + (price * shipRate)).ToString("C"), "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                shipRate = .05;
                MessageBox.Show("YOUR ORDER: \n\n " + lbBags.SelectedItem + "(" + nudQuantity.Value.ToString() + ")"+
                    " - " + price.ToString("C") + "\n" + rbStandard.Text + ":  " + (price * shipRate).ToString("C") + 
                    "\n\n Total: " + (price + (price * shipRate)).ToString("C"), "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
