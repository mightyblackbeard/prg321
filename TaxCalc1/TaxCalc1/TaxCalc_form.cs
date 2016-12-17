using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaxCalc1
{
    public partial class TaxCalc_form : Form
    {
        public TaxCalc_form()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            string executableParameter = "1000 7.5";
            Process.Start("Console_TaxCalc.exe", executableParameter );
            // ProcessStartInfo processStartInfo = new ProcessStartInfo("Console_TaxCalc", executableParameter);
            string tax = cbTax.SelectedItem.ToString();
            tax = tax.Split('%')[0];
            double income = Convert.ToDouble(tbIncome.Text);

            double taxRate = Convert.ToDouble(tax) / 100;

            tbTotal.Text = (income * taxRate).ToString("c");
        }

        private void bCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Calculate(this, e);
            }
        }

        private void isValid()
        {
            double income;

            if (!(double.TryParse(tbIncome.Text, out income)))
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void tbIncome_Leave(object sender, EventArgs e)
        {
            isValid();
        }

        private void tbIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(e.KeyChar == '.') && !(Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (tbIncome.Text.IndexOf(".") > -1))
            {
                e.Handled = true;
            }

        }
    }
}
