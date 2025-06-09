// See https://aka.ms/new-console-template for more information
/*int age = 23;

bool a = age == 23;

Console.WriteLine("Age is 23: " a);

bool b = age > 23;
Console.WriteLine("Age is greater than 23: "+b);

bool c = (age > 18) && (age < 65);
Console.WriteLine("Age is between 18 and 65: " + c);
*/

//Console.WriteLine("Enter candidate age:");
//int age = int.Parse(Console.ReadLine());

//if(age < 18)
//{
//    Console.WriteLine("Too young");
//    Console.WriteLine("Send email to candidate");
//}
//else if (age > 65)
//{
//    Console.WriteLine("Too old");
//    Console.WriteLine("Send email to candidate");
//}
//else
//{
//    Console.WriteLine("Let's get started");
//}

//switch(age)
//{
//    case < 18:
//    case > 65:
//        Console.WriteLine("Not in right age range");
//        break;
//    default:
//        Console.WriteLine("Let's get started");
//        break;
//}

//DateTime today = DateTime.Now;
//bool endOfMonthPaymentStarted = false;

//if (today.Date.Day == 20)
//{
//    Console.WriteLine("Please start end of month  payments");
//}
//else if (today.Date.Day >= 25 && !endOfMonthPaymentStarted)
//{
//    Console.WriteLine("Payments will be late!");
//}
////No else needed

Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");

string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
        Console.WriteLine("Adding new employee...");
        break;
    case "2":
        Console.WriteLine("Updating employee...");
        break;
    case "3":
        Console.WriteLine("Deleting employee...");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
