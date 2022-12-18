//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//using static common.Helper;

int positionA = InputInt();
int positionB = InputInt();
int m=3;
int n=4;
int[,]array=CreateRandom2DArray(m,n);
PrintResult();

int[,] CreateRandom2DArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    Console.Write("Наш исходный массив");

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10,99);
            Console.Write("{0}",array[i,j]);
        }
        Console.WriteLine();
    }
    return array;
}


int InputInt()
{
        Console.WriteLine("Введите строку,столбец: ");
        bool uinput = int.TryParse(Console.ReadLine(), out int number);
        if (uinput)
        {
            return number -1;
        }
        else
        {
            Console.WriteLine("Такого числа в массиве нет");
            return -1;
        }

    }

    void PrintResult()
{
    if (positionA < 0 | positionB > array.GetLength(0) - 1 | positionB < 0 | positionB > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[positionA, positionB]);
    }    
}
