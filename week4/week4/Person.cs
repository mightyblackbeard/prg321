using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Person
    {
        protected int m_age;
        protected string m_FirstName;
        protected string m_LastName;
        protected string m_hairColor;
        private static int m_NumRef = 0;

        public int Age
        {
            set
            {
                m_age = value;
            }
            get
            {
                return m_age;
            }
        }

        public string FirstName
        {
            set
            {
                m_FirstName = value;
            }
            get
            {
                return m_FirstName;
            }
        }

        public string LastName
        {
            set
            {
                m_LastName = value;
            }
            get
            {
                return m_LastName;
            }
        }

        public string HairColor
        {
            set
            {
                m_hairColor = value;
            }
            get
            {
                return m_hairColor;
            }
        }

        public Person()
        {
            this.m_age = 0;
            this.m_FirstName = "";
            this.m_LastName = "Default";
            this.m_hairColor = "Purple";
            m_NumRef = m_NumRef +1;
        }

        public Person(int age, string fname, string lname, string hair)
        {
            this.m_age = age;
            this.m_FirstName = fname;
            this.m_LastName = lname;
            this.m_hairColor = hair;
            m_NumRef = m_NumRef + 1;
        }

        public int NumberOfReferences()
        {
            return m_NumRef;
        }

        public void PrintOutContent()
        {
            Console.WriteLine("Students Name: " + this.m_FirstName + " " + this.m_LastName);
            Console.WriteLine("Age: " + this.m_age);
            Console.WriteLine("Hair Color: " + this.m_hairColor);
        }

    }
}
