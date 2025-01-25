using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message From BaseClass");
        }
    } 
    internal class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message From Derived Class");
        }
    } 
    internal class DerivedClass2 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message From Derived Class");
        }
    }

}
