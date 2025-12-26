using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_WinForm
{
    public class Emloyee
    {
        public string Id {get; set;}
        public string Name { get; set;}
        public int Age { get; set;}
        public bool Gender { get; set;}
        public string PhoneNumber { get; set;}
        public string Part {  get; set;}
        public virtual double Salary()
        {
            return 0;
        }
    }
}
