//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите x");
string userInput = Console.ReadLine();
int x = int.Parse(userInput);

Console.WriteLine("Введите y");
string userInput2 = Console.ReadLine();
int y = int.Parse(userInput2);

if (x > 0 & y > 0)
{
    System.Console.WriteLine("Первая четверть");
}

else if (x < 0 & y > 0)
{
    System.Console.WriteLine("Вторая четверть");
}
else if (x < 0 & y < 0)
{
    System.Console.WriteLine("Третья четверть");
}
else if (x > 0 & y < 0)
{
    System.Console.WriteLine("Четвертая четверть");
}