using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = GetFactorial(num);
        Console.WriteLine(result);

    }

    static int GetFactorial(int num)
    {
        if (num == 1) return 1;
        else
        {
            return num * GetFactorial(num - 1);
        }
    }

}






