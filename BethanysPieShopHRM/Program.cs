// See https://aka.ms/new-console-template for more information

using BethanysPieShopHRM;
using System.Numerics;

int amount = 1234;
int months = 12;
int bonus = 1000;
Utilities.CalculateYearlyWage(amount, months, bonus);
int yearlywage = Utilities.CalculateYearlyWage(amount, months);

Console.WriteLine($"Yearly wage: {yearlywage}");

Console.ReadLine();
