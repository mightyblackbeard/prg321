using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student("Josh", "Baca", 29, "Black");
            Student B = new Student("Duece", "Bigalow", 30, "Brown");

            A.m_printer = new ConsolePrinter();
            B.m_printer = new GUIPrinter();

            A.Debug();
            B.Debug();
        }
    }
}
