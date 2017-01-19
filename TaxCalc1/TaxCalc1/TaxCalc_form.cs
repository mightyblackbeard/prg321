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
            Process process = new Process();
            process.StartInfo.FileName = "Console_TaxCalc.exe";
            process.StartInfo.Arguments = "1000 7.5";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            //string tax = cbTax.SelectedItem.ToString();
            //tax = tax.Split('%')[0];
            //double income = Convert.ToDouble(tbIncome.Text);

            //double taxRate = Convert.ToDouble(tax) / 100;

            tbTotal.Text = output;
            //tbTotal.Text = (income * taxRate).ToString("c");
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
            //double income;

            //if (!(double.TryParse(tbIncome.Text, out income)))
            //{
            //    MessageBox.Show("Invalid input");
            //}

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
