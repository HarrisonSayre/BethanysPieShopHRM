// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System.Text;

IEmployee bethany = new StoreManager("bethany", "smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25); //,EmployeeType.Manager);

Console.WriteLine("How many hours did Bethany work?: ");
int numberOfHours = 0;
string input = Console.ReadLine();
numberOfHours = int.Parse(input);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(numberOfHours);

////Employee george = new Employee("george", "jones", "george@snowball.be", new DateTime(1984, 3, 28), 30); //, EmployeeType.Research);
//IEmployee mary = new Manager("mary", "jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
//IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
//IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);
//IEmployee kim = new StoreManager("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22);

//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(mary);
//employees.Add(bobJunior);
//employees.Add(kate);
//employees.Add(kim);

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCompliment();
//}


//bobJunior.ResearchNewPieTastes(5);
//bobJunior.ResearchNewPieTastes(5);

//mary.DisplayEmployeeDetails();
//mary.PerformWork(25);
//mary.PerformWork();
//mary.PerformWork();
//mary.ReceiveWage();
//mary.AttendManagementMeeting

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork(8);
//bethany.PerformWork();
//bethany.PerformWork(3);
//bethany.ReceiveWage();

//Employee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "New street", "123", "123456", "Pie Ville");
//string streetName = jake.Address.Street;
//Console.WriteLine($"{jake.FirstName} lives on {jake.Address.Street}");

//Address newAddress = new Address("Another street", "444", "999999", "Donut town");
//jake.Address = newAddress;
//Console.WriteLine($"{jake.FirstName} moved to {jake.Address.Street} in {jake.Address.City}");

//mary.GiveBonus();