using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Manager : Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double? rate) 
            : base(first, last, em, bd, rate)
        {

        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            else
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
            //base.GiveBonus();
        }

        public void AttendManagamentMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine("Attended meeting"); 
        }

    }
}
