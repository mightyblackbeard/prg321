using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class IC_Student_Roster : Dictionary<int,Student>
    {
        public void Add(int student_id, Student student)
        {
            base.Add(student_id, student);
        }        
    }
}
