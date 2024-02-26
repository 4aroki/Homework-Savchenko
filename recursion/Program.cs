// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintInterval(int m, int n)

{

  m = m + 1;

  if (m >= n) {
    return;
  } else {  
    Console.Write(m + " ");
    PrintInterval(m, n);
  }
}
Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Натуральные числа от M до N");
PrintInterval(m, n);