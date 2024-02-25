//Задайте произвольную строку. Выясните, является ли она палиндромом.

    bool IsPalindrome(string input)
    {

      int length = input.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

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
