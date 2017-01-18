using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Student : Person, IContactable, IDebug
    {
        protected string m_email;
        protected int m_id;
        protected string m_phoneNumber;
        public IPrinter m_printer;
        private static int m_idCount = 0;

        public string Email
        {
            set
            {
                m_email = value;
            }
            get
            {
                return m_email;
            }
        }

        public int ID
        {
            set
            {
                m_id = value;
            }
            get
            {
                return m_id;
            }
        }

        public string PhoneNumber
        {
            set
            {
                m_phoneNumber = value;
            }
            get
            {
                return m_phoneNumber;
            }
        }

        public Student(string fName, string lName, int age, string haircolor) : base(age, fName, lName, haircolor)
        {
            ID = m_idCount;
            m_idCount = m_idCount + 1;
        }


        public string _prepare_debug_info()
        {
            string s;

            s = "ID: " + ID + "\nFirst Name: " + FirstName + "\nLast Name: " + LastName + "\nAge: " + Age
                + "\nHair Color: " + HairColor + "\nEmail: " + Email + "\nPhone Number: " + PhoneNumber;

            return s;
        }

        public void Debug()
        {
            string message = _prepare_debug_info();
            m_printer.Print(message);
        }

    }
}
