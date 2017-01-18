using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public interface IContactable
    {
        string Email { set; get; }
        string PhoneNumber { set; get; }
    }
}
