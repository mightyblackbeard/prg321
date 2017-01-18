using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public class GUIPrinter : IPrinter
    {
        public void Print(string s)
        {
            MessageBox.Show(s);
        }
    }
}
