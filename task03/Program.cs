//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int n = InputNum();
int m = InputNum();
int[,] array = CreateRandom2DArray( m, n);
int[,] arr = SumArray[array];



int[,] CreateRandom2DArray(int m, int n)
{
    Random random = new Random();
    int[,] arr = new int[n, m];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 11);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
    return arr;
}

int InputNum()
{
    Console.WriteLine("Введите строку, столбец:  ");
    bool uinput = int.TryParse(Console.ReadLine(), out int num);
    if (uinput)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

  



int SumArray(int[,] arr)
{
    Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} "());
}
return sum;
}
    

    