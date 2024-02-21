// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число N");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

while (number > 0)
{
    int digit = number % 10; // Получаем последнюю цифру числа
    Console.Write(digit);

    number /= 10; // Убираем последнюю цифру
    if (number > 0)
    {
        Console.Write(", ");
    }
}