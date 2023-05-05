//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1     4    8   19
//5   -2  33   -2
//77  3    8     1

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void Print2Darray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}");
        }
        System.Console.WriteLine();
    }
}

int Rows = ReadInt("введите количество строк");
int Columns = ReadInt("введите количество колонок");
int[,] arr = Generate2DArray(Rows, Columns);
Print2Darray(arr);

