//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите целое число из отрезка [10, 99]");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

int digit1 = number/10;
int digit2 = number%10;
if( digit1 > digit2)
{
    System.Console.WriteLine("наибольшая цифра:" + digit1);
}
else {
    System.Console.WriteLine("наибольшая цифра:" + digit2);
}

