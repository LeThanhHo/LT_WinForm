using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_WinForm
{
    public class FullTime : Emloyee
    {
            public int WorkingDays { get; set; }

            public override double Salary()
            {
                return WorkingDays * 425000;
            }
        }
    
}
