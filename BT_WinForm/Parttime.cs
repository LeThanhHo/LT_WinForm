using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_WinForm
{
    public class PartTime : Emloyee
    {
        
            public int WorkingHours { get; set; }

            public override double Salary()
            {
                return WorkingHours * 25000;
            }
        
    }
}
