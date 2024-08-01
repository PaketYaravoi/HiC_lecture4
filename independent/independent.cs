//Задача 4 напишите программу , которая принимает на воход строку с цифрами и латинскими буквами, а на выходе (покажет строку только числами) создаст массив из чисел:
//    Например: "234Password63" -> "Password"
Console.Write("enter string");
string input = Console.ReadLine();
Console.WriteLine();

int[] arrFromStr = GetArrayFromString(input);
PrintMass(arrFromStr);


int[] GetArrayFromString(string str)
{
    string onlyNumber = String.Empty;

    foreach (char s in str)
    {
        if (char.IsAsciiDigit(s) == true)
        {
            onlyNumber += s;            
        }
    }
    int[] result = onlyNumber.Split().Select(int.Parse).ToArray();

    return result;
    
}

void PrintMass(int[] arr)
{
    foreach (int i in arr)
    {
        Console.WriteLine($"{i} ");
    }
            
}
