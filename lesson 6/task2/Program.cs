//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

    static void Main()
    {
        // Задаем строку с латинскими буквами в обоих регистрах
        string inputString = "HeLLoWorLD";

        // Вызываем метод для замены всех заглавных букв на строчные
        string resultString = ConvertToUpperToLower(inputString);

        // Выводим результат
        Console.WriteLine(resultString);
    }

    static string ConvertToUpperToLower(string input)
    {
        // Проходим по каждому символу в строке
        char[] chars = input.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            // Проверяем, является ли символ заглавной буквой
            if (char.IsUpper(chars[i]))
            {
                // Заменяем заглавную букву на строчную
                chars[i] = char.ToLower(chars[i]);
            }
        }

        // Формируем строку из измененных символов
        return new string(chars);
    }

