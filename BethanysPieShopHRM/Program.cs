// See https://aka.ms/new-console-template for more information

/*Practice for block commments
Example
*/

Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

//string name2 = Console.ReadLine();

//string name_2 = Console.ReadLine();

//string Name_2 = Console.ReadLine();

//string 2Name = Console.ReadLine();

var monthlyWage = 1234;

//Two variables declared in one line
int yearlyWage = 12, bonus = 1000;

var isActive = true;

var rating = 99.25;

var numberOfEmployees = 300; //Now thati t's var will think it's int, not byte, and work

int hoursWorked;

hoursWorked = 125;

hoursWorked = 148;

//monthlyWage = true //Does not work because type safety.

const double interestRate = 0.07;

string firstName = "Bethany";
string lastName = "Smith";
string emptyString = "";

Console.WriteLine("Please enter your name: ");

//The following will accept the name
string name = Console.ReadLine();

double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3; //ratePerHour = ratePerHour+3

if (currentMonthWage > 2000)
    Console.WriteLine("Top Paid employee");

//int numberOfEmployees = 15;
numberOfEmployees--;

bool a;
int b;

int intMaxValue = int.MaxValue;
int minValue = int.MinValue;

char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);

bool isDigit = char.IsDigit(upperVersion);
bool isLetter = char.IsLetter(upperVersion);



var hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
DateTime exitDate = new DateTime(2025, 12, 11);

//DateTime invalidDate = new DateTime(2025, 15, 11);
DateTime startDate = hireDate.AddDays(15);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);
Console.WriteLine(startHour.ToLongDateString());

int numberofHoursWorked = 165;

long veryLongMonth = numberofHoursWorked; //Works fine

double d = 123456789.0;

int x = (int)d;












Console.ReadLine();