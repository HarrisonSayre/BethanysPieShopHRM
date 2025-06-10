// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System.Text;

Employee bethany = new Employee("bethany", "smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25); //,EmployeeType.Manager);
Employee george = new Employee("george", "jones", "george@snowball.be", new DateTime(1984, 3, 28), 30); //, EmployeeType.Research);
Manager mary = new Manager("mary", "jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);

mary.DisplayEmployeeDetails();
mary.PerformWork(25);
mary.PerformWork();
mary.PerformWork();
mary.ReceiveWage();

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork(8);
//bethany.PerformWork();
//bethany.PerformWork(3);
//bethany.ReceiveWage();

