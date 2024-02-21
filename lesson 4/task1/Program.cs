//Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    System.Console.WriteLine("вы ввели:" + input);

 int digitsSum = 0;
 int number = int.Parse(input);
    while (number > 0)
    {
        int digit = number % 10; // Получаем последнюю цифру числа
        digitsSum = digitsSum + digit;

        number /= 10; // Убираем последнюю цифру
       
    }
    if( digitsSum % 2 == 0)
    {
        System.Console.WriteLine("сумма цифр вашего числа четная:" + digitsSum);
        break;
    }
    else 
    {
     System.Console.WriteLine("сумма цифр вашего числа нечетная:" + digitsSum); 
     }

}
