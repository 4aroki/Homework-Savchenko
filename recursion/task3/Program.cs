// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintReversed(int[] arr, int i)
{

    i = i - 1;
    if (i < 0)
    {
        return;
    }

    Console.WriteLine(arr[i]);

    PrintReversed(arr, i);
}


int[] array = { 1, 2, 3, 4, 5};

PrintReversed(array, array.Length);


