using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        //        public int age;
        public int numberOfHoursWorked;
        public double wage;
        public double? hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType employeeType;

        public static double taxRate = 0.15;

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double? rate, EmployeeType emType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate ?? 10;
            employeeType = emType;
        }


        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");

        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager!");
                wageBeforeTax = numberOfHoursWorked + hourlyRate.Value * 1.25;
            }
            else {
                wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
            }

            double taxAmount = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\nTax rate: \t {taxRate}");
        }

        public int CalcuateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            Console.WriteLine($"Got a bonus of {bonus}!");
            return bonus;
        }

        //public int CalculateBbonusAndBonusTax(int bonus, ref int bonustax)
        //{

        //    if (numberOfHoursWorked > 10)
        //        bonus *= 2;

        //    if (bonus >= 200)
        //    {
        //        bonustax = bonus / 10;
        //        bonus -= bonustax;
        //    }

        //    Console.WriteLine($"the employee got a bonus of {bonus} and the tax on the bonus is {bonustax}");
        //    return bonus;
        //}

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public static void UsingACustomType(StringBuilder stringBuilder)
        {
            List<string> list = new List<string>();
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"Tax rate is {taxRate}");
        }

        public double CalculateWage()
        {
            WageCalculations wageCaluclations = new WageCalculations();
            double calculatedValue = wageCaluclations.ComplexWageCalculation(wage, taxRate, 3, 40);
            return calculatedValue;
        }

    }
}
