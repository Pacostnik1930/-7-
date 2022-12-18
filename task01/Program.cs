//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//using static common.Helper;

double[,] result = CreateRandom2DArray(3, 4);
Print2DArray(result);


double[,] CreateRandom2DArray(int m, int n)
{
    Random random = new Random();
    double[,] array = new double[m, n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =  i * j + Math.Round(random.NextDouble(), 1);
        }
    }
    return array;
}

void Print2DArray(double[,] arr)
    {

        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }

    }