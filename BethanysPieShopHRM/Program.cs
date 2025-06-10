// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System.Text;

Employee bethany = new Employee("bethany", "smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new Employee ("george", "jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("mary", "jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobjunior = new Employee("bob", "spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("kevin", "marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("kate", "greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("kim", "jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

Employee[] employees = new Employee[7];



employees[0] = bethany;
employees[1] = george;
employees[2] = mary;
employees[3] = bobjunior;
employees[4] = kevin;
employees[5] = kate;
employees[6] = kim;

foreach (Employee e in employees)
{
    e.DisplayEmployeeDetails();
    var numberofHoursWorked = new Random().Next(25);
    e.PerformWork(numberofHoursWorked);
    e.ReceiveWage();
}

Array.Sort(employees);

//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");
//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");


//Console.WriteLine("Create an employee");
//Console.WriteLine("-------------------------\n");


//Employee.taxRate = 0.02;

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

//bethany.PerformWork(7);
//bethany.ReceiveWage();
//bethany.DisplayEmployeeDetails();


//string bethanyAsJson = bethany.ConvertToJson();
//Console.WriteLine(bethanyAsJson);

//WorkTask task;
//task.description = "Bake pies";
//task.hours = 3;
//task.PerforWorkTask();

//Console.WriteLine("Create an employee");
//Console.WriteLine("-------------------------\n");

//Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), null, EmployeeType.Research);

//int[] sampleArray1 = new int[5];
//int[] sampleArray2 = new int[] { 0, 1, 2, 3, 4 };
////int[] sampleArray3 = new int[5] { 0, 1, 2, 3, 4, 5};

//Console.WriteLine("How many IDs to register?");

//int length = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[length];

//var testId = employeeIds[0];

//var errorId = employeeIds[length];


//george.PerformWork(12);
//george.ReceiveWage();
//george.DisplayEmployeeDetails();

//Employee.DisplayTaxRate();

//Employee mysteryEmployee = null;
//mysteryEmployee.DisplayEmployeeDetails();


//Customer customer = new Customer();

//bethany.CalculateWage();



///Account account = new Account("1234567890");
//account.AccountNumber = "9876542210";

//string name = "bethany";
//string anotherName = name;
//name += " smith";

//Console.WriteLine("Name :" + name);
//Console.WriteLine("another name: " + anotherName);

//string uppperCaseName = name.ToUpper();

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Uppercase name : " + uppperCaseName);

//string firstName = "Bethany";
//string lastName = "Smith";

//StringBuilder builder = new StringBuilder();
//builder.Append("Last name: ");
//builder.Append(lastName);
//builder.Append(" First name: ");
//builder.Append(firstName);
//string result = builder.ToString();

//Console.WriteLine(result);


//Employee testEmployee = bethany;
//testEmployee.firstName = "Gill";

//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();

//bethany.PerformWork(25);
//int minimumBonus = 100;
//int recievedBonus = bethany.CalcuateBonus(minimumBonus);
//Console.WriteLine($"Min bonus {minimumBonus} and {bethany.firstName} got {recievedBonus}");



//bethany.PerformWork(25);

//int minimumBonus = 100;
//int bonusTax; //=0;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"Min bonus {minimumBonus} and {bethany.firstName} got {receivedBonus} with a tax of {bonusTax}");



//bethany.firstName = "John";
//bethany.hourlyRate = 10;

//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//string fn = bethany.firstName;


//double recievedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid :{recievedWageBethany}");

//Console.WriteLine("Create an employee");
//Console.WriteLine("-------------------------\n");

//Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);
//george.DisplayEmployeeDetails();
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(3);
//george.PerformWork();
//george.PerformWork(8);

//var recievedWageGeorge = george.ReceiveWage(true);