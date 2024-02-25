//(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

string ReverseWords(string input)
{

    // Разделение строки на слова
    string[] words = input.Split(' ');
    // Обращение порядка слов
    Array.Reverse(words);
    // Соединение слов обратно в строку с пробелами
    return string.Join(" ", words);

}


Console.WriteLine("Введите строку из слов, разделенных пробелами:");
string inputString = Console.ReadLine();

string reversedString = ReverseWords(inputString);

Console.WriteLine("Результат: " + reversedString);