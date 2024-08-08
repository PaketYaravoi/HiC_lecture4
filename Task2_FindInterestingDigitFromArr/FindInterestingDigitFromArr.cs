

int[,] mass2D = GetMass(5, 5);

PrintMass(mass2D);
Console.WriteLine();

Console.WriteLine("interesting value");
Console.WriteLine();
PrintInteresNumbers(mass2D);

int[,] GetMass(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(-99, 101);
        }
    }
    return matrix;
}

void PrintMass(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintInteresNumbers(int[,] mass)
{

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            int numberFromMass = mass[i, j];

            if (numberFromMass < 0)
            {
                numberFromMass = -numberFromMass;
            }
            int sumOfDigit = 0;
            while (numberFromMass > 0)
            {
                sumOfDigit += numberFromMass % 10; // получаем последнюю цифру от числа под индексом [i,j] и прибовляем к сумме
                numberFromMass /= 10;   // укарачиваем число на ту же цифру что прибавили , например было 407 --> 40
            }
            if (sumOfDigit % 2 == 0)
            {
                Console.Write($"{mass[i, j]} ");
            }
        }
    }
}


