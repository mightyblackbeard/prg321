using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exc7
{
    
    public partial class Order : Form
    {
        private Dictionary<string, double> Bag_Prices;
        private List<BagItem> Items { get; set; }
        private Checkout c = new Checkout();
        public Order()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bag_Prices = new Dictionary<string, double>();
            Items = new List<BagItem>();
            string line;
            StreamReader file = new StreamReader(@"C:\Users\CCSDuser\Desktop\SCHOOL\PRG321\prg321\Exc7\Exc7\Bags.txt");
            while((line = file.ReadLine()) != null)
            {
                string[] arr = line.Split(',');
                Bag_Prices.Add(arr[0], Convert.ToDouble(arr[1]));
                lbBags.Items.Add(arr[0]);
            }
            c = new Checkout();

        }
   

        private void lbBags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBags.SelectedItem != null)
            {
                tbSelected.Text = lbBags.SelectedItem.ToString();
                tbPrice.Text = Bag_Prices[lbBags.SelectedItem.ToString()].ToString("C");
                nudQuantity.Value = 1;
                bClear.Enabled = true;
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tbSelected.Text = "";
            tbPrice.Text = "";
            nudQuantity.Value = 0;
            lbBags.ClearSelected();
            bClear.Enabled = false;
        }

        private void bAddToOrder_Click(object sender, EventArgs e)
        {
            BagItem b = new BagItem(tbSelected.Text,(int)nudQuantity.Value, Convert.ToDouble(tbPrice.Text.Split('$')[1]));

            bool exist = false;

            for (int i = 0; i < c.cart.Count; i++)
            {
                if (c.cart[i].name == b.name)
                {
                    c.cart[i].quantity += b.quantity;
                    c.cart[i].subTotal = c.cart[i].price * c.cart[i].quantity;
                    exist = true;
                    break;
                }
            }

            if(!exist)
            {
                c.cart.Add(b);
            }
         
            Clear();
        }

        private void bCheckout_Click(object sender, EventArgs e)
        {
            if(c.cart.Count > 0)
            {
                c.Show();
            }
            else
            {
                MessageBox.Show("Shopping Cart is Empty", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }
    }
}
