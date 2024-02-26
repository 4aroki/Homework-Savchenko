// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkermannFunction(m - 1, 1);
    }
    else
    {
        return AkkermannFunction(m - 1, AkkermannFunction(m, n - 1));
    }
}


Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int result = AkkermannFunction(m, n);
Console.WriteLine($"Функция Аккермана для m={m} и n={n} равна: {result}");
