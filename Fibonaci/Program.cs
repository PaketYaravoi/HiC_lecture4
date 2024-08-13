using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter integer: ");

        int number = 0;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Input Error!");
        }
        Console.WriteLine();

        for (int i = 1; i <= number; i++)
        {
            Console.Write($"Fibonaci at number {i} =  ");
            Console.WriteLine(Fibonachi(i));
        }
        
        static double Fibonachi(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(num - 1) + Fibonachi(num - 2);
            
            }


        }
    }
}
