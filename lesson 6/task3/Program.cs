//Задайте произвольную строку. Выясните, является ли она палиндромом.

    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        if (IsPalindrome(inputString))
        {
            Console.WriteLine("Это палиндром!");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Убираем пробелы и делаем все буквы строчными для удобства сравнения
        string cleanedStr = str.Replace(" ", "").ToLower();

        int length = cleanedStr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (cleanedStr[i] != cleanedStr[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

