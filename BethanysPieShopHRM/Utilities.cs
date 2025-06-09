using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
    public static int CalculateYearlyWage(int monthlyWage, int numberofMonthsWorked)
        {

            //Console.WriteLine($"Yearly wage: {monthlyWage * numberofMonthsWorked}");
            if (numberofMonthsWorked == 12)
            {
                return monthlyWage * (numberofMonthsWorked + 1); //bonus month
            }
            return monthlyWage * numberofMonthsWorked;
        }

    }
}
