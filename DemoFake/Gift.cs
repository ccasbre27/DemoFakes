using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFake
{
    public class Gift : IGift
    {
     
        public bool IsWeekend ()
        {
            return DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday;
        }

        public int BirthYear(int age)
        {
            return DateTime.Now.Year - age;
        }

    }
}
