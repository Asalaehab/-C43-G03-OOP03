using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is Working :)");
        }
    }

    class Manager :Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manger is Managing");
        }
    }
}
