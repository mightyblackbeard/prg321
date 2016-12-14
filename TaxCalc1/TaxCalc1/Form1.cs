using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            string tax = cbTax.SelectedItem.ToString();
            tax = tax.Split('%')[0];
            double income = Convert.ToDouble(tbIncome.Text);

            double taxRate = Convert.ToDouble(tax) / 100;

            tbTotal.Text = (income * taxRate).ToString("c");
        }
    }
}
