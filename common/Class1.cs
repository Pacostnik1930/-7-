namespace common;


public static class Helper
{
    public static double[,] Create2DRandomArrayDouble(int m,int n)  // Создание двумерного массива со случайными вещественными числами
    {
        Random random = new Random();
        double[,] array = new double[m, n];
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i * j + Math.Round(random.NextDouble(), 1);
            }
        }
        return array;

    }
    public static int[,] SumIndex(int countOfRows, int countOfColumns)  // Метод нахождения элемента в массиве по формуле A=m+n
    {
        int[,] array = new int[countOfRows, countOfColumns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }
        return array;
    }
    public static void Print2DArray(int[,] arr)
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
    public static int[] CreateRandomArray()  // Создание массива со случайными числами
    {
        Random random = new Random();
        int[] array = new int[10];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }
        return array;

    }

    public static void PrintArray(int[] array)  // Печать массива
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }


    public static int[] ReverseArray(int[] array)  //Переворот массива
    {
        int[] reversedArray = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }
        return reversedArray;
    }


    public static double InputInt()                      // Метод принимает координаты двух точек
    {
        Console.WriteLine("Введите координаты первой точки");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки");
        double b = double.Parse(Console.ReadLine());
        bool isNumber = double.TryParse(Console.ReadLine(), out double number);
        if (isNumber)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Введено некорректное значение");
            return -1;
        }

    }

    // public static double GetDistanceBetweenTwoPoints(double ax, double ay, double bx, double by, double zx, double zy)
    // {
    //     double ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)));
    //     return ab;
    // }
    // Метод для расчета расстояния между двух точек в 3d пространстве

    public static int[] GetCubeTable(int num)       // метод для таблицы кубов
    {
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = (int)((Math.Pow(i + 1, 3)));
        }
        return array;
    }

    public static int HowToConstruction(int a, int b)    //Возведение числа в натуральную степень


    {
        int result = a;
        for (int i = 1; i < b; i++)
        {
            result = result * a;
        }
        return result;
    }

    public static int[] CreateArray()   //Создание массива из элементов
    {
        Console.Write("Введите колличество элементов массива:\t");

        int element = int.Parse(Console.ReadLine());
        int[] array = new int[element];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}:\t");
            array[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("[{0}]", string.Join(", ", array));
        return array;
    }

    public static int InputInt1()                      // Метод принимает координаты двух точек
    {
        Console.WriteLine("Введите целое число");
        bool isNumber = int.TryParse(Console.ReadLine(), out int number);
        if (isNumber)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Введено некорректное значение");
            return -1;
        }

    }
}



