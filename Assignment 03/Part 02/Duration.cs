using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03.Part_02
{
    internal class Duration
    {
        #region Properties

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructor
        Duration() { }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int x)
        {
            Hours = (x / 60)/60;
            Minutes = (x-(Hours*60*60)) / 60;
            Seconds = x % 60;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Hours :{Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
        }

        #endregion


        #region Overloading 
        public static Duration operator +(Duration D1, Duration D2)
        {
            return new Duration()
            {
                Hours = (D1?.Hours ?? 0) + (D2?.Hours ?? 0),
                Minutes = (D1?.Minutes ?? 0) + (D2?.Minutes ?? 0),
                Seconds = (D1?.Seconds ?? 0) + (D2?.Seconds ?? 0)
            };
        }
        public static Duration operator -(Duration D1, Duration D2)
        {
            Duration D = new Duration();
            if (D1.Hours >= D2.Hours) 
            {
                D.Hours = (D1?.Hours ?? 0) - (D2?.Hours ?? 0);
            }
            else {
                D.Hours = 0;
            }
            if (D1?.Minutes >= D2?.Minutes)
            {
                D.Minutes = (D1?.Minutes ?? 0) - (D2?.Minutes ?? 0);
            }
            else
            {
                D.Minutes = 0;
            }
            if (D1?.Seconds > D2?.Seconds)
            {
                D.Seconds = (D1?.Seconds ?? 0) - (D2?.Seconds ?? 0);
             }
            else
            {
                D.Seconds = 0;
            }
            return D; 
            
        }
        public static Duration operator +(Duration D1, int x)
        {
            int h = (x / 60) / 60;
            int m = (x - (h * 60 * 60)) / 60;
                int s = x % 60;
            return new Duration()
            {
                Hours = (D1?.Hours ?? 0) +h ,
                Minutes = (D1?.Minutes ?? 0) +m ,
                Seconds = (D1?.Seconds ?? 0) + s
            };
        } 
        public static Duration operator +(int x,Duration D1)
        {
            int h = (x / 60) / 60;
            int m = (x - (h * 60 * 60)) / 60;
                int s = x % 60;
            return new Duration()
            {
                Hours = (D1?.Hours ?? 0) +h ,
                Minutes = (D1?.Minutes ?? 0) +m ,
                Seconds = (D1?.Seconds ?? 0) + s
            };
        }
        public static Duration operator ++(Duration D1)
        {
            return new Duration()
            {
                Hours = (D1?.Hours ?? 0) + 0,
                Minutes = (D1?.Minutes ?? 0) + 1,
                Seconds = (D1?.Seconds ?? 0) + 0
            };
        }
        public static Duration operator --(Duration D1)
        {
            return new Duration()
            {
                Hours = (D1?.Hours ?? 0) - 0,
                Minutes = (D1?.Minutes ?? 0) - 1,
                Seconds = (D1?.Seconds ?? 0) - 0
            };
        }
        public static bool operator >(Duration D1, Duration D2)
        {
            if(D1.Hours>D2.Hours && D1.Minutes > D2.Minutes && D1.Seconds > D2.Seconds)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            if (D1.Hours <= D2.Hours && D1.Minutes <= D2.Minutes && D1.Seconds < D2.Seconds)
            {
                return true;
            }
            return false;
        }
       
        public static explicit operator DateTime(Duration duration)
        {
            
            DateTime baseDate = DateTime.Today;
            return baseDate.AddHours(duration.Hours)
                           .AddMinutes(duration.Minutes)
                           .AddSeconds(duration.Seconds);
        }
        #endregion
    }
}
