using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Services
{
    public class AgeCheck : IAgeCheck
    {
        int Age(DateTime birthDate, DateTime currentDate)
        {
            int YearsDiff = new DateTime(currentDate.Subtract(birthDate).Ticks).Year - 1;
            return YearsDiff;
        }

    }
}
