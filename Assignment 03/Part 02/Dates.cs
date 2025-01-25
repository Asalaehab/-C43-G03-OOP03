using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03.Part_02
{
    internal class Dates
    {
        public static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date; // Returns the current date (without the time part)
        }

    }
}
