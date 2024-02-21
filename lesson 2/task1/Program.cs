//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");

string userInput = Console.ReadLine();
int number = int.Parse(userInput);
if(number % 7 ==0 & number % 23 == 0)
{
    System.Console.WriteLine("число кратно 7 и 23");
}
else System.Console.WriteLine("число не кратно");
