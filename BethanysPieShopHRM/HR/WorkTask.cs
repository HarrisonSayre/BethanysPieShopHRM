using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal struct WorkTask
    {

        public int hours;
        public string description;

        public void PerforWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hours has been done.");        }
    }
}
