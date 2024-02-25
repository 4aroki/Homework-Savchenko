//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string ConvertUpperToLower(string input)
{

    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {

        if (char.IsUpper(chars[i]))
        {

            chars[i] = char.ToLower(chars[i]);
        }
    }


    return new string(chars);
}

string inputString = "HeLLoWorLD";
string resultString = ConvertUpperToLower(inputString);
Console.WriteLine(resultString);
