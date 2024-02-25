//(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

    static void Main()
    {
        Console.WriteLine("Введите строку из слов, разделенных пробелами:");
        string inputString = Console.ReadLine();

        string reversedString = ReverseWords(inputString);

        Console.WriteLine("Результат: " + reversedString);
    }

    static string ReverseWords(string input)
    {
        // Разделение строки на слова
        string[] words = input.Split(' ');

        // Обратный порядок слов
        Array.Reverse(words);

        // Формирование строки с обратным порядком слов
        string reversedString = string.Join(" ", words);

        return reversedString;
    }

