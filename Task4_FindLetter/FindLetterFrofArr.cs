//Задача 4 напишите программу , которая принимает на воход строку с цифрами и латинскими буквами, а на выходе покажет строку только с латинскими символами:
//    Например: "234Password63" -> "Password"

string input = Console.ReadLine();
Console.WriteLine(input);
Console.WriteLine();

string stringNew = GetLetterFromString(input);
Console.WriteLine(stringNew);

string GetLetterFromString(string str)
{
    string result = String.Empty;

    foreach (char s in str)
    {
        if (char.IsAsciiLetter(s) == true) // использование внутреннего метода Ascii поиск в таблице Аски , символов-букв
        {
            result += s; // если компелятор увидит что к строке мы пытаемся прибавить(+) символ , ругаться он не будет , и првильно все склеит
        }

    }
    return result;
} 
