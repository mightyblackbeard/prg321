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
    public partial class Checkout : Form
    {
        public List<BagItem> cart;

        public Checkout()
        {
            InitializeComponent();
            cart = new List<BagItem>();
        }

        private void Checkout_Shown(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                //Clear the grid view before displaying
                while (dgCart.Rows.Count > 0)
                {
                    dgCart.Rows.RemoveAt(0);
                }

                //display the carts contents
                foreach (BagItem b in cart)
                {
                    dgCart.Rows.Add(b.name, b.price, b.quantity, b.subTotal);
                }

                //Calculates prices
                Prices();
            }
            
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bRemoveFromCart_Click(object sender, EventArgs e)
        {            
            cart.RemoveAt(dgCart.CurrentRow.Index);
            dgCart.Rows.Remove(dgCart.CurrentRow);
        }

        private void Prices()
        {
            double rate;
            double sub = 0;
            double ship;
            double total;

            if(rbStandard.Checked)
            {
                rate = 0.05;
            }
            else if (rbThree.Checked)
            {
                rate = 0.07;
            }
            else
            {
                rate = 0.1;
            }

            foreach(BagItem b in cart)
            {
                sub += (b.price * b.quantity);
            }

            ship = sub * rate;

            total = sub + ship;

            lSubtotal.Text = sub.ToString("C");
            lShipFee.Text = ship.ToString("C");
            lTotal.Text = total.ToString("C");


        }
    }
}
